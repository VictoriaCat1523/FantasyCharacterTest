using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FantasyCharacterTest
{
    public partial class FormStart : Form
    {
        Random rnd = new Random();
        public FormStart()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length < 3)
            {
                lblError.Text = "Имя должно быть больше 3 символов!";
                lblError.Visible = true;
                return;
            }
            if (!checkBox.Checked)
            {
                lblError.Visible = true;
                lblError.Text = "Поставьте галочку для продолжения!";
                return;
            }
            lblError.Visible = false;
            progressBar.Visible = true;
            lblSetting.Visible = true;
            progressBar.Value = 0;
            timer.Start();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 2;
            BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));

            if (progressBar.Value >= 100)
            {
                timer.Stop();
                BackColor = Control.DefaultBackColor;
                FormTest formTest = new FormTest();
                formTest.ShowDialog();
                checkBox.Checked = false;
                textBoxName.Text = "";
                progressBar.Value = 0;
                progressBar.Visible = false;
                lblSetting.Visible = false;
            }
        }
    }
}
