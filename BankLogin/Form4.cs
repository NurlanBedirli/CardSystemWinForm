using BankLogin.FileManag;
using BankLogin.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankLogin
{
    public partial class Form4 : Form
    {
        double total;
        int count = 1;
        FileManager manager = new FileManager();
        public Form4()
        {
            InitializeComponent();
            DynamicTool();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        int page = 1;
        //dynamic pagination Carddata
        public void DynamicTool()
        {
            var elm = SessionDb.Session.model;

            int skip = ((int)page - 1) * 1;
            var data = elm.Skip(skip).Take(1).ToList();
            var data2 =  SessionDb.Session.model1 = data;
            total = Math.Ceiling(elm.Count / 1.0);

            int x = 0;
            int y = 190;
            int total2 = 2;
            // Dynamic paging-button
            for (int i = 1; i <= total2; i++)
            {
                    Button button = new Button();
                    button.Name = "Slide";
                    button.Size = new Size(10, 10);
                    button.Text = i.ToString();
                    button.Click += DataPage;
                    button.Location = new Point(x * 15 + 130, y);
                    button.BackColor = Color.Red;
                    Controls.Add(button);
                    x++;
            }
            if(total >2)
            {
                RightSlide();
                LeftSlide();
            }
            int a = 0;
            foreach(var zz in data)
            {
                Tool(zz.Name, zz.Surname, zz.CardNumber, zz.CardType,zz.CardName, zz.ExpireDeath, ref a);
            }
            foreach(var ww in data2)
            {
                CurrenEuro(ww.Balance, 2);
                CurrenAzn(ww.Balance, 1);
                CurrenDollar(ww.Balance, 1.70);
            }
        }

        // Right Slide icon dynamic 
        public void RightSlide()
        {
            count = 1;
            string fullpath = manager.FileName("next-arrow-icon-13.jpg");
            byte[] array = manager.ReadFromFile(fullpath);
            Panel panel = new Panel();
            panel.Size = new Size(30, 30);
            panel.Location = new Point(263, 100);
            panel.BackgroundImage = Image.FromStream(new MemoryStream(array));
            panel.BackgroundImageLayout = ImageLayout.Stretch;
            panel.Click += Panel_Click;
            Controls.Add(panel);
        }

        // Right Slide icon Click Next Element
        private void Panel_Click(object sender, EventArgs e)
        {
            count++;
            txbx_card1.Text = "";
            var data = SessionDb.Session.model;
            if (data.Count < count)
            {
                count = data.Count;
               txbx_card1.Text = $"Sizin Kartinizin Mehdud Sayi {data.Count} dir";
            }
            else
            {
                int skip = ((int)count - 1) * 1;
                var elm = data.Skip(skip).Take(1).ToList();
                var data2 = SessionDb.Session.model1 = elm;
                Controlss();
                int a = 0;
                foreach (var zz in elm)
                {
                    Tool(zz.Name, zz.Surname, zz.CardNumber, zz.CardType, zz.CardName, zz.ExpireDeath, ref a);
                }
                foreach (var ww in data2)
                {
                    CurrenEuro(ww.Balance, 2);
                    CurrenAzn(ww.Balance, 1);
                    CurrenDollar(ww.Balance, 1.70);
                }
            }
        }

        // left slide icon dynamic
        public void LeftSlide()
        {
            count--;
            string fullpath = manager.FileName("004_041_left_prev_previous_home_arrow_circle1x-512.png");
            byte[] array = manager.ReadFromFile(fullpath);
            Panel panel = new Panel();
            panel.Size = new Size(30, 30);
            panel.Location = new Point(0, 100);
            panel.BackgroundImage = Image.FromStream(new MemoryStream(array));
            panel.BackgroundImageLayout = ImageLayout.Stretch;
            panel.Click += PrevCount;
            Controls.Add(panel);
        }

        // left slide icon click Prev Element
        private void PrevCount(object sender, EventArgs e)
        {
            txbx_card1.Text = "";
            var data = SessionDb.Session.model;
            if (count == 0)
            {
                count = 1;
                txbx_card1.Text = $"Sizin Kartinizin Mehdud Sayi {data.Count} dir";
            }
            else
            {
                count--;
                int skip = ((int)count - 1) * 1;
                var data1 = data.Skip(skip).Take(1).ToList();
                var data2 = SessionDb.Session.model1 = data1;
                Controlss();
                int a = 0;
                foreach (var zz in data1)
                {
                    Tool(zz.Name, zz.Surname, zz.CardNumber, zz.CardType, zz.CardName, zz.ExpireDeath, ref a);
                }
                foreach (var ww in data2)
                {
                    CurrenEuro(ww.Balance, 2);
                    CurrenAzn(ww.Balance, 1);
                    CurrenDollar(ww.Balance, 1.70);
                }
            }
        }

        private void DataPage(object sender, EventArgs e)
        {
            SessionDb.Session.model1.Clear();
            Controlss();
            string number = (sender as Button).Text;
            Page(Convert.ToInt32(number));
        }

        //Dynamic Button Click New Page
        private void Page(int? page=1)
        {
            var elm = SessionDb.Session.model;

            int skip = ((int)page - 1) * 1;
            var data = elm.Skip(skip).Take(1).ToList();
            var data2 = SessionDb.Session.model1 = data;
            total = Math.Ceiling(elm.Count / 1.0);
            int a = 0;
            foreach (var zz in data)
            {
                Tool(zz.Name, zz.Surname, zz.CardNumber, zz.CardType,zz.CardName,zz.ExpireDeath,ref a);
            }
            foreach (var ww in data2)
            {
                CurrenEuro(ww.Balance, 2);
                CurrenAzn(ww.Balance, 1);
                CurrenDollar(ww.Balance, 1.70);
            }
        }

        // Dynamic Card Tools
        public void Tool(string name,string surname,string number,string card,string cardtyp,DateTime date,ref int a)
        {
            PictureBox Panel = new PictureBox();
            Panel.Size = new Size(260, 150);
            Panel.BackColor = Color.DeepSkyBlue;
            Panel.Location = new Point(a * 20 + 16, 35);

            Label label = new Label();
            label.Text = $"{name} {surname}";
            label.Size = new Size(70, 15);
            label.BackColor = Color.Yellow;
            label.ForeColor = Color.Red;
            label.Location = new Point(a * 10 + 35, 150);


            Label cardname = new Label();
            cardname.Text = $"{cardtyp}";
            cardname.Size = new Size(50, 15);
            cardname.BackColor = Color.Yellow;
            cardname.ForeColor = Color.Red;
            cardname.Location = new Point(a * 10 + 165, 150);


            Label cardDate = new Label();
            cardDate.Text = $"{date.ToUniversalTime()}";
            cardDate.Size = new Size(70, 15);
            cardDate.BackColor = Color.Yellow;
            cardDate.ForeColor = Color.Red;
            cardDate.Location = new Point(a * 10 + 62, 132);


            Label labelnUM = new Label();
            labelnUM.Text = $"{number}";
            labelnUM.Size = new Size(90, 15);
            labelnUM.BackColor = Color.Yellow;
            labelnUM.Location = new Point(a * 10 + 45, 110);


            Label cardtype = new Label();
            cardtype.Text = $"{card}";
            cardtype.Size = new Size(50, 15);
            cardtype.ForeColor = Color.OrangeRed;
            cardtype.BackColor = Color.Yellow;
            cardtype.Location = new Point(a * 10 + 45, 45);

            Controls.Add(cardDate);
            Controls.Add(cardname);
            Controls.Add(cardtype);
            Controls.Add(labelnUM);
            Controls.Add(label);
            Controls.Add(Panel);
            a++;
        }

        // Controls Delete
        public void Controlss()
        {
            List<Control> cnt = new List<Control>();
            foreach (Control cont in this.Controls)
            {
                cnt.Add(cont);
            }
            foreach (Control control in cnt)
            {
                PictureBox pict = control as PictureBox;
                if (pict != null)
                {
                    this.Controls.Remove(pict);
                }
                Label label = control as Label;
                if (label != null)
                {
                    this.Controls.Remove(label);
                }
            }
        }

        // Currency write TextBox
        private void CurrenEuro(decimal balans, double currency)
        {
            double result = 0;
            result = Convert.ToDouble(balans) / currency;
            txbx_euro.Text = result.ToString();
        }
        private void CurrenAzn(decimal balans, double currency)
        {
            double result = 0;
            result = Convert.ToDouble(balans) * currency;
            txbx_azn.Text = result.ToString();
        }
        private void CurrenDollar(decimal balans, double currency)
        {
            double result = 0;
            result = Convert.ToDouble(balans) / currency;
            string dollar = result.ToString();
            if (dollar != "0")
            {
                if (dollar.Contains("."))
                {
                    txbx_dollar.Text = dollar.Substring(0, dollar.LastIndexOf(".") + 2);
                }
                else
                    txbx_dollar.Text = dollar;
            }
            else
                txbx_dollar.Text = dollar;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            panel6.Visible = false;
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            
           
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (SessionDb.Session.model.Count != 0)
            {
                AddCard addCard = new AddCard();
                this.Hide();
                addCard.ShowDialog();
            }
            else
            {
                AddCar2 addCard2 = new AddCar2();
                this.Hide();
                addCard2.ShowDialog();
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SessionDb.Session.model.Clear();
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageData data = new MessageData();
            this.Hide();
            data.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBalance addBalance = new AddBalance();
            this.Hide();
            addBalance.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
