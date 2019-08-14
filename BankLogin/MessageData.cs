using BankLogin.ModelMessage;
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
    public partial class MessageData : Form
    {
        public MessageData()
        {
            InitializeComponent();
        }

        private void MessageData_Load(object sender, EventArgs e)
        {
            List<string> messages = new List<string>();
            var data = SessionDb.Session.model;
            using (BankDataContext context = new BankDataContext())
            {
                int userId = data.Select(x => x.PersonId).FirstOrDefault();
                messages = context.AddMessages.Where(x => x.PersonId == userId).Select(x => x.UserMessage).ToList();
                foreach(string str in messages)
                {
                    richTextBox1.Text += str + "\n";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
        }
    }
}
