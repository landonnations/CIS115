namespace PaintingEstimate4
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lengthTextBox = new TextBox();
            widthTextBox = new TextBox();
            calculateButton = new Button();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(109, 30);
            label1.Name = "label1";
            label1.Size = new Size(192, 31);
            label1.TabIndex = 0;
            label1.Text = "Painting Estimate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 134);
            label2.Name = "label2";
            label2.Size = new Size(169, 23);
            label2.TabIndex = 1;
            label2.Text = "Room Length in Feet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 192);
            label3.Name = "label3";
            label3.Size = new Size(162, 23);
            label3.TabIndex = 2;
            label3.Text = "Room Width in Feet";
            // 
            // lengthTextBox
            // 
            lengthTextBox.BackColor = Color.LightSalmon;
            lengthTextBox.ForeColor = Color.White;
            lengthTextBox.Location = new Point(198, 133);
            lengthTextBox.Name = "lengthTextBox";
            lengthTextBox.Size = new Size(125, 27);
            lengthTextBox.TabIndex = 3;
            // 
            // widthTextBox
            // 
            widthTextBox.BackColor = Color.LightSalmon;
            widthTextBox.ForeColor = Color.White;
            widthTextBox.Location = new Point(198, 192);
            widthTextBox.Name = "widthTextBox";
            widthTextBox.Size = new Size(125, 27);
            widthTextBox.TabIndex = 4;
            // 
            // calculateButton
            // 
            calculateButton.BackColor = Color.LightSalmon;
            calculateButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            calculateButton.ForeColor = Color.White;
            calculateButton.Location = new Point(136, 263);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(136, 51);
            calculateButton.TabIndex = 5;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultLabel.ForeColor = Color.White;
            resultLabel.Location = new Point(23, 385);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(63, 23);
            resultLabel.TabIndex = 6;
            resultLabel.Text = "Results";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(411, 479);
            Controls.Add(resultLabel);
            Controls.Add(calculateButton);
            Controls.Add(widthTextBox);
            Controls.Add(lengthTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Painting Estimate Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox lengthTextBox;
        private TextBox widthTextBox;
        private Button calculateButton;
        private Label resultLabel;
    }
}
