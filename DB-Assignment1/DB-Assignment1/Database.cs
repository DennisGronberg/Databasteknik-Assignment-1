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
            days.Insert(0, "Day");
            var months = new List<string> { "Month", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            var years = Enumerable.Range((DateTime.Now.Year - 100), 101).OrderByDescending(x => x).Select(x => x.ToString()).ToList();
            years.Insert(0, "Year");
            cboYear.DataSource = years;
            cboMonth.DataSource = months;
            cboDay.DataSource = days;

            synth.Volume = 100;  // 0...100
            synth.Rate = 1;    // -10...10
        }

        #endregion

        #region Events

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            CancelChanges();
        }

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

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            cmdAddContact.Visible = false;
            cmdClear.Visible = false;
            cmdUpdate.Visible = false;
            cmdRemoveContact.Visible = false;
            cmdSaveChanges.Visible = true;
            cmdCancel.Visible = true;

            txtName.Text = dgContacts.SelectedRows[0].Cells[1].Value.ToString();
            txtAdress.Text = dgContacts.SelectedRows[0].Cells[2].Value.ToString();
            txtZipcode.Text = dgContacts.SelectedRows[0].Cells[3].Value.ToString();
            txtCity.Text = dgContacts.SelectedRows[0].Cells[4].Value.ToString();
            txtPhonenumber.Text = dgContacts.SelectedRows[0].Cells[5].Value.ToString();
            txtEmail.Text = dgContacts.SelectedRows[0].Cells[6].Value.ToString();
            string[] birthday = dgContacts.SelectedRows[0].Cells[7].Value.ToString().Split('-');
            cboYear.Text = birthday[0];
            cboMonth.SelectedIndex = int.Parse(birthday[1]);
            cboDay.Text = int.Parse(birthday[2]).ToString();
        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            Search();
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

                    using (var db = new ContactsContext())
                    {
                        foreach (DataGridViewRow row in dgContacts.SelectedRows)
                        {
                            rowId = Convert.ToInt32(row.Cells[0].Value);
                            var delete = db.Contacts.Where(x => x.ContactsId == rowId).First();
                            db.Contacts.Remove(delete);
                        }
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

        public void SaveChanges()
        {
            try
            {
                if (txtAdress.Text == "" || txtCity.Text == "" || txtEmail.Text == "" || txtName.Text == "" || txtPhonenumber.Text == "" || txtZipcode.Text == "" || cboYear.Text == "Year" || cboMonth.Text == "Month" || cboDay.Text == "Day")
                {
                    MessageBox.Show("Please fill in all fields,\nin order to edit contact.");
                }
                else
                {
                    string month = "";
                    string day = "";
                    if ((cboMonth.SelectedIndex + 1) < 10) { month = "0" + (cboMonth.SelectedIndex + 1).ToString(); }
                    else { month = (cboMonth.SelectedIndex + 1).ToString(); }
                    if ((cboDay.SelectedIndex + 1) < 10) { day = "0" + (cboDay.SelectedIndex + 1).ToString(); }
                    else { day = cboDay.Text; }
                    Contacts newContact = new Contacts
                    {
                        ContactsId = Convert.ToInt32(dgContacts.SelectedRows[0].Cells[0].Value),
                        Name = txtName.Text,
                        Adress = txtAdress.Text,
                        City = txtCity.Text,
                        Zipcode = txtZipcode.Text,
                        Email = txtEmail.Text,
                        Phonenumber = txtPhonenumber.Text,
                        Birthday = cboYear.Text + "-" + month + "-" + day
                    };
                    using (var Context = new ContactsContext())
                    {
                        Context.Entry(newContact).State = System.Data.Entity.EntityState.Modified;
                        Context.SaveChanges();
                    }
                    CancelChanges();
                    ContactsList();
                    synth.Speak("Contact updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CancelChanges()
        {
            cmdAddContact.Visible = true;
            cmdClear.Visible = true;
            cmdUpdate.Visible = true;
            cmdRemoveContact.Visible = true;
            cmdSaveChanges.Visible = false;
            cmdCancel.Visible = false;
            ClearTextBoxes();
        }

        private void cmdSaveChanges_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        public void Search()
        {
            string searchText = txtSearchBar.Text.Trim().ToLower();
            contactsData.Clear();
            using (var db = new ContactsContext())
            {
                var contact = db.Contacts.Where(x => x.Name.ToLower().Contains(searchText)
                                                  || x.Adress.ToLower().Contains(searchText)
                                                  || x.Zipcode.ToLower().Contains(searchText)
                                                  || x.City.ToLower().Contains(searchText)
                                                  || x.Phonenumber.ToLower().Contains(searchText)
                                                  || x.Email.ToLower().Contains(searchText)
                                                  || x.Birthday.ToLower().Contains(searchText)
                                                  ).OrderBy(x => x.Name);
                foreach (var item in contact) { contactsData.Add(item); }
            }
            dgContacts.DataSource = null;
            dgContacts.DataSource = contactsData;
            dgContacts.Columns["ContactsId"].Visible = false;
        }

        #endregion

        //alldelles för laggit
        //-------------------------
        //private void txtSearchBar_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    synth.Speak(e.KeyChar.ToString());
        //}
    }
}
