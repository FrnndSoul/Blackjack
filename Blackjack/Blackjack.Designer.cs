namespace Blackjack
{
    partial class Blackjack
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
            Deal = new Button();
            Hit = new Button();
            Pass = new Button();
            BetBox = new TextBox();
            BalanceBox = new TextBox();
            label1 = new Label();
            DealerHand_1 = new PictureBox();
            DealerHand_2 = new PictureBox();
            DealerHand_3 = new PictureBox();
            PlayerHand_3 = new PictureBox();
            PlayerHand_2 = new PictureBox();
            PlayerHand_1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)DealerHand_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DealerHand_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DealerHand_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerHand_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerHand_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerHand_1).BeginInit();
            SuspendLayout();
            // 
            // Deal
            // 
            Deal.Location = new Point(128, 392);
            Deal.Name = "Deal";
            Deal.Size = new Size(96, 29);
            Deal.TabIndex = 0;
            Deal.Text = "Deal";
            Deal.UseVisualStyleBackColor = true;
            Deal.Click += Deal_Click;
            // 
            // Hit
            // 
            Hit.Location = new Point(154, 301);
            Hit.Name = "Hit";
            Hit.Size = new Size(94, 29);
            Hit.TabIndex = 3;
            Hit.Text = "Hit";
            Hit.UseVisualStyleBackColor = true;
            Hit.Click += Hit_Click;
            // 
            // Pass
            // 
            Pass.Location = new Point(254, 301);
            Pass.Name = "Pass";
            Pass.Size = new Size(94, 29);
            Pass.TabIndex = 4;
            Pass.Text = "Pass";
            Pass.UseVisualStyleBackColor = true;
            Pass.Click += Pass_Click;
            // 
            // BetBox
            // 
            BetBox.Location = new Point(230, 394);
            BetBox.Name = "BetBox";
            BetBox.Size = new Size(214, 27);
            BetBox.TabIndex = 5;
            // 
            // BalanceBox
            // 
            BalanceBox.Location = new Point(230, 357);
            BalanceBox.Name = "BalanceBox";
            BalanceBox.Size = new Size(214, 27);
            BalanceBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 360);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 8;
            label1.Text = "Balance: ";
            label1.Click += label1_Click;
            // 
            // DealerHand_1
            // 
            DealerHand_1.Location = new Point(156, 31);
            DealerHand_1.Name = "DealerHand_1";
            DealerHand_1.Size = new Size(92, 116);
            DealerHand_1.SizeMode = PictureBoxSizeMode.StretchImage;
            DealerHand_1.TabIndex = 9;
            DealerHand_1.TabStop = false;
            DealerHand_1.Click += DealerHand_1_Click;
            // 
            // DealerHand_2
            // 
            DealerHand_2.Location = new Point(254, 31);
            DealerHand_2.Name = "DealerHand_2";
            DealerHand_2.Size = new Size(92, 116);
            DealerHand_2.SizeMode = PictureBoxSizeMode.StretchImage;
            DealerHand_2.TabIndex = 10;
            DealerHand_2.TabStop = false;
            DealerHand_2.Click += DealerHand_2_Click;
            // 
            // DealerHand_3
            // 
            DealerHand_3.Location = new Point(352, 31);
            DealerHand_3.Name = "DealerHand_3";
            DealerHand_3.Size = new Size(92, 116);
            DealerHand_3.SizeMode = PictureBoxSizeMode.StretchImage;
            DealerHand_3.TabIndex = 11;
            DealerHand_3.TabStop = false;
            DealerHand_3.Click += DealerHand_3_Click;
            // 
            // PlayerHand_3
            // 
            PlayerHand_3.Location = new Point(352, 179);
            PlayerHand_3.Name = "PlayerHand_3";
            PlayerHand_3.Size = new Size(92, 116);
            PlayerHand_3.SizeMode = PictureBoxSizeMode.StretchImage;
            PlayerHand_3.TabIndex = 14;
            PlayerHand_3.TabStop = false;
            // 
            // PlayerHand_2
            // 
            PlayerHand_2.Location = new Point(254, 179);
            PlayerHand_2.Name = "PlayerHand_2";
            PlayerHand_2.Size = new Size(92, 116);
            PlayerHand_2.SizeMode = PictureBoxSizeMode.StretchImage;
            PlayerHand_2.TabIndex = 13;
            PlayerHand_2.TabStop = false;
            // 
            // PlayerHand_1
            // 
            PlayerHand_1.Location = new Point(156, 179);
            PlayerHand_1.Name = "PlayerHand_1";
            PlayerHand_1.Size = new Size(92, 116);
            PlayerHand_1.SizeMode = PictureBoxSizeMode.StretchImage;
            PlayerHand_1.TabIndex = 12;
            PlayerHand_1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 31);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 15;
            label2.Text = "Dealer's Hand";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 179);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 16;
            label3.Text = "Your Hand: ";
            // 
            // Blackjack
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PlayerHand_3);
            Controls.Add(PlayerHand_2);
            Controls.Add(PlayerHand_1);
            Controls.Add(DealerHand_3);
            Controls.Add(DealerHand_2);
            Controls.Add(DealerHand_1);
            Controls.Add(label1);
            Controls.Add(BalanceBox);
            Controls.Add(BetBox);
            Controls.Add(Pass);
            Controls.Add(Hit);
            Controls.Add(Deal);
            Name = "Blackjack";
            Text = "Blackjack";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DealerHand_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DealerHand_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)DealerHand_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerHand_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerHand_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerHand_1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Deal;
        private Button Hit;
        private Button Pass;
        private TextBox BetBox;
        private TextBox BalanceBox;
        private Label label1;
        private PictureBox DealerHand_1;
        private PictureBox DealerHand_2;
        private PictureBox DealerHand_3;
        private PictureBox PlayerHand_3;
        private PictureBox PlayerHand_2;
        private PictureBox PlayerHand_1;
        private Label label2;
        private Label label3;
    }
}