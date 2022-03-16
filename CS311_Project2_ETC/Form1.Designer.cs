namespace CS311_Project2_ETC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBank = new System.Windows.Forms.Label();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblRollNumber = new System.Windows.Forms.Label();
            this.lblBankTitle = new System.Windows.Forms.Label();
            this.lblDie2Title = new System.Windows.Forms.Label();
            this.lblDie1Title = new System.Windows.Forms.Label();
            this.picDie1 = new System.Windows.Forms.PictureBox();
            this.picDie2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBank.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBank.Location = new System.Drawing.Point(521, 87);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(156, 44);
            this.lblBank.TabIndex = 2;
            this.lblBank.Text = "$100.00";
            // 
            // txtBet
            // 
            this.txtBet.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBet.Location = new System.Drawing.Point(91, 256);
            this.txtBet.Name = "txtBet";
            this.txtBet.PlaceholderText = "Enter Your Bet Here!";
            this.txtBet.Size = new System.Drawing.Size(375, 51);
            this.txtBet.TabIndex = 3;
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRoll.Location = new System.Drawing.Point(521, 261);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(170, 46);
            this.btnRoll.TabIndex = 4;
            this.btnRoll.Text = "ROLL";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(58, 363);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 28);
            this.lblResult.TabIndex = 5;
            // 
            // lblRollNumber
            // 
            this.lblRollNumber.AutoSize = true;
            this.lblRollNumber.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRollNumber.Location = new System.Drawing.Point(521, 217);
            this.lblRollNumber.Name = "lblRollNumber";
            this.lblRollNumber.Size = new System.Drawing.Size(0, 28);
            this.lblRollNumber.TabIndex = 6;
            // 
            // lblBankTitle
            // 
            this.lblBankTitle.AutoSize = true;
            this.lblBankTitle.Font = new System.Drawing.Font("Century Schoolbook", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBankTitle.Location = new System.Drawing.Point(552, 131);
            this.lblBankTitle.Name = "lblBankTitle";
            this.lblBankTitle.Size = new System.Drawing.Size(92, 34);
            this.lblBankTitle.TabIndex = 7;
            this.lblBankTitle.Text = "Bank";
            // 
            // lblDie2Title
            // 
            this.lblDie2Title.AutoSize = true;
            this.lblDie2Title.Font = new System.Drawing.Font("Century Schoolbook", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDie2Title.Location = new System.Drawing.Point(290, 131);
            this.lblDie2Title.Name = "lblDie2Title";
            this.lblDie2Title.Size = new System.Drawing.Size(88, 34);
            this.lblDie2Title.TabIndex = 8;
            this.lblDie2Title.Text = "Die 2";
            // 
            // lblDie1Title
            // 
            this.lblDie1Title.AutoSize = true;
            this.lblDie1Title.Font = new System.Drawing.Font("Century Schoolbook", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDie1Title.Location = new System.Drawing.Point(100, 131);
            this.lblDie1Title.Name = "lblDie1Title";
            this.lblDie1Title.Size = new System.Drawing.Size(88, 34);
            this.lblDie1Title.TabIndex = 9;
            this.lblDie1Title.Text = "Die 1";
            // 
            // picDie1
            // 
            this.picDie1.Location = new System.Drawing.Point(91, 23);
            this.picDie1.Name = "picDie1";
            this.picDie1.Size = new System.Drawing.Size(106, 105);
            this.picDie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDie1.TabIndex = 10;
            this.picDie1.TabStop = false;
            // 
            // picDie2
            // 
            this.picDie2.Location = new System.Drawing.Point(290, 26);
            this.picDie2.Name = "picDie2";
            this.picDie2.Size = new System.Drawing.Size(106, 105);
            this.picDie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDie2.TabIndex = 11;
            this.picDie2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picDie2);
            this.Controls.Add(this.picDie1);
            this.Controls.Add(this.lblDie1Title);
            this.Controls.Add(this.lblDie2Title);
            this.Controls.Add(this.lblBankTitle);
            this.Controls.Add(this.lblRollNumber);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.lblBank);
            this.Name = "Form1";
            this.Text = "Craps";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblBank;
        private TextBox txtBet;
        private Button btnRoll;
        private Label lblResult;
        private Label lblRollNumber;
        private Label lblBankTitle;
        private Label lblDie2Title;
        private Label lblDie1Title;
        private PictureBox picDie1;
        private PictureBox picDie2;
    }
}