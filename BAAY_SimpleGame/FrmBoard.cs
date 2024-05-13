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
    public partial class FrmBoard : Form
    {
        Boolean checker;
        int plusone;

        void Enable_False()
        {
            btnTic1.Enabled = false;
            btnTic2.Enabled = false;
            btnTic3.Enabled = false;
            btnTic4.Enabled = false;
            btnTic5.Enabled = false;
            btnTic6.Enabled = false;
            btnTic7.Enabled = false;
            btnTic8.Enabled = false;
            btnTic9.Enabled = false;
        }
        void score()
        {
            // X
            if (btnTic1.Text == "X" && btnTic2.Text == "X" && btnTic3.Text == "X")
            {
                btnTic1.BackColor= Color.Aqua;
                btnTic2.BackColor = Color.Aqua;
                btnTic3.BackColor = Color.Aqua;

                MessageBox.Show("The winner is Player X","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic1.Text == "X" && btnTic4.Text == "X" && btnTic7.Text == "X")
            {
                btnTic1.BackColor = Color.Aqua;
                btnTic4.BackColor = Color.Aqua;
                btnTic7.BackColor = Color.Aqua;

                MessageBox.Show("The winner is Player X", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic1.Text == "X" && btnTic5.Text == "X" && btnTic9.Text == "X")
            {
                btnTic1.BackColor = Color.Aqua;
                btnTic5.BackColor = Color.Aqua;
                btnTic9.BackColor = Color.Aqua;

                MessageBox.Show("The winner is Player X", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic3.Text == "X" && btnTic5.Text == "X" && btnTic7.Text == "X")
            {
                btnTic3.BackColor = Color.Aqua;
                btnTic5.BackColor = Color.Aqua;
                btnTic7.BackColor = Color.Aqua;

                MessageBox.Show("The winner is Player X", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic2.Text == "X" && btnTic5.Text == "X" && btnTic8.Text == "X")
            {
                btnTic2.BackColor = Color.Aqua;
                btnTic5.BackColor = Color.Aqua;
                btnTic8.BackColor = Color.Aqua;

                MessageBox.Show("The winner is Player X", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic3.Text == "X" && btnTic6.Text == "X" && btnTic9.Text == "X")
            {
                btnTic3.BackColor = Color.Aqua;
                btnTic6.BackColor = Color.Aqua;
                btnTic9.BackColor = Color.Aqua;

                MessageBox.Show("The winner is Player X", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic4.Text == "X" && btnTic5.Text == "X" && btnTic6.Text == "X")
            {
                btnTic4.BackColor = Color.Aqua;
                btnTic5.BackColor = Color.Aqua;
                btnTic6.BackColor = Color.Aqua;

                MessageBox.Show("The winner is Player X", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic7.Text == "X" && btnTic8.Text == "X" && btnTic9.Text == "X")
            {
                btnTic7.BackColor = Color.Aqua;
                btnTic8.BackColor = Color.Aqua;
                btnTic9.BackColor = Color.Aqua;

                MessageBox.Show("The winner is Player X", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            // O

            if (btnTic1.Text == "O" && btnTic2.Text == "O" && btnTic3.Text == "O")
            {
                btnTic1.BackColor = Color.Aqua;
                btnTic2.BackColor = Color.Aqua;
                btnTic3.BackColor = Color.Aqua;

                MessageBox.Show("The winner is Player O", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic1.Text == "O" && btnTic4.Text == "O" && btnTic7.Text == "O")
            {
                btnTic1.BackColor = Color.Aqua;
                btnTic4.BackColor = Color.Aqua;
                btnTic7.BackColor = Color.Aqua;

                MessageBox.Show("The winner is Player O", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic1.Text == "O" && btnTic5.Text == "O" && btnTic9.Text == "O")
            {
                btnTic1.BackColor = Color.Aqua;
                btnTic5.BackColor = Color.Aqua;
                btnTic9.BackColor = Color.Aqua;

                MessageBox.Show("The winner is Player O", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic3.Text == "O" && btnTic5.Text == "O" && btnTic7.Text == "O")
            {
                btnTic3.BackColor = Color.Aqua;
                btnTic5.BackColor = Color.Aqua;
                btnTic7.BackColor = Color.Aqua;

                MessageBox.Show("The winner is Player O", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic2.Text == "O" && btnTic5.Text == "O" && btnTic8.Text == "O")
            {
                btnTic2.BackColor = Color.Aqua;
                btnTic5.BackColor = Color.Aqua;
                btnTic8.BackColor = Color.Aqua;

                MessageBox.Show("The winner is Player O", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic3.Text == "O" && btnTic6.Text == "O" && btnTic9.Text == "O")
            {
                btnTic3.BackColor = Color.Aqua;
                btnTic6.BackColor = Color.Aqua;
                btnTic9.BackColor = Color.Aqua;

                MessageBox.Show("The winner is Player O", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic4.Text == "O" && btnTic5.Text == "O" && btnTic6.Text == "O")
            {
                btnTic4.BackColor = Color.Aqua;
                btnTic5.BackColor = Color.Aqua;
                btnTic6.BackColor = Color.Aqua;

                MessageBox.Show("The winner is Player O", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic7.Text == "O" && btnTic8.Text == "O" && btnTic9.Text == "O")
            {
                btnTic7.BackColor = Color.Aqua;
                btnTic8.BackColor = Color.Aqua;
                btnTic9.BackColor = Color.Aqua;

                MessageBox.Show("The winner is Player O", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
        }

        public FrmBoard()
        {
            InitializeComponent();
        }

        private void FrmBoard_Load(object sender, EventArgs e)
        {

        }

        private void lblPlayerX_Click(object sender, EventArgs e)
        {

        }

        private void btnTic1_Click(object sender, EventArgs e)
        {
            if (checker == false) 
            {
                btnTic1.Text = "X";
                checker = true;
            }
            else
            {
                btnTic1.Text = "O";
                checker = false;
            }
            score();
            btnTic1.Enabled = false;
        }

        private void btnTic2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic2.Text = "X";
                checker = true;
            }
            else
            {
                btnTic2.Text = "O";
                checker = false;
            }
            score();
            btnTic2.Enabled = false;
        }

        private void btnTic3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic3.Text = "X";
                checker = true;
            }
            else
            {
                btnTic3.Text = "O";
                checker = false;
            }
            score();
            btnTic3.Enabled = false;
        }

        private void btnTic4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic4.Text = "X";
                checker = true;
            }
            else
            {
                btnTic4.Text = "O";
                checker = false;
            }
            score();
            btnTic4.Enabled = false;
        }

        private void btnTic5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic5.Text = "X";
                checker = true;
            }
            else
            {
                btnTic5.Text = "O";
                checker = false;
            }
            score();
            btnTic5.Enabled = false;
        }

        private void btnTic6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic6.Text = "X";
                checker = true;
            }
            else
            {
                btnTic6.Text = "O";
                checker = false;
            }
            score();
            btnTic6.Enabled = false;
        }

        private void btnTic7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic7.Text = "X";
                checker = true;
            }
            else
            {
                btnTic7.Text = "O";
                checker = false;
            }
            score();
            btnTic7.Enabled = false;
        }

        private void btnTic8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic8.Text = "X";
                checker = true;
            }
            else
            {
                btnTic8.Text = "O";
                checker = false;
            }
            score();
            btnTic8.Enabled = false;
        }

        private void btnTic9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic9.Text = "X";
                checker = true;
            }
            else
            {
                btnTic9.Text = "O";
                checker = false;
            }
            score();
            btnTic9.Enabled = false;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            btnTic1.Enabled = true;
            btnTic2.Enabled = true; 
            btnTic3.Enabled = true; 
            btnTic4.Enabled = true;
            btnTic5.Enabled = true;
            btnTic6.Enabled = true;
            btnTic7.Enabled = true;
            btnTic8.Enabled = true;
            btnTic9.Enabled = true;
                
            btnTic1.Text= "";
            btnTic2.Text = "";
            btnTic3.Text = "";
            btnTic4.Text = "";
            btnTic5.Text = "";
            btnTic6.Text = "";
            btnTic7.Text = "";
            btnTic8.Text = "";
            btnTic9.Text = "";

            lblPlayerX.Text = "0";
            lblPlayerO.Text = "0";

            btnTic1.BackColor = Color.White;
            btnTic2.BackColor = Color.White;
            btnTic3.BackColor = Color.White;
            btnTic4.BackColor = Color.White;
            btnTic5.BackColor = Color.White;
            btnTic6.BackColor = Color.White;
            btnTic7.BackColor = Color.White;
            btnTic8.BackColor = Color.White;
            btnTic9.BackColor = Color.White;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            btnTic1.Enabled = true;
            btnTic2.Enabled = true;
            btnTic3.Enabled = true;
            btnTic4.Enabled = true;
            btnTic5.Enabled = true;
            btnTic6.Enabled = true;
            btnTic7.Enabled = true;
            btnTic8.Enabled = true;
            btnTic9.Enabled = true;

            btnTic1.Text = "";
            btnTic2.Text = "";
            btnTic3.Text = "";
            btnTic4.Text = "";
            btnTic5.Text = "";
            btnTic6.Text = "";
            btnTic7.Text = "";
            btnTic8.Text = "";
            btnTic9.Text = "";

            btnNewGame.Enabled = true;

            btnTic1.BackColor = Color.White;
            btnTic2.BackColor = Color.White;
            btnTic3.BackColor = Color.White;
            btnTic4.BackColor = Color.White;
            btnTic5.BackColor = Color.White;
            btnTic6.BackColor = Color.White;
            btnTic7.BackColor = Color.White;
            btnTic8.BackColor = Color.White;
            btnTic9.BackColor = Color.White;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
