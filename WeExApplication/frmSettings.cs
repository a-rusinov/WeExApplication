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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            this.Text = Properties.Settings.Default.AppName;
            button1.Text = "Закрыть";
            button2.Text = "OK";
            checkBox1.Text = "Настроить Домашнюю страницу и страницу поиска;";
            label1.Text = "Выберите цвет оформления формы...";
            button3.Text = "Выбрать Цвет...";
            checkBox1.Checked = false;
            textBox3.Enabled = false;
            textBox3.Visible = false;

            txtFindPage.Enabled = false;
            txtHomePage.Enabled = false;

            txtHomePage.Text = Properties.Settings.Default.HomePage;
            txtFindPage.Text = Properties.Settings.Default.FindPage;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtFindPage.Enabled = true;
                txtHomePage.Enabled = true;
            }
            else
            {
                txtFindPage.Enabled = false;
                txtHomePage.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.HomePage = txtHomePage.Text;
            Properties.Settings.Default.FindPage = txtFindPage.Text;
            Application.Restart();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            colorDialog1.Color = Properties.Settings.Default.FormColor;

        }
    }
}
