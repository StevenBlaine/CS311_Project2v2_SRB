namespace CS311_Project2v2_SRB
{
    partial class Form1
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
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblDie1id = new System.Windows.Forms.Label();
            this.lblDie2id = new System.Windows.Forms.Label();
            this.lblDie2 = new System.Windows.Forms.Label();
            this.lblDie1 = new System.Windows.Forms.Label();
            this.lblBalanceid = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBetid = new System.Windows.Forms.Label();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.lblOutcomeid = new System.Windows.Forms.Label();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.picGoodLuck = new System.Windows.Forms.PictureBox();
            this.picDie2 = new System.Windows.Forms.PictureBox();
            this.picDie1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGoodLuck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(570, 221);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(120, 40);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "ROLL DICE";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblDie1id
            // 
            this.lblDie1id.AutoSize = true;
            this.lblDie1id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDie1id.Location = new System.Drawing.Point(118, 94);
            this.lblDie1id.Name = "lblDie1id";
            this.lblDie1id.Size = new System.Drawing.Size(135, 24);
            this.lblDie1id.TabIndex = 1;
            this.lblDie1id.Text = "First Die Roll:";
            // 
            // lblDie2id
            // 
            this.lblDie2id.AutoSize = true;
            this.lblDie2id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDie2id.Location = new System.Drawing.Point(88, 215);
            this.lblDie2id.Name = "lblDie2id";
            this.lblDie2id.Size = new System.Drawing.Size(167, 24);
            this.lblDie2id.TabIndex = 2;
            this.lblDie2id.Text = "Second Die Roll:";
            // 
            // lblDie2
            // 
            this.lblDie2.AutoSize = true;
            this.lblDie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDie2.Location = new System.Drawing.Point(261, 218);
            this.lblDie2.Name = "lblDie2";
            this.lblDie2.Size = new System.Drawing.Size(37, 20);
            this.lblDie2.TabIndex = 4;
            this.lblDie2.Text = "       ";
            // 
            // lblDie1
            // 
            this.lblDie1.AutoSize = true;
            this.lblDie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDie1.Location = new System.Drawing.Point(261, 97);
            this.lblDie1.Name = "lblDie1";
            this.lblDie1.Size = new System.Drawing.Size(37, 20);
            this.lblDie1.TabIndex = 5;
            this.lblDie1.Text = "       ";
            // 
            // lblBalanceid
            // 
            this.lblBalanceid.AutoSize = true;
            this.lblBalanceid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceid.Location = new System.Drawing.Point(60, 290);
            this.lblBalanceid.Name = "lblBalanceid";
            this.lblBalanceid.Size = new System.Drawing.Size(193, 24);
            this.lblBalanceid.TabIndex = 6;
            this.lblBalanceid.Text = "Your Bank Balance:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(261, 291);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(75, 24);
            this.lblBalance.TabIndex = 7;
            this.lblBalance.Text = "$100.00";
            // 
            // lblBetid
            // 
            this.lblBetid.AutoSize = true;
            this.lblBetid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetid.Location = new System.Drawing.Point(101, 331);
            this.lblBetid.Name = "lblBetid";
            this.lblBetid.Size = new System.Drawing.Size(152, 24);
            this.lblBetid.TabIndex = 8;
            this.lblBetid.Text = "Enter Your Bet:";
            // 
            // txtBet
            // 
            this.txtBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBet.Location = new System.Drawing.Point(264, 332);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(100, 20);
            this.txtBet.TabIndex = 9;
            this.txtBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOutcomeid
            // 
            this.lblOutcomeid.AutoSize = true;
            this.lblOutcomeid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutcomeid.Location = new System.Drawing.Point(465, 332);
            this.lblOutcomeid.Name = "lblOutcomeid";
            this.lblOutcomeid.Size = new System.Drawing.Size(135, 24);
            this.lblOutcomeid.TabIndex = 10;
            this.lblOutcomeid.Text = "Game Result:";
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutcome.Location = new System.Drawing.Point(607, 335);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(89, 20);
            this.lblOutcome.TabIndex = 11;
            this.lblOutcome.Text = "OUTCOME";
            // 
            // picGoodLuck
            // 
            this.picGoodLuck.Image = global::CS311_Project2v2_SRB.Properties.Resources.GoodLuck;
            this.picGoodLuck.Location = new System.Drawing.Point(522, 36);
            this.picGoodLuck.Name = "picGoodLuck";
            this.picGoodLuck.Size = new System.Drawing.Size(205, 161);
            this.picGoodLuck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGoodLuck.TabIndex = 14;
            this.picGoodLuck.TabStop = false;
            // 
            // picDie2
            // 
            this.picDie2.Image = global::CS311_Project2v2_SRB.Properties.Resources.Die0;
            this.picDie2.Location = new System.Drawing.Point(316, 179);
            this.picDie2.Name = "picDie2";
            this.picDie2.Size = new System.Drawing.Size(121, 95);
            this.picDie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDie2.TabIndex = 13;
            this.picDie2.TabStop = false;
            // 
            // picDie1
            // 
            this.picDie1.Image = global::CS311_Project2v2_SRB.Properties.Resources.Die0;
            this.picDie1.Location = new System.Drawing.Point(317, 63);
            this.picDie1.Name = "picDie1";
            this.picDie1.Size = new System.Drawing.Size(121, 94);
            this.picDie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDie1.TabIndex = 12;
            this.picDie1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.picGoodLuck);
            this.Controls.Add(this.picDie2);
            this.Controls.Add(this.picDie1);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.lblOutcomeid);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.lblBetid);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblBalanceid);
            this.Controls.Add(this.lblDie1);
            this.Controls.Add(this.lblDie2);
            this.Controls.Add(this.lblDie2id);
            this.Controls.Add(this.lblDie1id);
            this.Controls.Add(this.btnRoll);
            this.Name = "Form1";
            this.Text = "Craps";
            ((System.ComponentModel.ISupportInitialize)(this.picGoodLuck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lblDie1id;
        private System.Windows.Forms.Label lblDie2id;
        private System.Windows.Forms.Label lblDie2;
        private System.Windows.Forms.Label lblDie1;
        private System.Windows.Forms.Label lblBalanceid;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBetid;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Label lblOutcomeid;
        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.PictureBox picDie1;
        private System.Windows.Forms.PictureBox picDie2;
        private System.Windows.Forms.PictureBox picGoodLuck;
    }
}

