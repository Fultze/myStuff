namespace DungeonCrawl1_Fultze
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
            this.exitButton = new System.Windows.Forms.Button();
            this.playerActionsListBox = new System.Windows.Forms.ListBox();
            this.playerGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.playerHPLabel = new System.Windows.Forms.Label();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.creature1HPLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.creature2HPLabel = new System.Windows.Forms.Label();
            this.backgroundLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.playerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitButton.Location = new System.Drawing.Point(391, 795);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(140, 48);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // playerActionsListBox
            // 
            this.playerActionsListBox.FormattingEnabled = true;
            this.playerActionsListBox.ItemHeight = 25;
            this.playerActionsListBox.Items.AddRange(new object[] {
            "Attack Foe1",
            "Attack Foe2",
            "Use Item",
            "Run",
            "Adavance"});
            this.playerActionsListBox.Location = new System.Drawing.Point(288, 115);
            this.playerActionsListBox.Margin = new System.Windows.Forms.Padding(6);
            this.playerActionsListBox.Name = "playerActionsListBox";
            this.playerActionsListBox.Size = new System.Drawing.Size(196, 229);
            this.playerActionsListBox.TabIndex = 1;
            this.playerActionsListBox.SelectedIndexChanged += new System.EventHandler(this.playerActionsListBox_SelectedIndexChanged);
            // 
            // playerGroupBox
            // 
            this.playerGroupBox.Controls.Add(this.pictureBox3);
            this.playerGroupBox.Controls.Add(this.enterButton);
            this.playerGroupBox.Controls.Add(this.playerHPLabel);
            this.playerGroupBox.Controls.Add(this.playerNameLabel);
            this.playerGroupBox.Controls.Add(this.playerActionsListBox);
            this.playerGroupBox.Location = new System.Drawing.Point(458, 94);
            this.playerGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.playerGroupBox.Name = "playerGroupBox";
            this.playerGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.playerGroupBox.Size = new System.Drawing.Size(500, 435);
            this.playerGroupBox.TabIndex = 2;
            this.playerGroupBox.TabStop = false;
            this.playerGroupBox.Text = "playerName";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(12, 115);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(244, 231);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(179, 360);
            this.enterButton.Margin = new System.Windows.Forms.Padding(6);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(150, 44);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "ENTER";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.playerAttackButton_Click);
            // 
            // playerHPLabel
            // 
            this.playerHPLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerHPLabel.Location = new System.Drawing.Point(224, 37);
            this.playerHPLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.playerHPLabel.Name = "playerHPLabel";
            this.playerHPLabel.Size = new System.Drawing.Size(168, 42);
            this.playerHPLabel.TabIndex = 2;
            this.playerHPLabel.Text = "playerHPLabel";
            this.playerHPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(46, 65);
            this.playerNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(127, 25);
            this.playerNameLabel.TabIndex = 2;
            this.playerNameLabel.Text = "playerName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "label1";
            // 
            // creature1HPLabel
            // 
            this.creature1HPLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.creature1HPLabel.Location = new System.Drawing.Point(190, 117);
            this.creature1HPLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.creature1HPLabel.Name = "creature1HPLabel";
            this.creature1HPLabel.Size = new System.Drawing.Size(168, 42);
            this.creature1HPLabel.TabIndex = 2;
            this.creature1HPLabel.Text = "creatureHPLabel";
            this.creature1HPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.creature1HPLabel);
            this.groupBox1.Location = new System.Drawing.Point(46, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(400, 192);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 144);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomNameLabel.Location = new System.Drawing.Point(328, 17);
            this.roomNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(306, 42);
            this.roomNameLabel.TabIndex = 2;
            this.roomNameLabel.Text = "Room Name Label";
            this.roomNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.creature2HPLabel);
            this.groupBox2.Location = new System.Drawing.Point(46, 337);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(400, 192);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 37);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 144);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "label1";
            // 
            // creature2HPLabel
            // 
            this.creature2HPLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.creature2HPLabel.Location = new System.Drawing.Point(190, 117);
            this.creature2HPLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.creature2HPLabel.Name = "creature2HPLabel";
            this.creature2HPLabel.Size = new System.Drawing.Size(168, 42);
            this.creature2HPLabel.TabIndex = 2;
            this.creature2HPLabel.Text = "creatureHPLabel";
            this.creature2HPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundLabel
            // 
            this.backgroundLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backgroundLabel.Location = new System.Drawing.Point(15, 591);
            this.backgroundLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.backgroundLabel.Name = "backgroundLabel";
            this.backgroundLabel.Size = new System.Drawing.Size(910, 183);
            this.backgroundLabel.TabIndex = 2;
            this.backgroundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textBox1.Location = new System.Drawing.Point(80, 913);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(912, 218);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1031, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 69);
            this.button1.TabIndex = 5;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1573, 1099);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.backgroundLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.roomNameLabel);
            this.Controls.Add(this.playerGroupBox);
            this.Controls.Add(this.exitButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Dungeon Crawl I";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.playerGroupBox.ResumeLayout(false);
            this.playerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox playerActionsListBox;
        private System.Windows.Forms.GroupBox playerGroupBox;
        private System.Windows.Forms.Label playerHPLabel;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label creature1HPLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label creature2HPLabel;
        private System.Windows.Forms.Label backgroundLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

