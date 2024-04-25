using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_14_Form_List_Phonebook
{
    public partial class AddContact : Form
    {
        public Contact Contact { get; private set; }

        public AddContact()
        {
            InitializeComponent();
        }

        private void TextSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextEmail_TextChanged(object sender, EventArgs e)
        {

        }
       

        private void AddContactToList_Click(object sender, EventArgs e)
        {
            
                Contact = new Contact
                {
                    Name = TextName.Text,
                    Surname = TextSurname.Text,
                    Email = TextEmail.Text,
                    Phone = TextPhoneNumber.Text
                };
                DialogResult = DialogResult.OK;
                Close();
            }
    }
}
