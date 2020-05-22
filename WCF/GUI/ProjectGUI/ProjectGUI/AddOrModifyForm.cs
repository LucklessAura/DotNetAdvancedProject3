using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace ProjectGUI
{
    public partial class addFileForm : Form
    {
        //interfaceClassesClient cc = new interfaceClassesClient();
        public string path { set; get; }

        public string mode { set; get; }

        public int fileId { set; get; }
        public addFileForm()
        {
            InitializeComponent();
            currentParametesGrid.Columns.Add(null, "Data Type");
            currentParametesGrid.Columns.Add(null, "Data Value");
        }

        public void modify()
        {
            //metoda care modifica functionalitatea ferestrei din adaugare fisier in modificare fisier
            AddPhotoButton.Text = "Modify";
            AddPhotoButton.Click -= fileUpload;
            AddPhotoButton.Click += fileModify;
            pictureBox.ImageLocation = path;
        }

        private void fileModify(object sender, EventArgs e)
        {
            // metoda care se ocupa de apelarea API-ului pentru a modifica un fisier, de asemenea verifica validitatea datelor
            interfaceClassesClient cc = new interfaceClassesClient();
            var rows = currentParametesGrid.Rows.Cast<DataGridViewRow>().ToList();
                Dictionary<string, string> parameters = new Dictionary<string, string>();
                foreach (var row in rows)
                {
                    parameters.Add(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
                }
                if (parameters.ContainsKey("FileName") && parameters.ContainsKey("DateCreated"))
                {
                    DateTime datetime;
                    if (parameters["FileName"] != "" && DateTime.TryParse(parameters["DateCreated"], out datetime))
                        if (datetime.ToShortDateString() == parameters["DateCreated"])
                        {
                            cc.ModifyFile(fileId, parameters);
                            cc.Close();
                            Dispose();
                            return;
                        }
                }
            
            MessageBox.Show("FileName or DateCreated are invalid");
            
            return;

        }
        private void fileUpload(object sender, EventArgs e)
        {
            // metoda care apeleaza API-ul pentru a adauga un fisier in baza de date, de asemenea verifica validitatea datelor
            interfaceClassesClient cc = new interfaceClassesClient();
            var rows = currentParametesGrid.Rows.Cast<DataGridViewRow>().ToList();
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            foreach (var row in rows)
            {
                parameters.Add(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
            }
            parameters.Add("FilePath", path);

            if (parameters.ContainsKey("FileName") && parameters.ContainsKey("DateCreated"))
            {
                DateTime datetime;
                if (parameters["FileName"] != "" && DateTime.TryParse(parameters["DateCreated"], out datetime))
                    if (datetime.ToShortDateString() == parameters["DateCreated"])
                    {
                        cc.AddNewFile(parameters);

                        cc.Close();
                        Dispose();
                        return;
                    }
            }
            MessageBox.Show("FileName or DateCreated are invalid");

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

                result.Cells[1].Value = creationDate.ToShortDateString().ToString();
            }
            else
            {
                string[] dateRow = new string[] { "DateCreated", creationDate.ToShortDateString().ToString() };

                currentParametesGrid.Rows.Add(dateRow);

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

        private void addCustomSearchParameter(object sender, EventArgs e)
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


        private void clearSearchParameters(object sender, EventArgs e)
        {
            //sterge toate datele din grid

            currentParametesGrid.Rows.Clear();
        }

    }
}
