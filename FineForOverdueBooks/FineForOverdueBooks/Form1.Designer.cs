namespace FineForOverdueBooks
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
            lblTitle = new Label();
            lblNumBooks = new Label();
            txtNumBooks = new TextBox();
            lblNumDays = new Label();
            txtNumDays = new TextBox();
            btnCalculate = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(348, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Overdue Book Calculator";
            // 
            // lblNumBooks
            // 
            lblNumBooks.AutoSize = true;
            lblNumBooks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumBooks.Location = new Point(12, 91);
            lblNumBooks.Name = "lblNumBooks";
            lblNumBooks.Size = new Size(170, 56);
            lblNumBooks.TabIndex = 1;
            lblNumBooks.Text = "Number of Books \r\nChecked out:";
            // 
            // txtNumBooks
            // 
            txtNumBooks.BackColor = SystemColors.InactiveCaption;
            txtNumBooks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumBooks.ForeColor = Color.Black;
            txtNumBooks.Location = new Point(156, 120);
            txtNumBooks.Name = "txtNumBooks";
            txtNumBooks.Size = new Size(141, 34);
            txtNumBooks.TabIndex = 2;
            // 
            // lblNumDays
            // 
            lblNumDays.AutoSize = true;
            lblNumDays.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumDays.Location = new Point(12, 185);
            lblNumDays.Name = "lblNumDays";
            lblNumDays.Size = new Size(138, 56);
            lblNumDays.TabIndex = 3;
            lblNumDays.Text = "Number of \r\nDays Overdue:";
            // 
            // txtNumDays
            // 
            txtNumDays.BackColor = SystemColors.InactiveCaption;
            txtNumDays.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumDays.Location = new Point(156, 214);
            txtNumDays.Name = "txtNumDays";
            txtNumDays.Size = new Size(141, 34);
            txtNumDays.TabIndex = 4;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = SystemColors.HotTrack;
            btnCalculate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(104, 281);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(152, 50);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(12, 397);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(60, 23);
            lblResult.TabIndex = 6;
            lblResult.Text = "Result:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 488);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(txtNumDays);
            Controls.Add(lblNumDays);
            Controls.Add(txtNumBooks);
            Controls.Add(lblNumBooks);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblNumBooks;
        private TextBox txtNumBooks;
        private Label lblNumDays;
        private TextBox txtNumDays;
        private Button btnCalculate;
        private Label lblResult;
    }
}
