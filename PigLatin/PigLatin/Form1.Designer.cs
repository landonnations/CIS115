namespace PigLatin
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
            inputWord = new TextBox();
            outputText = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 79);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 0;
            label1.Text = "Insert Word Here";
            // 
            // inputWord
            // 
            inputWord.Location = new Point(246, 76);
            inputWord.Name = "inputWord";
            inputWord.Size = new Size(476, 27);
            inputWord.TabIndex = 1;
            // 
            // outputText
            // 
            outputText.AutoSize = true;
            outputText.Location = new Point(246, 141);
            outputText.Name = "outputText";
            outputText.Size = new Size(0, 20);
            outputText.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 141);
            label2.Name = "label2";
            label2.Size = new Size(166, 20);
            label2.TabIndex = 3;
            label2.Text = "That word in PigLatin is:";
            // 
            // button1
            // 
            button1.Location = new Point(333, 274);
            button1.Name = "button1";
            button1.Size = new Size(129, 39);
            button1.TabIndex = 4;
            button1.Text = "Go";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(outputText);
            Controls.Add(inputWord);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputWord;
        private Label outputText;
        private Label label2;
        private Button button1;
    }
}
