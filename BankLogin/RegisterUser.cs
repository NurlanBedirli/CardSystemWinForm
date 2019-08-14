using BankLogin.DataBasaQuery;
using BankLogin.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankLogin
{
    public partial class RegisterUser : Form
    {
        BankDataContext context = new BankDataContext();
        DBQuery dBQuery = new DBQuery();
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Person> people = new List<Person>();
             context.People.Add(new Person
            {
                Name = txbx_name.Text,
                Surname = txbx_surname.Text,
                Email = txbx_email.Text,
                Password = txbx_password.Text
            });
            context.SaveChanges();
         var data =  dBQuery.ByEmailUser(txbx_email.Text);
            SessionDb.Session.People = data;
            context.RegisterPhones.Add(new RegisterPhoneNumber
            {
                NumberPhone = txbx_number.Text,
                PersonId = data.Select(x => x.Id).FirstOrDefault()
            });
            context.SaveChanges();
            MessageBox.Show("Tebrikler Qeydiyyatdan kecdiniz");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }
    }
}
