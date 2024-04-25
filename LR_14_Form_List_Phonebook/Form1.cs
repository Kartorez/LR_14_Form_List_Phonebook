using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ActivationContext;

namespace LR_14_Form_List_Phonebook
{
    public partial class Main : Form
    {
        private List<Contact> contacts = new List<Contact>();
        public Main()
        {
            InitializeComponent();
        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            AddContact contactForm = new AddContact();
            if (contactForm.ShowDialog() == DialogResult.OK)
            {
                contacts.Add(contactForm.Contact);
                UpdateContactsListBox();
            }
        }

        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            Contact selectedContact = (Contact)ShowListBox.SelectedItem;
            if (selectedContact != null)
            {
                contacts.Remove(selectedContact);
                UpdateContactsListBox();
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string SearchTerm = SearchTextBox.Text.ToLower();
            List<Contact> filteredContacts = contacts.Where(contact =>
                contact.Name.ToLower().Contains(SearchTerm) ||
                contact.Surname.ToLower().Contains(SearchTerm)).ToList();

            UpdateContactsListBox(filteredContacts);
        }

        private void UpdateContactsListBox(List<Contact> filteredContacts = null)
        {
            ShowListBox.Items.Clear();
            List<Contact> contactsToShow = filteredContacts ?? contacts;
            foreach (var contact in contactsToShow)
            {
                ShowListBox.Items.Add(contact);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateContactsListBox();
        }

        private void SearchTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }


}



