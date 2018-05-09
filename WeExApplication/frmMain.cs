using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeExApplication
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)

            
        {
            // Main Form Parametrs

            this.AcceptButton = go;
            this.CancelButton = CancelButton;
            this.Text = Properties.Settings.Default.AppName; 
            this.ForeColor = Properties.Settings.Default.FormColor;
            this.BackColor = Properties.Settings.Default.FormColor;




            // Sittings
            Properties.Settings.Default.HomePage = "https://yandex.ru"; // Home Page
            Properties.Settings.Default.FindPage = "https://google.ru"; //Find Page

           
        }

        private void go_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(comboBox1.Text);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Properties.Settings.Default.HomePage);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Properties.Settings.Default.FindPage);
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PageSetupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPageSetupDialog();
        }

        private void PrintPreviewtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintPreviewDialog();
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowSaveAsDialog();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowSaveAsDialog();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show("Код функции в доработке, благодарим за понимание");
                webBrowser1.Navigate(openFileDialog1.FileName); // Add test Function
                openFileDialog1.Filter = "html Файлы (html,htm)|*.html;*.htm;*";


                OpenFileDialog ofd = new OpenFileDialog();
                // Do filtering here
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    webBrowser1.DocumentText = System.IO.File.ReadAllText(ofd.FileName);
                }

                //string ext = System.IO.Path.GetExtension(openFileDialog1.FileName);

                System.IO.Stream s = System.IO.File.OpenRead(ofd.FileName);
                webBrowser1.DocumentStream = s;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain chf = new frmMain();
            chf.Show();
        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void NextToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgAboutBox dlA = new dlgAboutBox();
            dlA.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                // генерируем работу часов с отображением в Label1
                timer1.Enabled = true;
                timer1.Interval = 1000;
                label1.Text = DateTime.Now.ToLongTimeString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void опцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings();
            frmSettings.ShowDialog();
        }
    }
}
