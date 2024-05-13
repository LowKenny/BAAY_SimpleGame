using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAAY_SimpleGame
{
    public partial class FrmGame : Form
    {
        public FrmGame()
        {
            InitializeComponent();
        }

        private void btn2P_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmBoard().Show();
        }

        private void btn1P_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry this mode is not yet available", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
