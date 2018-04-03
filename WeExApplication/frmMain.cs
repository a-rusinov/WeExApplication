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
            this.Text = "Программа просмотра страниц в Интернет" + webBrowser1.DocumentTitle;
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
            webBrowser1.GoHome();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoSearch();
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
                // t// генерируем работу часов с отображением в Label1
                timer1.Enabled = true;
                timer1.Interval = 1000;
                label1.Text = DateTime.Now.ToLongTimeString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
