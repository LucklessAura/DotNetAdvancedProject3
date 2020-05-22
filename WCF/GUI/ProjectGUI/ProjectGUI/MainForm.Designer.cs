namespace ProjectGUI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchContainer = new System.Windows.Forms.GroupBox();
            this.clearSearchParametersButton = new System.Windows.Forms.Button();
            this.currentParametesGrid = new System.Windows.Forms.DataGridView();
            this.CustomAttributesSearchContainer = new System.Windows.Forms.GroupBox();
            this.AddCustomSearchParametersButtons = new System.Windows.Forms.Button();
            this.ProprietyValueLabel = new System.Windows.Forms.Label();
            this.ProprietyValueInput = new System.Windows.Forms.TextBox();
            this.ProprietyNameLabel = new System.Windows.Forms.Label();
            this.ProprietyInput = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.StandardSearchContainer = new System.Windows.Forms.GroupBox();
            this.ignoreDateCheckBox = new System.Windows.Forms.CheckBox();
            this.dateTimeInput = new System.Windows.Forms.DateTimePicker();
            this.AddStandardSearchParametersButton = new System.Windows.Forms.Button();
            this.PlaceInput = new System.Windows.Forms.TextBox();
            this.PlaceLabel = new System.Windows.Forms.Label();
            this.PeopleInput = new System.Windows.Forms.TextBox();
            this.PeopleLabel = new System.Windows.Forms.Label();
            this.OcasionInput = new System.Windows.Forms.TextBox();
            this.OcasionLabel = new System.Windows.Forms.Label();
            this.DateCreatedLabel = new System.Windows.Forms.Label();
            this.PhotoNameLabel = new System.Windows.Forms.Label();
            this.PhotoNameInput = new System.Windows.Forms.TextBox();
            this.UploadFileButton = new System.Windows.Forms.Button();
            this.UploadFolderButton = new System.Windows.Forms.Button();
            this.ControlsContainer = new System.Windows.Forms.GroupBox();
            this.filesTabControl = new System.Windows.Forms.TabControl();
            this.photosTabPage = new System.Windows.Forms.TabPage();
            this.DocumentsListView = new System.Windows.Forms.ListView();
            this.deletedPhotosTabPage = new System.Windows.Forms.TabPage();
            this.deletedListView = new System.Windows.Forms.ListView();
            this.SearchContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentParametesGrid)).BeginInit();
            this.CustomAttributesSearchContainer.SuspendLayout();
            this.StandardSearchContainer.SuspendLayout();
            this.ControlsContainer.SuspendLayout();
            this.filesTabControl.SuspendLayout();
            this.photosTabPage.SuspendLayout();
            this.deletedPhotosTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchContainer
            // 
            this.SearchContainer.Controls.Add(this.clearSearchParametersButton);
            this.SearchContainer.Controls.Add(this.currentParametesGrid);
            this.SearchContainer.Controls.Add(this.CustomAttributesSearchContainer);
            this.SearchContainer.Controls.Add(this.SearchButton);
            this.SearchContainer.Controls.Add(this.StandardSearchContainer);
            this.SearchContainer.Location = new System.Drawing.Point(8, 147);
            this.SearchContainer.Name = "SearchContainer";
            this.SearchContainer.Size = new System.Drawing.Size(814, 433);
            this.SearchContainer.TabIndex = 5;
            this.SearchContainer.TabStop = false;
            this.SearchContainer.Text = "Search";
            // 
            // clearSearchParametersButton
            // 
            this.clearSearchParametersButton.Location = new System.Drawing.Point(537, 281);
            this.clearSearchParametersButton.Name = "clearSearchParametersButton";
            this.clearSearchParametersButton.Size = new System.Drawing.Size(131, 21);
            this.clearSearchParametersButton.TabIndex = 24;
            this.clearSearchParametersButton.Text = "Clear Parameters";
            this.clearSearchParametersButton.UseVisualStyleBackColor = true;
            this.clearSearchParametersButton.Click += new System.EventHandler(this.ClearSearchParameters);
            // 
            // currentParametesGrid
            // 
            this.currentParametesGrid.AllowUserToAddRows = false;
            this.currentParametesGrid.AllowUserToDeleteRows = false;
            this.currentParametesGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = "*ANY*";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.currentParametesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.currentParametesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.NullValue = "*ANY*";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.currentParametesGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.currentParametesGrid.Location = new System.Drawing.Point(535, 19);
            this.currentParametesGrid.MultiSelect = false;
            this.currentParametesGrid.Name = "currentParametesGrid";
            this.currentParametesGrid.ReadOnly = true;
            this.currentParametesGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.currentParametesGrid.Size = new System.Drawing.Size(273, 239);
            this.currentParametesGrid.TabIndex = 23;
            // 
            // CustomAttributesSearchContainer
            // 
            this.CustomAttributesSearchContainer.Controls.Add(this.AddCustomSearchParametersButtons);
            this.CustomAttributesSearchContainer.Controls.Add(this.ProprietyValueLabel);
            this.CustomAttributesSearchContainer.Controls.Add(this.ProprietyValueInput);
            this.CustomAttributesSearchContainer.Controls.Add(this.ProprietyNameLabel);
            this.CustomAttributesSearchContainer.Controls.Add(this.ProprietyInput);
            this.CustomAttributesSearchContainer.Location = new System.Drawing.Point(6, 242);
            this.CustomAttributesSearchContainer.Name = "CustomAttributesSearchContainer";
            this.CustomAttributesSearchContainer.Size = new System.Drawing.Size(491, 172);
            this.CustomAttributesSearchContainer.TabIndex = 17;
            this.CustomAttributesSearchContainer.TabStop = false;
            this.CustomAttributesSearchContainer.Text = "Custom Attributes";
            // 
            // AddCustomSearchParametersButtons
            // 
            this.AddCustomSearchParametersButtons.Location = new System.Drawing.Point(109, 108);
            this.AddCustomSearchParametersButtons.Name = "AddCustomSearchParametersButtons";
            this.AddCustomSearchParametersButtons.Size = new System.Drawing.Size(245, 23);
            this.AddCustomSearchParametersButtons.TabIndex = 22;
            this.AddCustomSearchParametersButtons.Text = "Add Search Parameters";
            this.AddCustomSearchParametersButtons.UseVisualStyleBackColor = true;
            this.AddCustomSearchParametersButtons.Click += new System.EventHandler(this.AddCustomSearchParameter);
            // 
            // ProprietyValueLabel
            // 
            this.ProprietyValueLabel.AutoSize = true;
            this.ProprietyValueLabel.Location = new System.Drawing.Point(265, 38);
            this.ProprietyValueLabel.Name = "ProprietyValueLabel";
            this.ProprietyValueLabel.Size = new System.Drawing.Size(78, 13);
            this.ProprietyValueLabel.TabIndex = 21;
            this.ProprietyValueLabel.Text = "Propriety Value";
            // 
            // ProprietyValueInput
            // 
            this.ProprietyValueInput.Location = new System.Drawing.Point(266, 54);
            this.ProprietyValueInput.Name = "ProprietyValueInput";
            this.ProprietyValueInput.Size = new System.Drawing.Size(191, 20);
            this.ProprietyValueInput.TabIndex = 20;
            // 
            // ProprietyNameLabel
            // 
            this.ProprietyNameLabel.AutoSize = true;
            this.ProprietyNameLabel.Location = new System.Drawing.Point(6, 38);
            this.ProprietyNameLabel.Name = "ProprietyNameLabel";
            this.ProprietyNameLabel.Size = new System.Drawing.Size(79, 13);
            this.ProprietyNameLabel.TabIndex = 19;
            this.ProprietyNameLabel.Text = "Propriety Name";
            // 
            // ProprietyInput
            // 
            this.ProprietyInput.Location = new System.Drawing.Point(7, 54);
            this.ProprietyInput.Name = "ProprietyInput";
            this.ProprietyInput.Size = new System.Drawing.Size(191, 20);
            this.ProprietyInput.TabIndex = 18;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(684, 280);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(124, 23);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.performSearch);
            // 
            // StandardSearchContainer
            // 
            this.StandardSearchContainer.Controls.Add(this.ignoreDateCheckBox);
            this.StandardSearchContainer.Controls.Add(this.dateTimeInput);
            this.StandardSearchContainer.Controls.Add(this.AddStandardSearchParametersButton);
            this.StandardSearchContainer.Controls.Add(this.PlaceInput);
            this.StandardSearchContainer.Controls.Add(this.PlaceLabel);
            this.StandardSearchContainer.Controls.Add(this.PeopleInput);
            this.StandardSearchContainer.Controls.Add(this.PeopleLabel);
            this.StandardSearchContainer.Controls.Add(this.OcasionInput);
            this.StandardSearchContainer.Controls.Add(this.OcasionLabel);
            this.StandardSearchContainer.Controls.Add(this.DateCreatedLabel);
            this.StandardSearchContainer.Controls.Add(this.PhotoNameLabel);
            this.StandardSearchContainer.Controls.Add(this.PhotoNameInput);
            this.StandardSearchContainer.Location = new System.Drawing.Point(6, 19);
            this.StandardSearchContainer.Name = "StandardSearchContainer";
            this.StandardSearchContainer.Size = new System.Drawing.Size(491, 189);
            this.StandardSearchContainer.TabIndex = 16;
            this.StandardSearchContainer.TabStop = false;
            this.StandardSearchContainer.Text = "Standard";
            // 
            // ignoreDateCheckBox
            // 
            this.ignoreDateCheckBox.AutoSize = true;
            this.ignoreDateCheckBox.Location = new System.Drawing.Point(387, 13);
            this.ignoreDateCheckBox.Name = "ignoreDateCheckBox";
            this.ignoreDateCheckBox.Size = new System.Drawing.Size(82, 17);
            this.ignoreDateCheckBox.TabIndex = 16;
            this.ignoreDateCheckBox.Text = "Ignore Date";
            this.ignoreDateCheckBox.UseVisualStyleBackColor = true;
            this.ignoreDateCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // dateTimeInput
            // 
            this.dateTimeInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeInput.Location = new System.Drawing.Point(272, 30);
            this.dateTimeInput.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateTimeInput.Name = "dateTimeInput";
            this.dateTimeInput.Size = new System.Drawing.Size(185, 20);
            this.dateTimeInput.TabIndex = 15;
            this.dateTimeInput.Value = new System.DateTime(2020, 3, 19, 0, 0, 0, 0);
            // 
            // AddStandardSearchParametersButton
            // 
            this.AddStandardSearchParametersButton.Location = new System.Drawing.Point(272, 137);
            this.AddStandardSearchParametersButton.Name = "AddStandardSearchParametersButton";
            this.AddStandardSearchParametersButton.Size = new System.Drawing.Size(185, 23);
            this.AddStandardSearchParametersButton.TabIndex = 14;
            this.AddStandardSearchParametersButton.Text = "Add Search Parameters";
            this.AddStandardSearchParametersButton.UseVisualStyleBackColor = true;
            this.AddStandardSearchParametersButton.Click += new System.EventHandler(this.addNormalSearchParameters_Click);
            // 
            // PlaceInput
            // 
            this.PlaceInput.Location = new System.Drawing.Point(37, 140);
            this.PlaceInput.Name = "PlaceInput";
            this.PlaceInput.Size = new System.Drawing.Size(185, 20);
            this.PlaceInput.TabIndex = 12;
            // 
            // PlaceLabel
            // 
            this.PlaceLabel.AutoSize = true;
            this.PlaceLabel.Location = new System.Drawing.Point(34, 124);
            this.PlaceLabel.Name = "PlaceLabel";
            this.PlaceLabel.Size = new System.Drawing.Size(34, 13);
            this.PlaceLabel.TabIndex = 13;
            this.PlaceLabel.Text = "Place";
            // 
            // PeopleInput
            // 
            this.PeopleInput.Location = new System.Drawing.Point(272, 85);
            this.PeopleInput.Name = "PeopleInput";
            this.PeopleInput.Size = new System.Drawing.Size(185, 20);
            this.PeopleInput.TabIndex = 10;
            // 
            // PeopleLabel
            // 
            this.PeopleLabel.AutoSize = true;
            this.PeopleLabel.Location = new System.Drawing.Point(269, 69);
            this.PeopleLabel.Name = "PeopleLabel";
            this.PeopleLabel.Size = new System.Drawing.Size(131, 13);
            this.PeopleLabel.TabIndex = 11;
            this.PeopleLabel.Text = "People(Comma separated)";
            // 
            // OcasionInput
            // 
            this.OcasionInput.Location = new System.Drawing.Point(37, 85);
            this.OcasionInput.Name = "OcasionInput";
            this.OcasionInput.Size = new System.Drawing.Size(185, 20);
            this.OcasionInput.TabIndex = 8;
            // 
            // OcasionLabel
            // 
            this.OcasionLabel.AutoSize = true;
            this.OcasionLabel.Location = new System.Drawing.Point(34, 69);
            this.OcasionLabel.Name = "OcasionLabel";
            this.OcasionLabel.Size = new System.Drawing.Size(46, 13);
            this.OcasionLabel.TabIndex = 9;
            this.OcasionLabel.Text = "Ocasion";
            // 
            // DateCreatedLabel
            // 
            this.DateCreatedLabel.AutoSize = true;
            this.DateCreatedLabel.Location = new System.Drawing.Point(269, 16);
            this.DateCreatedLabel.Name = "DateCreatedLabel";
            this.DateCreatedLabel.Size = new System.Drawing.Size(70, 13);
            this.DateCreatedLabel.TabIndex = 7;
            this.DateCreatedLabel.Text = "Date Created";
            // 
            // PhotoNameLabel
            // 
            this.PhotoNameLabel.AutoSize = true;
            this.PhotoNameLabel.Location = new System.Drawing.Point(34, 17);
            this.PhotoNameLabel.Name = "PhotoNameLabel";
            this.PhotoNameLabel.Size = new System.Drawing.Size(66, 13);
            this.PhotoNameLabel.TabIndex = 5;
            this.PhotoNameLabel.Text = "Photo Name";
            // 
            // PhotoNameInput
            // 
            this.PhotoNameInput.Location = new System.Drawing.Point(37, 33);
            this.PhotoNameInput.Name = "PhotoNameInput";
            this.PhotoNameInput.Size = new System.Drawing.Size(185, 20);
            this.PhotoNameInput.TabIndex = 4;
            // 
            // UploadFileButton
            // 
            this.UploadFileButton.Location = new System.Drawing.Point(21, 84);
            this.UploadFileButton.Name = "UploadFileButton";
            this.UploadFileButton.Size = new System.Drawing.Size(191, 23);
            this.UploadFileButton.TabIndex = 4;
            this.UploadFileButton.Text = "Upload File";
            this.UploadFileButton.UseVisualStyleBackColor = true;
            this.UploadFileButton.Click += new System.EventHandler(this.fileUploader_HelpRequest);
            // 
            // UploadFolderButton
            // 
            this.UploadFolderButton.Location = new System.Drawing.Point(21, 37);
            this.UploadFolderButton.Name = "UploadFolderButton";
            this.UploadFolderButton.Size = new System.Drawing.Size(191, 23);
            this.UploadFolderButton.TabIndex = 3;
            this.UploadFolderButton.Text = "Upload Folder";
            this.UploadFolderButton.UseVisualStyleBackColor = true;
            this.UploadFolderButton.Click += new System.EventHandler(this.folderUploader_HelpRequest);
            // 
            // ControlsContainer
            // 
            this.ControlsContainer.Controls.Add(this.SearchContainer);
            this.ControlsContainer.Controls.Add(this.UploadFileButton);
            this.ControlsContainer.Controls.Add(this.UploadFolderButton);
            this.ControlsContainer.Location = new System.Drawing.Point(8, 26);
            this.ControlsContainer.Name = "ControlsContainer";
            this.ControlsContainer.Size = new System.Drawing.Size(834, 602);
            this.ControlsContainer.TabIndex = 6;
            this.ControlsContainer.TabStop = false;
            this.ControlsContainer.Text = "Controls";
            // 
            // filesTabControl
            // 
            this.filesTabControl.Controls.Add(this.photosTabPage);
            this.filesTabControl.Controls.Add(this.deletedPhotosTabPage);
            this.filesTabControl.Location = new System.Drawing.Point(851, 33);
            this.filesTabControl.Name = "filesTabControl";
            this.filesTabControl.SelectedIndex = 0;
            this.filesTabControl.Size = new System.Drawing.Size(601, 594);
            this.filesTabControl.TabIndex = 7;
            // 
            // photosTabPage
            // 
            this.photosTabPage.Controls.Add(this.DocumentsListView);
            this.photosTabPage.Location = new System.Drawing.Point(4, 22);
            this.photosTabPage.Name = "photosTabPage";
            this.photosTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.photosTabPage.Size = new System.Drawing.Size(593, 568);
            this.photosTabPage.TabIndex = 0;
            this.photosTabPage.Text = "Photos";
            this.photosTabPage.UseVisualStyleBackColor = true;
            // 
            // DocumentsListView
            // 
            this.DocumentsListView.HideSelection = false;
            this.DocumentsListView.Location = new System.Drawing.Point(0, 0);
            this.DocumentsListView.Name = "DocumentsListView";
            this.DocumentsListView.Size = new System.Drawing.Size(593, 568);
            this.DocumentsListView.TabIndex = 1;
            this.DocumentsListView.UseCompatibleStateImageBehavior = false;
            this.DocumentsListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ContextMenuAlive);
            this.DocumentsListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FileViewer);
            // 
            // deletedPhotosTabPage
            // 
            this.deletedPhotosTabPage.Controls.Add(this.deletedListView);
            this.deletedPhotosTabPage.Location = new System.Drawing.Point(4, 22);
            this.deletedPhotosTabPage.Name = "deletedPhotosTabPage";
            this.deletedPhotosTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.deletedPhotosTabPage.Size = new System.Drawing.Size(593, 568);
            this.deletedPhotosTabPage.TabIndex = 1;
            this.deletedPhotosTabPage.Text = "Deleted Photos";
            this.deletedPhotosTabPage.UseVisualStyleBackColor = true;
            // 
            // deletedListView
            // 
            this.deletedListView.HideSelection = false;
            this.deletedListView.Location = new System.Drawing.Point(0, 0);
            this.deletedListView.Name = "deletedListView";
            this.deletedListView.Size = new System.Drawing.Size(593, 568);
            this.deletedListView.TabIndex = 2;
            this.deletedListView.UseCompatibleStateImageBehavior = false;
            this.deletedListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ContextMenuDeleted);
            this.deletedListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FileViewer);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 662);
            this.Controls.Add(this.filesTabControl);
            this.Controls.Add(this.ControlsContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Image Manager";
            this.SearchContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currentParametesGrid)).EndInit();
            this.CustomAttributesSearchContainer.ResumeLayout(false);
            this.CustomAttributesSearchContainer.PerformLayout();
            this.StandardSearchContainer.ResumeLayout(false);
            this.StandardSearchContainer.PerformLayout();
            this.ControlsContainer.ResumeLayout(false);
            this.filesTabControl.ResumeLayout(false);
            this.photosTabPage.ResumeLayout(false);
            this.deletedPhotosTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox SearchContainer;
        private System.Windows.Forms.GroupBox CustomAttributesSearchContainer;
        private System.Windows.Forms.Button AddCustomSearchParametersButtons;
        private System.Windows.Forms.Label ProprietyValueLabel;
        private System.Windows.Forms.TextBox ProprietyValueInput;
        private System.Windows.Forms.Label ProprietyNameLabel;
        private System.Windows.Forms.TextBox ProprietyInput;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.GroupBox StandardSearchContainer;
        private System.Windows.Forms.Button AddStandardSearchParametersButton;
        private System.Windows.Forms.TextBox PlaceInput;
        private System.Windows.Forms.Label PlaceLabel;
        private System.Windows.Forms.TextBox PeopleInput;
        private System.Windows.Forms.Label PeopleLabel;
        private System.Windows.Forms.TextBox OcasionInput;
        private System.Windows.Forms.Label OcasionLabel;
        private System.Windows.Forms.Label DateCreatedLabel;
        private System.Windows.Forms.Label PhotoNameLabel;
        private System.Windows.Forms.TextBox PhotoNameInput;
        private System.Windows.Forms.Button UploadFileButton;
        private System.Windows.Forms.Button UploadFolderButton;
        private System.Windows.Forms.GroupBox ControlsContainer;
        private System.Windows.Forms.DateTimePicker dateTimeInput;
        private System.Windows.Forms.DataGridView currentParametesGrid;
        private System.Windows.Forms.Button clearSearchParametersButton;
        private System.Windows.Forms.TabControl filesTabControl;
        private System.Windows.Forms.TabPage photosTabPage;
        private System.Windows.Forms.ListView DocumentsListView;
        private System.Windows.Forms.TabPage deletedPhotosTabPage;
        private System.Windows.Forms.ListView deletedListView;
        private System.Windows.Forms.CheckBox ignoreDateCheckBox;
    }
}

