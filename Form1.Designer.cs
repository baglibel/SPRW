namespace SerialPort_RW
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.baglanBTN = new System.Windows.Forms.Button();
            this.yenileBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.receivedDatas = new System.Windows.Forms.TextBox();
            this.gonderBTN = new System.Windows.Forms.Button();
            this.gonderText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(85, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // baglanBTN
            // 
            this.baglanBTN.Location = new System.Drawing.Point(284, 90);
            this.baglanBTN.Name = "baglanBTN";
            this.baglanBTN.Size = new System.Drawing.Size(122, 23);
            this.baglanBTN.TabIndex = 1;
            this.baglanBTN.Text = "Bağlan";
            this.baglanBTN.UseVisualStyleBackColor = true;
            this.baglanBTN.Click += new System.EventHandler(this.baglanBTN_Click);
            // 
            // yenileBTN
            // 
            this.yenileBTN.Location = new System.Drawing.Point(156, 90);
            this.yenileBTN.Name = "yenileBTN";
            this.yenileBTN.Size = new System.Drawing.Size(122, 23);
            this.yenileBTN.TabIndex = 2;
            this.yenileBTN.Text = "Yenile";
            this.yenileBTN.UseVisualStyleBackColor = true;
            this.yenileBTN.Click += new System.EventHandler(this.yenileBTN_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(85, 47);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(111, 23);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(205, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parity:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(205, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "StopBits:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(268, 13);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(111, 23);
            this.comboBox3.TabIndex = 9;
            this.comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;

            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(268, 47);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(111, 23);
            this.comboBox4.TabIndex = 8;
            this.comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;

            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Durum: Bağlı değil";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "BaudRate:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // receivedDatas
            // 
            this.receivedDatas.Location = new System.Drawing.Point(12, 116);
            this.receivedDatas.MaxLength = 99999;
            this.receivedDatas.Multiline = true;
            this.receivedDatas.Name = "receivedDatas";
            this.receivedDatas.ReadOnly = true;
            this.receivedDatas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.receivedDatas.Size = new System.Drawing.Size(394, 215);
            this.receivedDatas.TabIndex = 12;
            // 
            // gonderBTN
            // 
            this.gonderBTN.Location = new System.Drawing.Point(331, 337);
            this.gonderBTN.Name = "gonderBTN";
            this.gonderBTN.Size = new System.Drawing.Size(75, 23);
            this.gonderBTN.TabIndex = 13;
            this.gonderBTN.Text = "Gönder";
            this.gonderBTN.UseVisualStyleBackColor = true;
            this.gonderBTN.Click += new System.EventHandler(this.gonderBTN_Click);
            // 
            // gonderText
            // 
            this.gonderText.Location = new System.Drawing.Point(12, 337);
            this.gonderText.Name = "gonderText";
            this.gonderText.Size = new System.Drawing.Size(313, 23);
            this.gonderText.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 368);
            this.Controls.Add(this.gonderText);
            this.Controls.Add(this.gonderBTN);
            this.Controls.Add(this.receivedDatas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yenileBTN);
            this.Controls.Add(this.baglanBTN);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SPRW";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private Button baglanBTN;
        private Button yenileBTN;
        private Label label1;
        private ComboBox comboBox2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label5;
        private Label label2;
        private TextBox receivedDatas;
        private Button gonderBTN;
        private TextBox gonderText;
    }
}