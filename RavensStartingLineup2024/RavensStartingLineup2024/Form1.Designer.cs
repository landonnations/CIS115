namespace RavensStartingLineup2024
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
            labelTitle = new Label();
            labelComboBox = new Label();
            comboBoxPositions = new ComboBox();
            buttonShowInfo = new Button();
            pictureBoxPlayers = new PictureBox();
            labelName = new Label();
            labelCollege = new Label();
            labelWeight = new Label();
            labelHeight = new Label();
            labelNumber = new Label();
            labelHometown = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayers).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Black;
            labelTitle.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.DarkViolet;
            labelTitle.Location = new Point(115, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(693, 50);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Baltimore Ravens 2024 Starters";
            // 
            // labelComboBox
            // 
            labelComboBox.AutoSize = true;
            labelComboBox.BackColor = Color.Black;
            labelComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelComboBox.ForeColor = Color.White;
            labelComboBox.Location = new Point(25, 106);
            labelComboBox.Name = "labelComboBox";
            labelComboBox.Size = new Size(143, 28);
            labelComboBox.TabIndex = 1;
            labelComboBox.Text = "Select Position:";
            // 
            // comboBoxPositions
            // 
            comboBoxPositions.BackColor = Color.Black;
            comboBoxPositions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxPositions.ForeColor = Color.White;
            comboBoxPositions.FormattingEnabled = true;
            comboBoxPositions.Location = new Point(174, 106);
            comboBoxPositions.Name = "comboBoxPositions";
            comboBoxPositions.Size = new Size(151, 36);
            comboBoxPositions.TabIndex = 2;
            // 
            // buttonShowInfo
            // 
            buttonShowInfo.BackColor = Color.Black;
            buttonShowInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonShowInfo.ForeColor = Color.DarkViolet;
            buttonShowInfo.Location = new Point(115, 164);
            buttonShowInfo.Name = "buttonShowInfo";
            buttonShowInfo.Size = new Size(128, 43);
            buttonShowInfo.TabIndex = 3;
            buttonShowInfo.Text = "See Starter";
            buttonShowInfo.UseVisualStyleBackColor = false;
            // 
            // pictureBoxPlayers
            // 
            pictureBoxPlayers.BackColor = Color.Transparent;
            pictureBoxPlayers.Location = new Point(17, 223);
            pictureBoxPlayers.Name = "pictureBoxPlayers";
            pictureBoxPlayers.Size = new Size(426, 268);
            pictureBoxPlayers.TabIndex = 4;
            pictureBoxPlayers.TabStop = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.DarkViolet;
            labelName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.Location = new Point(553, 111);
            labelName.Name = "labelName";
            labelName.Size = new Size(80, 31);
            labelName.TabIndex = 5;
            labelName.Text = "Name:";
            // 
            // labelCollege
            // 
            labelCollege.AutoSize = true;
            labelCollege.BackColor = Color.DarkViolet;
            labelCollege.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCollege.Location = new Point(553, 363);
            labelCollege.Name = "labelCollege";
            labelCollege.Size = new Size(96, 31);
            labelCollege.TabIndex = 6;
            labelCollege.Text = "College:";
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.BackColor = Color.DarkViolet;
            labelWeight.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWeight.Location = new Point(553, 301);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(92, 31);
            labelWeight.TabIndex = 7;
            labelWeight.Text = "Weight:";
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.BackColor = Color.DarkViolet;
            labelHeight.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHeight.Location = new Point(553, 239);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(88, 31);
            labelHeight.TabIndex = 8;
            labelHeight.Text = "Height:";
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.BackColor = Color.DarkViolet;
            labelNumber.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumber.Location = new Point(553, 176);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(103, 31);
            labelNumber.TabIndex = 9;
            labelNumber.Text = "Number:";
            // 
            // labelHometown
            // 
            labelHometown.AutoSize = true;
            labelHometown.BackColor = Color.DarkViolet;
            labelHometown.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHometown.Location = new Point(553, 433);
            labelHometown.Name = "labelHometown";
            labelHometown.Size = new Size(131, 31);
            labelHometown.TabIndex = 10;
            labelHometown.Text = "Hometown:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.ravens;
            ClientSize = new Size(934, 505);
            Controls.Add(labelHometown);
            Controls.Add(labelNumber);
            Controls.Add(labelHeight);
            Controls.Add(labelWeight);
            Controls.Add(labelCollege);
            Controls.Add(labelName);
            Controls.Add(pictureBoxPlayers);
            Controls.Add(buttonShowInfo);
            Controls.Add(comboBoxPositions);
            Controls.Add(labelComboBox);
            Controls.Add(labelTitle);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Baltimore Ravens Starters";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelComboBox;
        private ComboBox comboBoxPositions;
        private Button buttonShowInfo;
        private PictureBox pictureBoxPlayers;
        private Label labelName;
        private Label labelCollege;
        private Label labelWeight;
        private Label labelHeight;
        private Label labelNumber;
        private Label labelHometown;
    }
}
