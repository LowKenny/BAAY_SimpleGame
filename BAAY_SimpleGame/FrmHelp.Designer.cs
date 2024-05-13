namespace BAAY_SimpleGame
{
    partial class FrmHelp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHelp));
            this.lblHowToPlay = new System.Windows.Forms.Label();
            this.pnlHTP = new System.Windows.Forms.Panel();
            this.lblDHTP = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lbl1P = new System.Windows.Forms.Label();
            this.lbl1pD = new System.Windows.Forms.Label();
            this.lbl2pD = new System.Windows.Forms.Label();
            this.lbl2P = new System.Windows.Forms.Label();
            this.lblIGV = new System.Windows.Forms.Label();
            this.lblIGVD = new System.Windows.Forms.Label();
            this.pnlHTP.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHowToPlay
            // 
            this.lblHowToPlay.AutoSize = true;
            this.lblHowToPlay.Font = new System.Drawing.Font("Century", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHowToPlay.Location = new System.Drawing.Point(62, 153);
            this.lblHowToPlay.Name = "lblHowToPlay";
            this.lblHowToPlay.Size = new System.Drawing.Size(240, 44);
            this.lblHowToPlay.TabIndex = 0;
            this.lblHowToPlay.Text = "How to Play";
            // 
            // pnlHTP
            // 
            this.pnlHTP.Controls.Add(this.btnExit);
            this.pnlHTP.Controls.Add(this.lblDHTP);
            this.pnlHTP.Controls.Add(this.lblHowToPlay);
            this.pnlHTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlHTP.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlHTP.Location = new System.Drawing.Point(817, 0);
            this.pnlHTP.Name = "pnlHTP";
            this.pnlHTP.Size = new System.Drawing.Size(438, 841);
            this.pnlHTP.TabIndex = 1;
            // 
            // lblDHTP
            // 
            this.lblDHTP.AutoSize = true;
            this.lblDHTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDHTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDHTP.Location = new System.Drawing.Point(14, 294);
            this.lblDHTP.Name = "lblDHTP";
            this.lblDHTP.Size = new System.Drawing.Size(346, 150);
            this.lblDHTP.TabIndex = 1;
            this.lblDHTP.Text = resources.GetString("lblDHTP.Text");
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("BankGothic Md BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.MintCream;
            this.btnExit.Location = new System.Drawing.Point(369, 13);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 47);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.lblIGVD);
            this.pnlDetails.Controls.Add(this.lblIGV);
            this.pnlDetails.Controls.Add(this.lbl2pD);
            this.pnlDetails.Controls.Add(this.lbl2P);
            this.pnlDetails.Controls.Add(this.lbl1pD);
            this.pnlDetails.Controls.Add(this.lbl1P);
            this.pnlDetails.Controls.Add(this.lblDetails);
            this.pnlDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDetails.Location = new System.Drawing.Point(0, 0);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(784, 841);
            this.pnlDetails.TabIndex = 2;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Castellar", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(28, 44);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(242, 57);
            this.lblDetails.TabIndex = 8;
            this.lblDetails.Text = "Details";
            // 
            // lbl1P
            // 
            this.lbl1P.AutoSize = true;
            this.lbl1P.Font = new System.Drawing.Font("Castellar", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1P.Location = new System.Drawing.Point(28, 138);
            this.lbl1P.Name = "lbl1P";
            this.lbl1P.Size = new System.Drawing.Size(74, 57);
            this.lbl1P.TabIndex = 9;
            this.lbl1P.Text = "1P";
            // 
            // lbl1pD
            // 
            this.lbl1pD.AutoSize = true;
            this.lbl1pD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1pD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl1pD.Location = new System.Drawing.Point(33, 219);
            this.lbl1pD.Name = "lbl1pD";
            this.lbl1pD.Size = new System.Drawing.Size(593, 50);
            this.lbl1pD.TabIndex = 8;
            this.lbl1pD.Text = "A game mode which you can play as a single player and go against\r\n a computer.";
            // 
            // lbl2pD
            // 
            this.lbl2pD.AutoSize = true;
            this.lbl2pD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2pD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl2pD.Location = new System.Drawing.Point(33, 387);
            this.lbl2pD.Name = "lbl2pD";
            this.lbl2pD.Size = new System.Drawing.Size(608, 75);
            this.lbl2pD.TabIndex = 10;
            this.lbl2pD.Text = "A two-player game which you can play with the other person such as \r\nyour friend " +
    "or your foe.\r\n\r\n";
            // 
            // lbl2P
            // 
            this.lbl2P.AutoSize = true;
            this.lbl2P.Font = new System.Drawing.Font("Castellar", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2P.Location = new System.Drawing.Point(28, 306);
            this.lbl2P.Name = "lbl2P";
            this.lbl2P.Size = new System.Drawing.Size(81, 57);
            this.lbl2P.TabIndex = 11;
            this.lbl2P.Text = "2P";
            // 
            // lblIGV
            // 
            this.lblIGV.AutoSize = true;
            this.lblIGV.Font = new System.Drawing.Font("Castellar", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIGV.Location = new System.Drawing.Point(30, 509);
            this.lblIGV.Name = "lblIGV";
            this.lblIGV.Size = new System.Drawing.Size(401, 44);
            this.lblIGV.TabIndex = 12;
            this.lblIGV.Text = "In-Game Visuals";
            // 
            // lblIGVD
            // 
            this.lblIGVD.AutoSize = true;
            this.lblIGVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIGVD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblIGVD.Location = new System.Drawing.Point(33, 598);
            this.lblIGVD.Name = "lblIGVD";
            this.lblIGVD.Size = new System.Drawing.Size(695, 100);
            this.lblIGVD.TabIndex = 13;
            this.lblIGVD.Text = resources.GetString("lblIGVD.Text");
            // 
            // FrmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1255, 841);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlHTP);
            this.ForeColor = System.Drawing.Color.Aqua;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHelp";
            this.pnlHTP.ResumeLayout(false);
            this.pnlHTP.PerformLayout();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHowToPlay;
        private System.Windows.Forms.Panel pnlHTP;
        private System.Windows.Forms.Label lblDHTP;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblIGVD;
        private System.Windows.Forms.Label lblIGV;
        private System.Windows.Forms.Label lbl2pD;
        private System.Windows.Forms.Label lbl2P;
        private System.Windows.Forms.Label lbl1pD;
        private System.Windows.Forms.Label lbl1P;
        private System.Windows.Forms.Label lblDetails;
    }
}