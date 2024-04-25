namespace LR_14_Form_List_Phonebook
{
    partial class AddContact
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddContactToList = new System.Windows.Forms.Button();
            this.TextSurname = new System.Windows.Forms.TextBox();
            this.TextName = new System.Windows.Forms.TextBox();
            this.TextPhoneNumber = new System.Windows.Forms.TextBox();
            this.TextEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть Прізвище";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введіть Ім\'я";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введіть номер телефона";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Введіть Email";
            // 
            // AddContactToList
            // 
            this.AddContactToList.Location = new System.Drawing.Point(143, 216);
            this.AddContactToList.Name = "AddContactToList";
            this.AddContactToList.Size = new System.Drawing.Size(171, 23);
            this.AddContactToList.TabIndex = 4;
            this.AddContactToList.Text = "Додати контакт";
            this.AddContactToList.UseVisualStyleBackColor = true;
            this.AddContactToList.Click += new System.EventHandler(this.AddContactToList_Click);
            // 
            // TextSurname
            // 
            this.TextSurname.Location = new System.Drawing.Point(143, 26);
            this.TextSurname.MaxLength = 30;
            this.TextSurname.Name = "TextSurname";
            this.TextSurname.Size = new System.Drawing.Size(171, 20);
            this.TextSurname.TabIndex = 5;
            this.TextSurname.TextChanged += new System.EventHandler(this.TextSurname_TextChanged);
            this.TextSurname.Validated += new System.EventHandler(this.TextSurname_TextChanged);
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(143, 74);
            this.TextName.MaxLength = 30;
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(171, 20);
            this.TextName.TabIndex = 6;
            this.TextName.TextChanged += new System.EventHandler(this.TextName_TextChanged);
            this.TextName.Validated += new System.EventHandler(this.TextName_TextChanged);
            // 
            // TextPhoneNumber
            // 
            this.TextPhoneNumber.Location = new System.Drawing.Point(143, 120);
            this.TextPhoneNumber.MaxLength = 10;
            this.TextPhoneNumber.Name = "TextPhoneNumber";
            this.TextPhoneNumber.Size = new System.Drawing.Size(171, 20);
            this.TextPhoneNumber.TabIndex = 7;
            this.TextPhoneNumber.TextChanged += new System.EventHandler(this.TextPhoneNumber_TextChanged);
            this.TextPhoneNumber.Validated += new System.EventHandler(this.TextPhoneNumber_TextChanged);
            // 
            // TextEmail
            // 
            this.TextEmail.Location = new System.Drawing.Point(143, 165);
            this.TextEmail.MaxLength = 40;
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.Size = new System.Drawing.Size(171, 20);
            this.TextEmail.TabIndex = 8;
            this.TextEmail.TextChanged += new System.EventHandler(this.TextEmail_TextChanged);
            this.TextEmail.Validated += new System.EventHandler(this.TextEmail_TextChanged);
            // 
            // AddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 263);
            this.Controls.Add(this.TextEmail);
            this.Controls.Add(this.TextPhoneNumber);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.TextSurname);
            this.Controls.Add(this.AddContactToList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddContact";
            this.Text = "AddContact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddContactToList;
        private System.Windows.Forms.TextBox TextSurname;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.TextBox TextPhoneNumber;
        private System.Windows.Forms.TextBox TextEmail;
    }
}