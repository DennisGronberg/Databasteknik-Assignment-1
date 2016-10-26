using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace DB_Assignment1
{
    public partial class Database : Form
    {
        #region Constructor

        List<Contacts> contactsData = new List<Contacts>();
        SpeechSynthesizer synth = new SpeechSynthesizer();

        public Database()
        {
            InitializeComponent();
            ContactsList();

            var days = Enumerable.Range(1, 31).Select(n => n.ToString()).ToList();
            days.Add("Day");
            var months = new List<string> { "Month", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            var years = Enumerable.Range((DateTime.Now.Year - 100), 101).OrderByDescending(x => x).Select(x => x.ToString()).ToList();
            years.Add("Year");
            cboYear.DataSource = years;
            cboYear.SelectedItem = "Year";
            cboMonth.DataSource = months;
            cboMonth.SelectedItem = "Month";
            cboDay.DataSource = days;
            cboDay.SelectedItem = "Day";

            synth.Volume = 100;  // 0...100
            synth.Rate = 1;    // -10...10
        }

        #endregion

        #region Events

        private void cmdAddContact_Click(object sender, EventArgs e)
        {
            AddContact();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void cmdRemoveContact_Click(object sender, EventArgs e)
        {
            RemoveContact();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            SaveContactList();
        }

        #endregion

        #region Methods

        public void ContactsList()
        {
            contactsData.Clear();
            using (var db = new ContactsContext())
            {
                var contact = db.Contacts.OrderBy(x => x.Name);
                foreach (var item in contact) { contactsData.Add(item); }
            }
            dgContacts.DataSource = null;
            dgContacts.DataSource = contactsData;
            dgContacts.Columns["ContactsId"].Visible = false;
        }

        public void ClearTextBoxes()
        {
            txtAdress.Text = "";
            txtCity.Text = "";
            txtEmail.Text = "";
            txtName.Text = "";
            txtPhonenumber.Text = "";
            txtZipcode.Text = "";
            cboDay.Text = "Day";
            cboMonth.Text = "Month";
            cboYear.Text = "Year";
        }

        public void RemoveContact()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove\nselected contact?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    int rowId = 0;
                    foreach (DataGridViewRow row in dgContacts.SelectedRows)
                    {
                        rowId = Convert.ToInt32(row.Cells[0].Value);
                    }
                    using (var db = new ContactsContext())
                    {
                        var delete = db.Contacts.Where(x => x.ContactsId == rowId).First();
                        db.Contacts.Remove(delete);
                        db.SaveChanges();
                    }
                    ContactsList();
                    synth.Speak("Contact deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void AddContact()
        {
            try
            {
                if (txtAdress.Text == "" || txtCity.Text == "" || txtEmail.Text == "" || txtName.Text == "" || txtPhonenumber.Text == "" || txtZipcode.Text == "" || cboYear.Text == "Year" || cboMonth.Text == "Month" || cboDay.Text == "Day")
                {
                    MessageBox.Show("Please fill in all fields,\nin order to add a new contact.");
                }
                else
                {
                    using (var Context = new ContactsContext())
                    {
                        string month = "";
                        string day = "";
                        if ((cboMonth.SelectedIndex + 1) < 10) { month = "0" + (cboMonth.SelectedIndex + 1).ToString(); }
                        else { month = (cboMonth.SelectedIndex + 1).ToString(); }
                        if ((cboDay.SelectedIndex + 1) < 10) { day = "0" + (cboDay.SelectedIndex + 1).ToString(); }
                        else { day = cboDay.Text; }
                        Contacts newContact = new Contacts
                        {
                            Name = txtName.Text,
                            Adress = txtAdress.Text,
                            City = txtCity.Text,
                            Zipcode = txtZipcode.Text,
                            Email = txtEmail.Text,
                            Phonenumber = txtPhonenumber.Text,
                            Birthday = cboYear.Text + "-" + month + "-" + day
                        };
                        Context.Contacts.Add(newContact);
                        Context.SaveChanges();
                        ClearTextBoxes();
                    }
                    ContactsList();
                    synth.Speak("Contact added");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SaveContactList()
        {
            // Spara kod
        }

        #endregion
    }
}
