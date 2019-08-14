using BankLogin.DataBasaQuery;
using BankLogin.DBExtensions;
using BankLogin.Model;
using BankLogin.SessionDb;
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
    public partial class Form1 : Form
    {
        DBQuery query = new DBQuery();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (BankDataContext context = new BankDataContext())
            {
              int numberId = Existansions.PhoneByNumber(context, txbx_number.Text);
                if(numberId != 0)
                {
                    Session.model = query.GettAllCardById(numberId);
                    if(Session.model.Count == 0)
                    {
                        var data = context.People.Where(x => x.Id == numberId).ToList();
                        SessionDb.Session.People = data;
                    }
                    Form4 form = new Form4();
                    this.Hide();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Bele bir Nomrenin Card Sahibi Yoxdur");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterUser registerUser = new RegisterUser();
            this.Hide();
            registerUser.ShowDialog();
        }
    }
}
