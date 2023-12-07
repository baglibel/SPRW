using System.IO.Ports;

namespace SerialPort_RW
{
    public partial class Form1 : Form
    {
        static SerialPort sp = new SerialPort();
        ComboBox[] baglantiCombos;
        public Form1()
        {
            InitializeComponent();
            PortlariListele();
            comboBox2.Items.AddRange(new string[]
            { "300","600","1200","2400","4800","9600","19200","38400","57600","115200","230400","460800","921600"});
            comboBox2.SelectedIndex = 5;
            comboBox3.Items.AddRange(Enum.GetNames(typeof(Parity)));
            comboBox3.SelectedIndex = 0;
            comboBox4.Items.AddRange(Enum.GetNames(typeof(StopBits)));
            comboBox4.SelectedIndex = 0;
            CheckForIllegalCrossThreadCalls = false;
            gonderBTN.Enabled = false;
            gonderText.Enabled = false;
            receivedDatas.Enabled = false;
            sp.ReadTimeout = 100;
            sp.WriteTimeout = 100;
            baglantiCombos = new ComboBox[] { comboBox1, comboBox2, comboBox3, comboBox4 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void PortlariListele()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(SerialPort.GetPortNames());
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedItem = comboBox1.Items[0];
                baglanBTN.Enabled = true;
            }
            else
            {
                comboBox1.Text = null;
                baglanBTN.Enabled = false;
            }
        }

        private void yenileBTN_Click(object sender, EventArgs e)
        {
            PortlariListele();
        }

        private void baglanBTN_Click(object sender, EventArgs e)
        {
            if (baglanBTN.Text == "Baðlan")
            {
                sp.PortName = comboBox1.Text;
                sp.BaudRate = Convert.ToInt32(comboBox2.Text);
                sp.Parity = (Parity)Enum.Parse(typeof(Parity), comboBox3.Text, true);
                if (comboBox4.Text.ToLower() != "none")
                {
                    sp.StopBits = (StopBits)Enum.Parse(typeof(StopBits),
                    comboBox4.Text, true);
                }
                try
                {
                    sp.Open();
                    sp.DataReceived += new SerialDataReceivedEventHandler(Okuyucu);
                    baglanBTN.Text = "Baðlantýyý Kes";
                    label5.Text = "Durum: Baðlý (" + sp.PortName + ")";
                    gonderBTN.Enabled = true;
                    gonderText.Enabled = true;
                    yenileBTN.Enabled = false;
                    receivedDatas.Enabled = true;
                    foreach (ComboBox item in baglantiCombos)
                        item.Enabled = false;
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show("Bu port baþka bir uygulama tarafýndan kullanýlýyor.", "Hata");
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("Port bulunamadý!", "Hata");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata");

                }

            }
            else
            {
                sp.Close();
                sp.DataReceived -= Okuyucu;
                baglanBTN.Text = "Baðlan";
                label5.Text = "Durum: Baðlý deðil";
                gonderBTN.Enabled = false;
                gonderText.Text = string.Empty;
                gonderText.Enabled = false;
                yenileBTN.Enabled = true;
                receivedDatas.Enabled = false;
                PortlariListele();
                foreach (ComboBox item in baglantiCombos)
                    item.Enabled = true;
            }
        }

        private void Okuyucu(object sender, EventArgs e)
        {
            string gelen = ((SerialPort)sender).ReadExisting();
            if (sp.IsOpen)
            {
                receivedDatas.AppendText($"[{DateTime.Now.ToString("T")}] Gelen: '{gelen}'"); 
                receivedDatas.AppendText(Environment.NewLine);
            }
        }

        private void gonderBTN_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.Write(gonderText.Text);
                receivedDatas.AppendText($"[{DateTime.Now.ToString("T")}] Gönderilen: '{gonderText.Text}'");
                receivedDatas.AppendText(Environment.NewLine);
            }
        }
    }
}