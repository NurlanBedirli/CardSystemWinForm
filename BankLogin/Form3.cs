using BankLogin.BalancCalculate;
using BankLogin.DBExtensions;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (BankDataContext context = new BankDataContext())
            {
                if(txbx_abunecode.Text == "")
                {
                    MessageBox.Show("Abune Codu Bosdur");
                }
                else
                {
                    var result = Existansions.PhoneByAbuneCode(context, Convert.ToInt32(txbx_abunecode.Text));
                    if (result)
                    {
                        CalcBalans calc = new CalcBalans();
                         if(txbx_prize.Text == "")
                        {
                            MessageBox.Show("Zehmet Olmasa Odenilecek Meblegi Yazin");
                        }
                         else
                        {
                            try
                            {
                                calc.Calc(Convert.ToDecimal(txbx_prize.Text));
                                MessageBox.Show("Mebleginiz Ugurla Kocuruldu");
                                txbx_abunecode.Text = "";
                                txbx_prize.Text = "";
                            }
                            catch(Exception ex)
                            {
                                ex.Source = "Zehmet Olmasa Balansi Reqem Ile qeyd edin(Herif ve Elave Simvollari (!@#$%^*()_) Legv Edin";
                                MessageBox.Show(ex.Source);
                                txbx_prize.Text = "";
                                return;
                            }
                           
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bele Bir Abune Codu Movcud Deyil");
                    }
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
