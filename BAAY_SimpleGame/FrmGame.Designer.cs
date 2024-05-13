namespace BAAY_SimpleGame
{
    partial class FrmGame
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
            this.btn2P = new System.Windows.Forms.Button();
            this.btn1P = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn2P
            // 
            this.btn2P.FlatAppearance.BorderSize = 0;
            this.btn2P.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2P.Font = new System.Drawing.Font("BankGothic Lt BT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2P.ForeColor = System.Drawing.Color.Aqua;
            this.btn2P.Location = new System.Drawing.Point(373, 363);
            this.btn2P.Margin = new System.Windows.Forms.Padding(4);
            this.btn2P.Name = "btn2P";
            this.btn2P.Size = new System.Drawing.Size(289, 52);
            this.btn2P.TabIndex = 6;
            this.btn2P.Text = "2P";
            this.btn2P.UseVisualStyleBackColor = true;
            this.btn2P.Click += new System.EventHandler(this.btn2P_Click);
            // 
            // btn1P
            // 
            this.btn1P.FlatAppearance.BorderSize = 0;
            this.btn1P.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1P.Font = new System.Drawing.Font("BankGothic Lt BT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1P.ForeColor = System.Drawing.Color.Aqua;
            this.btn1P.Location = new System.Drawing.Point(373, 225);
            this.btn1P.Margin = new System.Windows.Forms.Padding(4);
            this.btn1P.Name = "btn1P";
            this.btn1P.Size = new System.Drawing.Size(289, 52);
            this.btn1P.TabIndex = 5;
            this.btn1P.Text = "1P";
            this.btn1P.UseVisualStyleBackColor = true;
            this.btn1P.Click += new System.EventHandler(this.btn1P_Click);
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1112, 656);
            this.Controls.Add(this.btn2P);
            this.Controls.Add(this.btn1P);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGame";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn2P;
        private System.Windows.Forms.Button btn1P;
    }
}