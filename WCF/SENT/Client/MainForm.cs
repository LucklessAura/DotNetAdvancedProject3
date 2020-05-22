using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;


namespace ProjectGUI
{
    public partial class Main : Form
    {
        //interfaceClassesClient cc = new interfaceClassesClient();
        ImageList imageList = new ImageList();
        public Main()
        {

            InitializeComponent();
            currentParametesGrid.Columns.Add(null, "Data Type");
            currentParametesGrid.Columns.Add(null, "Data Value");
            imageList.ImageSize = new Size(128, 128);
            DocumentsListView.LargeImageList = imageList;
            deletedListView.LargeImageList = imageList;
        }

        private void folderUploader_HelpRequest(object sender, EventArgs e)
        {
            // creeaza dialogul pentru selectarea unui folder si apeleaza functia care creeaza dialogul pentru adaugarea acelui fisier in baza de date pentru fiecare
            // fisier care are extensia potrivita
            string path = "";
            using (FolderBrowserDialog openFolderDialog = new FolderBrowserDialog())
            {
                var result = openFolderDialog.ShowDialog();
                path = openFolderDialog.SelectedPath;
                if (result == DialogResult.OK)
                {
                    foreach (var entry in Directory.GetFiles(path))
                    {
                        FileInfo fileInfo = new FileInfo(entry);
                        if ((new string[] { ".jpg", ".jpeg", ".png", ".gif", ".mpeg", ".ogv", ".webm", ".bmp", ".avi" }).Contains(fileInfo.Extension))
                        {
                            NewFileUploadWindow(fileInfo.FullName);
                        }
                    }
                }
            }

        }

        private void fileUploader_HelpRequest(object sender, EventArgs e)
        {
            // creeaza dialogul pentru selectarea unui fisier si apeleaza functia care creeaza dialogul pentru adaugarea acelui fisier in baza de date
            string path = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.jpeg)|*.jpeg|(*.gif)|*.gif|(*.avi)|*.avi|(*.mpeg)|*.mpeg|(*.ogv)|*.ogv|(*.webm)|*.webm|(*.bmp)|*.bmp";
                DialogResult result = openFileDialog.ShowDialog();
                path = openFileDialog.FileName;
                if (result == DialogResult.OK)
                {
                    NewFileUploadWindow(path);
                }

            }

        }

        private void addNormalSearchParameters_Click(object sender, EventArgs e)
        {
            // adauga sau modifica valorile campurilor cu proprietatile principale principale de date in grid
            string fileName = PhotoNameInput.Text;
            DateTime creationDate = dateTimeInput.Value;
            string ocasion = OcasionInput.Text;
            string people = PeopleInput.Text;
            string place = PlaceInput.Text;
            DataGridViewRow result;
            result = currentParametesGrid.Rows.Cast<DataGridViewRow>()
                .Where(x => Convert.ToString(x.Cells[0].Value) == "FileName")
                .FirstOrDefault(x => x.Cells[1] != null);
            if (result != null)
            {
                result.Cells[1].Value = fileName;
            }
            else
            {
                string[] nameRow = new string[] { "FileName", fileName };
                currentParametesGrid.Rows.Add(nameRow);
            }

            result = currentParametesGrid.Rows.Cast<DataGridViewRow>()
                .Where(x => Convert.ToString(x.Cells[0].Value) == "DateCreated")
                .FirstOrDefault(x => x.Cells[1] != null);
            if (result != null)
            {
                if (creationDate.ToShortDateString().ToString() != DateTime.Parse("1-JAN-52").ToShortDateString().ToString())
                {
                    result.Cells[1].Value = creationDate.ToShortDateString().ToString();
                }
                else
                {
                    result.Cells[1].Value = "";
                }

            }
            else
            {
                string[] dateRow = new string[] { "DateCreated", creationDate.ToShortDateString().ToString() };
                if (creationDate.ToShortDateString().ToString() != DateTime.Parse("1-JAN-52").ToShortDateString().ToString())
                {
                    currentParametesGrid.Rows.Add(dateRow);
                }
                else
                {
                    currentParametesGrid.Rows.Add(new string[] { "DateCreated", "" });
                }
            }

            result = currentParametesGrid.Rows.Cast<DataGridViewRow>()
                .Where(x => Convert.ToString(x.Cells[0].Value) == "Ocasion")
                .FirstOrDefault(x => x.Cells[1] != null);
            if (result != null)
            {
                result.Cells[1].Value = ocasion;
            }
            else
            {
                string[] ocasionRow = new string[] { "Ocasion", ocasion };
                currentParametesGrid.Rows.Add(ocasionRow);
            }

            result = currentParametesGrid.Rows.Cast<DataGridViewRow>()
                .Where(x => Convert.ToString(x.Cells[0].Value) == "People")
                .FirstOrDefault(x => x.Cells[1] != null);
            if (result != null)
            {
                result.Cells[1].Value = people;
            }
            else
            {
                string[] peopleRow = new string[] { "People", people };
                currentParametesGrid.Rows.Add(peopleRow);
            }
            result = currentParametesGrid.Rows.Cast<DataGridViewRow>()
                .Where(x => Convert.ToString(x.Cells[0].Value) == "Place")
                .FirstOrDefault(x => x.Cells[1] != null);
            if (result != null)
            {
                result.Cells[1].Value = place;
            }
            else
            {
                string[] placeRow = new string[] { "Place", place };
                currentParametesGrid.Rows.Add(placeRow);
            }


        }

        private void AddCustomSearchParameter(object sender, EventArgs e)
        {
            // adauga sau modifica valorile campurilor cu proprietatile custom de date in grid
            string parameterName = ProprietyInput.Text;
            string parameterValue = ProprietyValueInput.Text;

            var result = currentParametesGrid.Rows.Cast<DataGridViewRow>()
                .Where(x => Convert.ToString(x.Cells[0].Value) == parameterName)
                .FirstOrDefault(x => x.Cells[1] != null);
            if (result != null)
            {
                result.Cells[1].Value = parameterValue;
            }
            else
            {
                string[] customRow = new string[] { parameterName, parameterValue };
                currentParametesGrid.Rows.Add(customRow);
            }
        }

        private CancelEventHandler NewFileUploadWindow(string path)
        {
            // creeaza Form-ul pentru adaugarea unei imagini noi in baza de date
            var addFile = new addFileForm
            {
                path = path,
                Text = path
            };
            addFile.pictureBox.ImageLocation = path;
            addFile.ShowDialog();
            return null;
        }

        private void performSearch(object sender, EventArgs e)
        {
            // apeleaza API-ul pentru cautarea fisierelor care au toti parametrii, se ocupe de asemenea de creearea iconitelor pentru imagini si de adaugarea lor cat si a 
            // numelor imaginilor in list view-urile potrivite 
            var rows = currentParametesGrid.Rows.Cast<DataGridViewRow>().ToList();
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            foreach (var row in rows)
            {
                parameters.Add(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
            }

            interfaceClassesClient cc = new interfaceClassesClient();
            var response = cc.SearchFiles(parameters);

            var responseAlive = response.Item1;
            var responseDeleted = response.Item2;
            DocumentsListView.Items.Clear();
            deletedListView.Items.Clear();
            imageList.Images.Clear();


            foreach (var file in responseAlive)
            {
                try
                {
                    var bitmap = new Bitmap(file.FilePath, true);

                    var iconHandle = bitmap.GetHicon();
                    var icon = Icon.FromHandle(iconHandle);

                    if (!imageList.Images.ContainsKey(file.FileId.ToString()))
                    {
                        imageList.Images.Add(file.FileId.ToString(), icon);
                    }
                    icon.Dispose();
                    bitmap.Dispose();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show("The file at " + file.FilePath + " is no longer there, please delete it from the database");
                }

                var listViewItem = DocumentsListView.Items.Add(file.FileName);
                listViewItem.ImageKey = file.FileId.ToString();
                ListViewSubItem pathSubItem = new ListViewSubItem();
                ListViewSubItem idSubItem = new ListViewSubItem();
                pathSubItem.Name = "Path";
                pathSubItem.Text = file.FilePath;
                listViewItem.SubItems.Add(pathSubItem);
                idSubItem.Name = "Id";
                idSubItem.Text = file.FileId.ToString();
                listViewItem.SubItems.Add(idSubItem);

            }


            foreach (var file in responseDeleted)
            {
                try
                {
                    var bitmap = new Bitmap(file.FilePath, true);
                    var iconHandle = bitmap.GetHicon();
                    var icon = Icon.FromHandle(iconHandle);


                    if (!imageList.Images.ContainsKey(file.FileId.ToString()))
                    {
                        imageList.Images.Add(file.FileId.ToString(), icon);
                    }
                    bitmap.Dispose();
                    icon.Dispose();
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("The file at " + file.FilePath + " named " + file.FileName + "  is no longer there, please delete it from the app.");
                }
                var listViewItem = deletedListView.Items.Add(file.FileName);
                listViewItem.ImageKey = file.FileId.ToString();
                ListViewSubItem pathSubitem = new ListViewSubItem();
                ListViewSubItem idSubItem = new ListViewSubItem();
                pathSubitem.Name = "Path";
                pathSubitem.Text = file.FilePath;
                listViewItem.SubItems.Add(pathSubitem);
                idSubItem.Name = "Id";
                idSubItem.Text = file.FileId.ToString();
                listViewItem.SubItems.Add(idSubItem);

            }

            cc.Close();
            MessageBox.Show("Search Done");

        }


        private void FileViewer(object sender, MouseEventArgs e)
        {
            // la double-click pe un element porneste un process pentru a vizualiza acel fisier, de deschiderea fisierului in sine se ocupa OS-ul
            if (e.Button == MouseButtons.Left)
            {

                var file = sender as ListView;
                foreach (ListViewItem item in file.SelectedItems)
                {

                    Process.Start(item.SubItems["Path"].Text);
                }
            }


        }

        private void DeleteAliveItem(object sender, EventArgs e)
        {
            // Apeleaza API-ul pentru a marca ca "Deleted" in baza de date elementele selectate din list view-ul celor "Alive"
            interfaceClassesClient cc = new interfaceClassesClient();
            foreach (ListViewItem item in DocumentsListView.SelectedItems)
            {
                bool result = cc.DeleteFile(int.Parse(item.SubItems["Id"].Text));
                if (result == true)
                {

                    DocumentsListView.Items.Remove(item);
                    deletedListView.Items.Add(item);
                }
            }

            cc.Close();

        }

        private void DefinitiveDelete(object sender, EventArgs e)
        {
            // Apeleaza API-ul pentru a sterge definitiv din baza de date elementele selectate din list view-ul celor "Deleted"
            interfaceClassesClient cc = new interfaceClassesClient();
            foreach (ListViewItem item in deletedListView.SelectedItems)
            {
                bool result = cc.DefinitiveDelete(int.Parse(item.SubItems["Id"].Text));
                if (result == true)
                {
                    deletedListView.Items.Remove(item);
                }

            }
            cc.Close();
        }


        private void Restore(object sender, EventArgs e)
        {
            // Apeleaza API-ul pentru a modifica proprietatea "Deleted" din baza de date tuturor fisierelor selectate din list view-ul celor "Deleted" 
            interfaceClassesClient cc = new interfaceClassesClient();
            foreach (ListViewItem item in deletedListView.SelectedItems)
            {

                cc.Restore(int.Parse(item.SubItems["Id"].Text));

                deletedListView.Items.Remove(item);
                DocumentsListView.Items.Add(item);


            }

            cc.Close();
        }

        private void EditAliveItem(object sender, EventArgs e)
        {
            // creeaza dialogul pentru modificarea fiecarui fisier selectat si marcat ca "Alive"
            // deasemena modifica unele proprietati ale dialogului pentru a modifica nu adauga fisiere
            interfaceClassesClient cc = new interfaceClassesClient();
            foreach (ListViewItem item in DocumentsListView.SelectedItems)
            {
                using (var dialog = new addFileForm())
                {

                    Dictionary<string, string> proprieties = cc.GetFileProprieties(int.Parse(item.SubItems["Id"].Text));
                    foreach (KeyValuePair<string, string> pair in proprieties)
                    {
                        dialog.currentParametesGrid.Rows.Add(pair.Key, pair.Value);
                    }

                    dialog.fileId = int.Parse(item.SubItems["Id"].Text);
                    dialog.mode = "modify";
                    dialog.path = item.SubItems["Path"].Text;
                    dialog.Text = "Modify Item";
                    dialog.modify();
                    dialog.ShowDialog();
                }
            }
            cc.Close();
        }

        private void EditDeletedItem(object sender, EventArgs e)
        {
            // creeaza dialogul pentru modificarea fiecarui fisier selectat si marcat ca "Deleted"
            // deasemena modifica unele proprietati ale dialogului pentru a modifica nu adauga fisiere
            interfaceClassesClient cc = new interfaceClassesClient();
            foreach (ListViewItem item in deletedListView.SelectedItems)
            {
                using (var dialog = new addFileForm())
                {

                    Dictionary<string, string> proprieties = cc.GetFileProprieties(int.Parse(item.SubItems["Id"].Text));
                    foreach (KeyValuePair<string, string> pair in proprieties)
                    {
                        dialog.currentParametesGrid.Rows.Add(pair.Key, pair.Value);
                    }

                    dialog.fileId = int.Parse(item.SubItems["Id"].Text);
                    dialog.mode = "modify";
                    dialog.path = item.SubItems["Path"].Text;
                    dialog.Text = "Modify Item";
                    dialog.modify();
                    dialog.ShowDialog();
                }
            }

            cc.Close();
        }


        private void PrintAliveItem(object sender, EventArgs e)
        {
            // creeaza dialogul pentru printarea si un dialog de preview pentru fiecare fisier selctat marcate ca "Alive"

            foreach (ListViewItem item in DocumentsListView.SelectedItems)
            {
                PrintDialog printDialog = new PrintDialog();
                PrintDocument printDocument = new PrintDocument();
                printDialog.Document = printDocument;
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog
                {
                    Document = printDocument
                };
                printDocument.PrintPage += (s, ev) => PrintDocument_PrintPage(s, ev, item);
                printPreviewDialog.Show();
                printDialog.ShowDialog();
            }
        }

        private void PrintDeletedItem(object sender, EventArgs e)
        {
            // creeaza dialogul pentru printarea si un dialog de preview pentru fiecare fisier selctat marcate ca "Deleted"
            foreach (ListViewItem item in deletedListView.SelectedItems)
            {
                PrintDialog printDialog = new PrintDialog();
                PrintDocument printDocument = new PrintDocument();
                printDialog.Document = printDocument;
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog
                {
                    Document = printDocument
                };
                printDocument.PrintPage += (s, ev) => PrintDocument_PrintPage(s, ev, item);
                printPreviewDialog.Show();
                printDialog.ShowDialog();
            }
        }


        private void SaveAliveItem(object sender, EventArgs e)
        {
            // copiaza fisierele selectate marcate ca "Alive" catre un path care va fi selectat prin intermediul unu FolderBrowserDialog
            interfaceClassesClient cc = new interfaceClassesClient();
            string pathToSave;
            List<int> fileIds = new List<int>();
            foreach (ListViewItem item in DocumentsListView.SelectedItems)
            {
                fileIds.Add(int.Parse(item.SubItems["Id"].Text));
            }

            using (FolderBrowserDialog openFolderDialog = new FolderBrowserDialog())
            {
                var result = openFolderDialog.ShowDialog();
                ;
                if (result == DialogResult.OK)
                {
                    pathToSave = openFolderDialog.SelectedPath;
                    try
                    {

                        cc.CopyFilesToPath(pathToSave, fileIds.ToArray());

                        MessageBox.Show("Done");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("The following exception has occured : \n" + ex.Message + "\n please delete from the app any file that is no longer avariable and be sure to have permission over the files and folders.");
                    }
                }
            }

            cc.Close();
        }

        private void SaveDeletedItem(object sender, EventArgs e)
        {
            // copiaza fisierele selectate marcate ca "Deleted" catre un path care va fi selectat prin intermediul unu FolderBrowserDialog
            interfaceClassesClient cc = new interfaceClassesClient();
            string pathToSave;
            List<int> fileIds = new List<int>();
            foreach (ListViewItem item in deletedListView.SelectedItems)
            {
                fileIds.Add(int.Parse(item.SubItems["Id"].Text));
            }

            using (FolderBrowserDialog openFolderDialog = new FolderBrowserDialog())
            {
                var result = openFolderDialog.ShowDialog();
                ;
                if (result == DialogResult.OK)
                {
                    pathToSave = openFolderDialog.SelectedPath;
                    try
                    {

                        cc.CopyFilesToPath(pathToSave, fileIds.ToArray());

                        MessageBox.Show("Done");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("The following exception has occured : \n" + ex.Message + "\n please delete from the app any file that is no longer avariable and be sure to have permission over the files and folders.");
                    }
                }
            }

            cc.Close();
        }


        private void MoveDeletedItem(object sender, EventArgs e)
        {
            // muta fisierele selectate marcate ca "Deleted" catre un path care va fi selectat prin intermediul unu FolderBrowserDialog
            interfaceClassesClient cc = new interfaceClassesClient();
            string pathToSave;
            List<int> fileIds = new List<int>();
            foreach (ListViewItem item in deletedListView.SelectedItems)
            {
                fileIds.Add(int.Parse(item.SubItems["Id"].Text));
            }

            using (FolderBrowserDialog openFolderDialog = new FolderBrowserDialog())
            {
                var result = openFolderDialog.ShowDialog();
                ;
                if (result == DialogResult.OK)
                {
                    pathToSave = openFolderDialog.SelectedPath;
                    try
                    {

                        cc.MoveFilesToPath(pathToSave, fileIds.ToArray());

                        MessageBox.Show("Done");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("The following exception has occured : \n" + ex.Message + "\n please delete from the app any file that is no longer avariable and be sure to have permission over the files and folders.");
                    }
                }
            }

            cc.Close();
        }

        private void MoveAliveItem(object sender, EventArgs e)
        {
            // muta fisierele selectate marcate ca "Alive" catre un path care va fi selectat prin intermediul unu FolderBrowserDialog
            interfaceClassesClient cc = new interfaceClassesClient();
            string pathToSave;
            List<int> fileIds = new List<int>();
            foreach (ListViewItem item in DocumentsListView.SelectedItems)
            {
                fileIds.Add(int.Parse(item.SubItems["Id"].Text));
            }

            using (FolderBrowserDialog openFolderDialog = new FolderBrowserDialog())
            {
                var result = openFolderDialog.ShowDialog();
                ;
                if (result == DialogResult.OK)
                {
                    pathToSave = openFolderDialog.SelectedPath;
                    try
                    {
                        cc.MoveFilesToPath(pathToSave, fileIds.ToArray());

                        MessageBox.Show("Done");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("The following exception has occured : \n" + ex.Message + "\n please delete from the app any file that is no longer avariable and be sure to have permission over the files and folders.");
                    }
                }
            }

            cc.Close();
        }

        private void EmailAliveItem(object sender, EventArgs e)
        {
            // creeaza Form-ul pentru a trimite email-uri cu toate imaginile selectate din list view-ul fisierelor alive
            List<int> fileIds = new List<int>();
            foreach (ListViewItem item in DocumentsListView.SelectedItems)
            {
                fileIds.Add(int.Parse(item.SubItems["Id"].Text));
            }
            using (var emailSender = new EmailForm())
            {
                emailSender.fileIds = fileIds;
                emailSender.ShowDialog();
            }
        }

        private void EmailDeletedItem(object sender, EventArgs e)
        {
            // creeaza Form-ul pentru a trimite email-uri cu toate imaginile selectate din list view-ul celor marcate ca "Deleted"
            List<int> fileIds = new List<int>();
            foreach (ListViewItem item in deletedListView.SelectedItems)
            {
                fileIds.Add(int.Parse(item.SubItems["Id"].Text));
            }
            using (var emailSender = new EmailForm())
            {
                emailSender.fileIds = fileIds;
                emailSender.ShowDialog();
            }
        }


        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e, ListViewItem item)
        {
            // handler pentru actiunea de print page, creeaza o imagine a fisierului si ii modifica marimiea astfel incat sa incapa pe pagina 

            Image image = Image.FromFile(item.SubItems["Path"].Text);
            if (image.Width > image.Height)
            {
                image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

            float ratioWH = image.Width / (float)image.Height;
            float ratioTrueW = 700 / (float)image.Width;
            float ratioTrueH = 1050 / (float)image.Height;
            int width = (int)Math.Min((image.Width * ratioTrueW), image.Height * ratioTrueH * ratioWH);
            int height = (int)Math.Min((image.Height * ratioTrueH), image.Height * ratioTrueW);
            Bitmap bitmap = new Bitmap(image, new Size(width, height));
            PointF ulCorner = new PointF(1, 1);
            image.Dispose();
            e.Graphics.DrawImage(bitmap, ulCorner);
            bitmap.Dispose();
        }

        private void ContextMenuAlive(object sender, MouseEventArgs e)
        {
            //creeaza context pentru unul sau mai multe fisiere din list view-ul fisirelor "alive"
            if (e.Button == MouseButtons.Right)
            {

                var aliveListView = sender as ListView;

                ContextMenu contextMenu = new ContextMenu();
                contextMenu.MenuItems.Add(new MenuItem("Delete", DeleteAliveItem));
                contextMenu.MenuItems.Add(new MenuItem("Edit", EditAliveItem));
                contextMenu.MenuItems.Add(new MenuItem("Email", EmailAliveItem));
                contextMenu.MenuItems.Add(new MenuItem("Move", MoveAliveItem));
                contextMenu.MenuItems.Add(new MenuItem("Print", PrintAliveItem));
                contextMenu.MenuItems.Add(new MenuItem("Save to...", SaveAliveItem));
                contextMenu.Show(aliveListView, new Point(e.X, e.Y));
            }
        }

        private void ContextMenuDeleted(object sender, MouseEventArgs e)
        {
            // creeaza context menu pentru unul sau mai multe fisiere din list view-ul fisierelor sterse
            if (e.Button == MouseButtons.Right)
            {

                var deletedList = sender as ListView;

                var contextMenu = new ContextMenu();
                contextMenu.MenuItems.Add(new MenuItem("Definitive Delete", DefinitiveDelete));
                contextMenu.MenuItems.Add(new MenuItem("Edit", EditDeletedItem));
                contextMenu.MenuItems.Add(new MenuItem("Print", PrintDeletedItem));
                contextMenu.MenuItems.Add(new MenuItem("Move", MoveDeletedItem));
                contextMenu.MenuItems.Add(new MenuItem("Email", EmailDeletedItem));
                contextMenu.MenuItems.Add(new MenuItem("Restore", Restore));
                contextMenu.MenuItems.Add(new MenuItem("Save to...", SaveDeletedItem));
                contextMenu.Show(deletedList, new Point(e.X, e.Y));

            }
        }

        private void ClearSearchParameters(object sender, EventArgs e)
        {
            // sterge toate datele din grid
            currentParametesGrid.Rows.Clear();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            // handler pentru checkbox, daca acesta este selectat modifica data in "1-JAN-52" (valoare pentru care este considerat null )  si dezactiveaza Date Picker-ul
            // daca este deselectata modifica data in ziua actuala si activeaza Date Picker-ul
            if (ignoreDateCheckBox.Checked)
            {
                dateTimeInput.Value = DateTime.Parse("1-JAN-52");
                dateTimeInput.Enabled = false;
            }
            else
            {
                dateTimeInput.Value = DateTime.Now;
                dateTimeInput.Enabled = true;
            }
        }
    }
}
