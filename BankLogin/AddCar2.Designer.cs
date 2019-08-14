namespace BankLogin
{
    partial class AddCar2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbx_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txbx_type = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbx_balance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbx_number = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbx_cvc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbx_date = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbx_id
            // 
            this.txbx_id.Cursor = System.Windows.Forms.Cursors.No;
            this.txbx_id.Enabled = false;
            this.txbx_id.Location = new System.Drawing.Point(539, 233);
            this.txbx_id.Name = "txbx_id";
            this.txbx_id.Size = new System.Drawing.Size(35, 20);
            this.txbx_id.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(634, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 28;
            this.button1.Text = "Buy";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbx_type
            // 
            this.txbx_type.Cursor = System.Windows.Forms.Cursors.No;
            this.txbx_type.Location = new System.Drawing.Point(14, 299);
            this.txbx_type.Name = "txbx_type";
            this.txbx_type.Size = new System.Drawing.Size(100, 20);
            this.txbx_type.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.No;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(11, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "CardType";
            // 
            // txbx_balance
            // 
            this.txbx_balance.Cursor = System.Windows.Forms.Cursors.No;
            this.txbx_balance.Location = new System.Drawing.Point(392, 299);
            this.txbx_balance.Name = "txbx_balance";
            this.txbx_balance.Size = new System.Drawing.Size(100, 20);
            this.txbx_balance.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.No;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(389, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "CardBalance";
            // 
            // txbx_number
            // 
            this.txbx_number.Cursor = System.Windows.Forms.Cursors.No;
            this.txbx_number.Location = new System.Drawing.Point(209, 233);
            this.txbx_number.Name = "txbx_number";
            this.txbx_number.Size = new System.Drawing.Size(100, 20);
            this.txbx_number.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.No;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(206, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "CardNumber";
            // 
            // txbx_cvc
            // 
            this.txbx_cvc.Cursor = System.Windows.Forms.Cursors.No;
            this.txbx_cvc.Location = new System.Drawing.Point(209, 299);
            this.txbx_cvc.Name = "txbx_cvc";
            this.txbx_cvc.Size = new System.Drawing.Size(100, 20);
            this.txbx_cvc.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.No;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(206, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "CardCvc";
            // 
            // txbx_date
            // 
            this.txbx_date.Cursor = System.Windows.Forms.Cursors.No;
            this.txbx_date.Location = new System.Drawing.Point(392, 233);
            this.txbx_date.Name = "txbx_date";
            this.txbx_date.Size = new System.Drawing.Size(100, 20);
            this.txbx_date.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(389, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "CardExpireDeath";
            // 
            // txbx_name
            // 
            this.txbx_name.Cursor = System.Windows.Forms.Cursors.No;
            this.txbx_name.Location = new System.Drawing.Point(14, 233);
            this.txbx_name.Name = "txbx_name";
            this.txbx_name.Size = new System.Drawing.Size(100, 20);
            this.txbx_name.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(11, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "CardName";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 186);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button2.ForeColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(682, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 22);
            this.button2.TabIndex = 30;
            this.button2.Text = "Esas Sehife";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddCar2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(759, 352);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txbx_id);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbx_type);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbx_balance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbx_number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbx_cvc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbx_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbx_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddCar2";
            this.Text = "AddCar2";
            this.Load += new System.EventHandler(this.AddCar2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbx_type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbx_balance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbx_number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbx_cvc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbx_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
    }
}