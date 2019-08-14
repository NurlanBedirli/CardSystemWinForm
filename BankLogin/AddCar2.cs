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
    public partial class AddCar2 : Form
    {
        DBQuery dbQuery = new DBQuery();
        public AddCar2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbx_id.Text != "")
            {
                List<Card> models = new List<Card>();
                int Id = Convert.ToInt16(txbx_id.Text);
                var data = SessionDb.Session.People;
                using (BankDataContext context = new BankDataContext())
                {
                    var cc = context.CardDefaults.Where(x => x.Id == Id).FirstOrDefault();
                    context.CardDefaults.Remove(cc);
                    context.Cards.Add(new Card
                    {
                        CardHolder = data.Select(x => x.Name).FirstOrDefault(),
                        CardName = txbx_name.Text,
                        CardType = txbx_type.Text,
                        Balance = Convert.ToDecimal(txbx_balance.Text),
                        ExpireDeath = Convert.ToDateTime(txbx_date.Text),
                        CVC = Convert.ToInt32(txbx_cvc.Text),
                        CardNumber = txbx_number.Text,
                        PersonId = data.Select(x => x.Id).FirstOrDefault()
                    });
                    context.SaveChanges();

                    int userid = data.Select(x => x.Id).FirstOrDefault();
                    SessionDb.Session.model = dbQuery.GettAllCardById(userid);

                    MessageBox.Show("Tebrikler Bankimizdan Cartiniz Bol olsun");
                }
            }
            else
            {
                MessageBox.Show("Satisda Card Yoxdur");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[indexRow];
            txbx_id.Text = selectedRow.Cells[0].Value.ToString();
            txbx_name.Text = selectedRow.Cells[1].Value.ToString();
            txbx_date.Text = selectedRow.Cells[4].Value.ToString();
            txbx_type.Text = selectedRow.Cells[3].Value.ToString();
            txbx_number.Text = selectedRow.Cells[2].Value.ToString();
            txbx_cvc.Text = selectedRow.Cells[5].Value.ToString();
            txbx_balance.Text = selectedRow.Cells[6].Value.ToString();
        }

        private void AddCar2_Load(object sender, EventArgs e)
        {
            using (BankDataContext context = new BankDataContext())
            {
                dataGridView1.DataSource = context.CardDefaults.ToList();
                context.SaveChanges();
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
