using BankLogin.BalancCalculate;
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
    public partial class AddBalance : Form
    {
        public AddBalance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txbx_balance.Text == "")
            {
                MessageBox.Show("Artirilacaq Balansi Qeyd Edin");
            }
            else
            {
                var card = SessionDb.Session.model1;
                if (card.Count == 0)
                {
                    MessageBox.Show("Sizin Hec bir Kartiniz yoxdu");
                }
                else
                {
                    CalcBalans balans = new CalcBalans();
                    try
                    {
                        balans.BlanceCount(Convert.ToDecimal(txbx_balance.Text));
                    }
                    catch(Exception ex)
                    {
                        ex.Source = "Zehmet Olmasa Balansi Reqem Ile qeyd edin(Herif ve Elave Simvollari (!@#$%^) Legv Edin";
                        MessageBox.Show(ex.Source);
                        txbx_balance.Text = "";
                        return;
                    }
                    MessageBox.Show("Emeliyyat Ugurlu Oldu");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
        }
    }
}
