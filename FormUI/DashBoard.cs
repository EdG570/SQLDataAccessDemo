using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormUI
{
    public partial class DashBoard : Form
    {
        List<Person> people = new List<Person>();
        private readonly DataAccess _db;

        public DashBoard()
        {
            InitializeComponent();
            UpdateBinding(); 
            _db = new DataAccess();         
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            people = _db.GetPeople(LastNameText.Text);
            UpdateBinding();
        }

        private void PersonInsertButton_Click(object sender, EventArgs e)
        {
            Person newPerson = new Person
            {
                FirstName = firstNameInsertTextBox.Text,
                LastName = lastNameInsertTextBox.Text,
                EmailAddress = emailInsertTextBox.Text,
                PhoneNumber = phoneNumInsertTextBox.Text
            };

            var addedPerson = _db.InsertPerson(newPerson);

            if (addedPerson)
            {
                MessageBox.Show($"Successfully saved {newPerson.FirstName} {newPerson.LastName} to the database.");
                ClearInsertTextBoxes();
            }
            else
                MessageBox.Show("Unable to save new person to the database. Please try again. If the problem" +
                                "persists contact the application administrator.");

            UpdateBinding();
        }

        private void ClearInsertTextBoxes()
        {
            firstNameInsertTextBox.Clear();
            lastNameInsertTextBox.Clear();
            emailInsertTextBox.Clear();
            phoneNumInsertTextBox.Clear();
        }

        private void UpdateBinding()
        {
            PeopleListBox.DataSource = people;
            PeopleListBox.DisplayMember = "AllInfo";
        }

        
    }
}
