namespace RatingApp
{
    partial class UserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.ratingPanel = new System.Windows.Forms.Panel();
            this.oneStarBar = new System.Windows.Forms.ProgressBar();
            this.twoStarBar = new System.Windows.Forms.ProgressBar();
            this.threeStarBar = new System.Windows.Forms.ProgressBar();
            this.fourStarBar = new System.Windows.Forms.ProgressBar();
            this.fiveStarBar = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.TitlePanel.SuspendLayout();
            this.mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TitlePanel.Controls.Add(this.Title);
            this.TitlePanel.Location = new System.Drawing.Point(649, 0);
            this.TitlePanel.Margin = new System.Windows.Forms.Padding(4);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(417, 66);
            this.TitlePanel.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Title.Font = new System.Drawing.Font("Lucida Bright", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Blue;
            this.Title.Location = new System.Drawing.Point(101, 15);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(217, 38);
            this.Title.TabIndex = 0;
            this.Title.Text = "Rating App";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(114, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vote this picture";
            // 
            // mainpanel
            // 
            this.mainpanel.Controls.Add(this.resetButton);
            this.mainpanel.Controls.Add(this.ratingPanel);
            this.mainpanel.Controls.Add(this.oneStarBar);
            this.mainpanel.Controls.Add(this.twoStarBar);
            this.mainpanel.Controls.Add(this.threeStarBar);
            this.mainpanel.Controls.Add(this.fourStarBar);
            this.mainpanel.Controls.Add(this.fiveStarBar);
            this.mainpanel.Controls.Add(this.label7);
            this.mainpanel.Controls.Add(this.label6);
            this.mainpanel.Controls.Add(this.label5);
            this.mainpanel.Controls.Add(this.label4);
            this.mainpanel.Controls.Add(this.label3);
            this.mainpanel.Controls.Add(this.label2);
            this.mainpanel.Location = new System.Drawing.Point(649, 73);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(416, 477);
            this.mainpanel.TabIndex = 3;
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.resetButton.Location = new System.Drawing.Point(155, 409);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(119, 40);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset Data";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // ratingPanel
            // 
            this.ratingPanel.AutoSize = true;
            this.ratingPanel.Location = new System.Drawing.Point(86, 124);
            this.ratingPanel.Name = "ratingPanel";
            this.ratingPanel.Size = new System.Drawing.Size(232, 40);
            this.ratingPanel.TabIndex = 6;
            // 
            // oneStarBar
            // 
            this.oneStarBar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.oneStarBar.Location = new System.Drawing.Point(111, 364);
            this.oneStarBar.Name = "oneStarBar";
            this.oneStarBar.Size = new System.Drawing.Size(250, 10);
            this.oneStarBar.TabIndex = 5;
            // 
            // twoStarBar
            // 
            this.twoStarBar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.twoStarBar.Location = new System.Drawing.Point(111, 334);
            this.twoStarBar.Name = "twoStarBar";
            this.twoStarBar.Size = new System.Drawing.Size(250, 10);
            this.twoStarBar.TabIndex = 5;
            // 
            // threeStarBar
            // 
            this.threeStarBar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.threeStarBar.Location = new System.Drawing.Point(111, 304);
            this.threeStarBar.Name = "threeStarBar";
            this.threeStarBar.Size = new System.Drawing.Size(250, 10);
            this.threeStarBar.TabIndex = 5;
            // 
            // fourStarBar
            // 
            this.fourStarBar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.fourStarBar.Location = new System.Drawing.Point(111, 274);
            this.fourStarBar.Name = "fourStarBar";
            this.fourStarBar.Size = new System.Drawing.Size(250, 10);
            this.fourStarBar.TabIndex = 5;
            // 
            // fiveStarBar
            // 
            this.fiveStarBar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.fiveStarBar.Location = new System.Drawing.Point(111, 244);
            this.fiveStarBar.Name = "fiveStarBar";
            this.fiveStarBar.Size = new System.Drawing.Size(250, 10);
            this.fiveStarBar.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "1 star";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "2 stars";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "3 stars";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "4 stars";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "5 stars";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox.BackgroundImage = global::RatingApp.Properties.Resources.Zeno;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.ErrorImage = null;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(641, 550);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 550);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.TitlePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserInterface";
            this.Text = "Rating ";
            this.TitlePanel.ResumeLayout(false);
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ProgressBar oneStarBar;
        private System.Windows.Forms.ProgressBar twoStarBar;
        private System.Windows.Forms.ProgressBar threeStarBar;
        private System.Windows.Forms.ProgressBar fourStarBar;
        private System.Windows.Forms.ProgressBar fiveStarBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel ratingPanel;
        private System.Windows.Forms.Button resetButton;
    }
}

