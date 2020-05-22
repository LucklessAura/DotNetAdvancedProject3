namespace ProjectGUI
{
    partial class addFileForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddPhotoButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.clearSearchParametersButton = new System.Windows.Forms.Button();
            this.currentParametesGrid = new System.Windows.Forms.DataGridView();
            this.CustomAttributesSearchContainer = new System.Windows.Forms.GroupBox();
            this.AddCustomParametersButton = new System.Windows.Forms.Button();
            this.ProprietyValueLabel = new System.Windows.Forms.Label();
            this.ProprietyValueInput = new System.Windows.Forms.TextBox();
            this.ProprietyNameLabel = new System.Windows.Forms.Label();
            this.ProprietyInput = new System.Windows.Forms.TextBox();
            this.StandardSearchContainer = new System.Windows.Forms.GroupBox();
            this.dateTimeInput = new System.Windows.Forms.DateTimePicker();
            this.AddSearchParametersButton = new System.Windows.Forms.Button();
            this.PlaceInput = new System.Windows.Forms.TextBox();
            this.PlaceLabel = new System.Windows.Forms.Label();
            this.PeopleInput = new System.Windows.Forms.TextBox();
            this.PeopleLabel = new System.Windows.Forms.Label();
            this.OcasionInput = new System.Windows.Forms.TextBox();
            this.OcasionLabel = new System.Windows.Forms.Label();
            this.DateCreatedLabel = new System.Windows.Forms.Label();
            this.PhotoNameLabel = new System.Windows.Forms.Label();
            this.PhotoNameInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentParametesGrid)).BeginInit();
            this.CustomAttributesSearchContainer.SuspendLayout();
            this.StandardSearchContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddPhotoButton
            // 
            this.AddPhotoButton.Location = new System.Drawing.Point(968, 468);
            this.AddPhotoButton.Name = "AddPhotoButton";
            this.AddPhotoButton.Size = new System.Drawing.Size(185, 23);
            this.AddPhotoButton.TabIndex = 25;
            this.AddPhotoButton.Text = "Add Photo";
            this.AddPhotoButton.UseVisualStyleBackColor = true;
            this.AddPhotoButton.Click += new System.EventHandler(this.fileUpload);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(831, 28);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(421, 340);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 26;
            this.pictureBox.TabStop = false;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // clearSearchParametersButton
            // 
            this.clearSearchParametersButton.Location = new System.Drawing.Point(604, 304);
            this.clearSearchParametersButton.Name = "clearSearchParametersButton";
            this.clearSearchParametersButton.Size = new System.Drawing.Size(131, 21);
            this.clearSearchParametersButton.TabIndex = 31;
            this.clearSearchParametersButton.Text = "Clear Parameters";
            this.clearSearchParametersButton.UseVisualStyleBackColor = true;
            this.clearSearchParametersButton.Click += new System.EventHandler(this.clearSearchParameters);
            // 
            // currentParametesGrid
            // 
            this.currentParametesGrid.AllowUserToAddRows = false;
            this.currentParametesGrid.AllowUserToDeleteRows = false;
            this.currentParametesGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "*ANY*";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.currentParametesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.currentParametesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "*ANY*";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.currentParametesGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.currentParametesGrid.Location = new System.Drawing.Point(529, 28);
            this.currentParametesGrid.MultiSelect = false;
            this.currentParametesGrid.Name = "currentParametesGrid";
            this.currentParametesGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.currentParametesGrid.Size = new System.Drawing.Size(273, 239);
            this.currentParametesGrid.TabIndex = 30;
            // 
            // CustomAttributesSearchContainer
            // 
            this.CustomAttributesSearchContainer.Controls.Add(this.AddCustomParametersButton);
            this.CustomAttributesSearchContainer.Controls.Add(this.ProprietyValueLabel);
            this.CustomAttributesSearchContainer.Controls.Add(this.ProprietyValueInput);
            this.CustomAttributesSearchContainer.Controls.Add(this.ProprietyNameLabel);
            this.CustomAttributesSearchContainer.Controls.Add(this.ProprietyInput);
            this.CustomAttributesSearchContainer.Location = new System.Drawing.Point(12, 251);
            this.CustomAttributesSearchContainer.Name = "CustomAttributesSearchContainer";
            this.CustomAttributesSearchContainer.Size = new System.Drawing.Size(491, 172);
            this.CustomAttributesSearchContainer.TabIndex = 29;
            this.CustomAttributesSearchContainer.TabStop = false;
            this.CustomAttributesSearchContainer.Text = "Custom Attributes";
            // 
            // AddCustomParametersButton
            // 
            this.AddCustomParametersButton.Location = new System.Drawing.Point(109, 108);
            this.AddCustomParametersButton.Name = "AddCustomParametersButton";
            this.AddCustomParametersButton.Size = new System.Drawing.Size(245, 23);
            this.AddCustomParametersButton.TabIndex = 22;
            this.AddCustomParametersButton.Text = "Add Custom Parameters";
            this.AddCustomParametersButton.UseVisualStyleBackColor = true;
            this.AddCustomParametersButton.Click += new System.EventHandler(this.addCustomSearchParameter);
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
            // StandardSearchContainer
            // 
            this.StandardSearchContainer.Controls.Add(this.dateTimeInput);
            this.StandardSearchContainer.Controls.Add(this.AddSearchParametersButton);
            this.StandardSearchContainer.Controls.Add(this.PlaceInput);
            this.StandardSearchContainer.Controls.Add(this.PlaceLabel);
            this.StandardSearchContainer.Controls.Add(this.PeopleInput);
            this.StandardSearchContainer.Controls.Add(this.PeopleLabel);
            this.StandardSearchContainer.Controls.Add(this.OcasionInput);
            this.StandardSearchContainer.Controls.Add(this.OcasionLabel);
            this.StandardSearchContainer.Controls.Add(this.DateCreatedLabel);
            this.StandardSearchContainer.Controls.Add(this.PhotoNameLabel);
            this.StandardSearchContainer.Controls.Add(this.PhotoNameInput);
            this.StandardSearchContainer.Location = new System.Drawing.Point(12, 28);
            this.StandardSearchContainer.Name = "StandardSearchContainer";
            this.StandardSearchContainer.Size = new System.Drawing.Size(491, 189);
            this.StandardSearchContainer.TabIndex = 28;
            this.StandardSearchContainer.TabStop = false;
            this.StandardSearchContainer.Text = "Standard";
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
            // AddSearchParametersButton
            // 
            this.AddSearchParametersButton.Location = new System.Drawing.Point(272, 140);
            this.AddSearchParametersButton.Name = "AddSearchParametersButton";
            this.AddSearchParametersButton.Size = new System.Drawing.Size(185, 23);
            this.AddSearchParametersButton.TabIndex = 14;
            this.AddSearchParametersButton.Text = "Add Parameters";
            this.AddSearchParametersButton.UseVisualStyleBackColor = true;
            this.AddSearchParametersButton.Click += new System.EventHandler(this.addNormalSearchParameters_Click);
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
            this.DateCreatedLabel.Location = new System.Drawing.Point(269, 14);
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
            // addFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 534);
            this.Controls.Add(this.clearSearchParametersButton);
            this.Controls.Add(this.currentParametesGrid);
            this.Controls.Add(this.CustomAttributesSearchContainer);
            this.Controls.Add(this.StandardSearchContainer);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.AddPhotoButton);
            this.Name = "addFileForm";
            this.Text = "Add File";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentParametesGrid)).EndInit();
            this.CustomAttributesSearchContainer.ResumeLayout(false);
            this.CustomAttributesSearchContainer.PerformLayout();
            this.StandardSearchContainer.ResumeLayout(false);
            this.StandardSearchContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddPhotoButton;
        public System.Windows.Forms.PictureBox pictureBox;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button clearSearchParametersButton;
        private System.Windows.Forms.GroupBox CustomAttributesSearchContainer;
        private System.Windows.Forms.Button AddCustomParametersButton;
        private System.Windows.Forms.Label ProprietyValueLabel;
        private System.Windows.Forms.TextBox ProprietyValueInput;
        private System.Windows.Forms.Label ProprietyNameLabel;
        private System.Windows.Forms.TextBox ProprietyInput;
        private System.Windows.Forms.GroupBox StandardSearchContainer;
        private System.Windows.Forms.DateTimePicker dateTimeInput;
        private System.Windows.Forms.Button AddSearchParametersButton;
        private System.Windows.Forms.TextBox PlaceInput;
        private System.Windows.Forms.Label PlaceLabel;
        private System.Windows.Forms.TextBox PeopleInput;
        private System.Windows.Forms.Label PeopleLabel;
        private System.Windows.Forms.TextBox OcasionInput;
        private System.Windows.Forms.Label OcasionLabel;
        private System.Windows.Forms.Label DateCreatedLabel;
        private System.Windows.Forms.Label PhotoNameLabel;
        private System.Windows.Forms.TextBox PhotoNameInput;
        public System.Windows.Forms.DataGridView currentParametesGrid;
    }
}