namespace LR_14_Form_List_Phonebook
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddContact = new System.Windows.Forms.Button();
            this.DeleteContact = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AddContact
            // 
            this.AddContact.Location = new System.Drawing.Point(565, 34);
            this.AddContact.Name = "AddContact";
            this.AddContact.Size = new System.Drawing.Size(174, 33);
            this.AddContact.TabIndex = 1;
            this.AddContact.Text = "Додати контакт";
            this.AddContact.UseVisualStyleBackColor = true;
            this.AddContact.Click += new System.EventHandler(this.AddContactButton_Click);
            // 
            // DeleteContact
            // 
            this.DeleteContact.Location = new System.Drawing.Point(565, 97);
            this.DeleteContact.Name = "DeleteContact";
            this.DeleteContact.Size = new System.Drawing.Size(174, 33);
            this.DeleteContact.TabIndex = 2;
            this.DeleteContact.Text = "Видалити контакт";
            this.DeleteContact.UseVisualStyleBackColor = true;
            this.DeleteContact.Click += new System.EventHandler(this.RemoveContactButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(12, 355);
            this.SearchTextBox.Multiline = true;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(490, 31);
            this.SearchTextBox.TabIndex = 5;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Пошук за Іменем або Прізвищем";
            // 
            // ShowListBox
            // 
            this.ShowListBox.FormattingEnabled = true;
            this.ShowListBox.Location = new System.Drawing.Point(16, 12);
            this.ShowListBox.Name = "ShowListBox";
            this.ShowListBox.Size = new System.Drawing.Size(486, 290);
            this.ShowListBox.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 402);
            this.Controls.Add(this.ShowListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.DeleteContact);
            this.Controls.Add(this.AddContact);
            this.Name = "Main";
            this.RightToLeftLayout = true;
            this.Text = "MainPhoneBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddContact;
        private System.Windows.Forms.Button DeleteContact;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ShowListBox;
    }
}

