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
    public partial class FormResult : Form
    {
        public FormResult()
        {
            InitializeComponent();
        }
        public void initResultat(int resultNum)
        {
            switch (resultNum)
            {
                case 0:
                    result_text.Text = "Вам подходит роль храброго воина или рыцаря.";
                    pictureBox1.Image = Properties.Resources.knight;
                    break;
                case 1:
                    result_text.Text = "Вам подойдет роль отважного путешественника или стрелка.";
                    pictureBox1.Image = Properties.Resources.traveler;
                    break;
                case 2:
                    result_text.Text = "Вам больше подходит роль мудрого волшебника или колдуна.";
                    pictureBox1.Image = Properties.Resources.wizard;
                    break;
                case 3:
                    result_text.Text = "Вы подходите для роли хитрого вора или скрытного убийцы.";
                    pictureBox1.Image = Properties.Resources.killer;
                    break;
            }



        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
