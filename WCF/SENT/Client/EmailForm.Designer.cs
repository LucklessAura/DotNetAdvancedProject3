namespace ProjectGUI
{
    partial class EmailForm
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
            this.components = new System.ComponentModel.Container();
            this.ReceverEmailInput = new System.Windows.Forms.TextBox();
            this.EmailBody = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ReceverNameInput = new System.Windows.Forms.TextBox();
            this.SubjectInput = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReceverEmailInput
            // 
            this.ReceverEmailInput.Location = new System.Drawing.Point(12, 54);
            this.ReceverEmailInput.Name = "ReceverEmailInput";
            this.ReceverEmailInput.Size = new System.Drawing.Size(164, 20);
            this.ReceverEmailInput.TabIndex = 0;
            // 
            // EmailBody
            // 
            this.EmailBody.Location = new System.Drawing.Point(51, 114);
            this.EmailBody.Multiline = true;
            this.EmailBody.Name = "EmailBody";
            this.EmailBody.Size = new System.Drawing.Size(701, 246);
            this.EmailBody.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ReceverNameInput
            // 
            this.ReceverNameInput.Location = new System.Drawing.Point(309, 54);
            this.ReceverNameInput.Name = "ReceverNameInput";
            this.ReceverNameInput.Size = new System.Drawing.Size(164, 20);
            this.ReceverNameInput.TabIndex = 3;
            // 
            // SubjectInput
            // 
            this.SubjectInput.Location = new System.Drawing.Point(610, 54);
            this.SubjectInput.Name = "SubjectInput";
            this.SubjectInput.Size = new System.Drawing.Size(164, 20);
            this.SubjectInput.TabIndex = 4;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(328, 395);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(145, 30);
            this.SendButton.TabIndex = 5;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.sendEmail);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Recever Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email Subject";
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 464);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.SubjectInput);
            this.Controls.Add(this.ReceverNameInput);
            this.Controls.Add(this.EmailBody);
            this.Controls.Add(this.ReceverEmailInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Email";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ReceverEmailInput;
        private System.Windows.Forms.TextBox EmailBody;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox ReceverNameInput;
        private System.Windows.Forms.TextBox SubjectInput;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}