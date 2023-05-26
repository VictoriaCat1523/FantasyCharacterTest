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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }
        public void initResultat(string result)
        {
            result_text.Text = result;

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
