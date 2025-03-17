namespace WinFormsApp1
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
            sideA = new TextBox();
            sideB = new TextBox();
            sideC = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            message1 = new Label();
            message2 = new Label();
            btnClear = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // sideA
            // 
            sideA.Location = new Point(117, 135);
            sideA.Margin = new Padding(3, 4, 3, 4);
            sideA.Name = "sideA";
            sideA.Size = new Size(114, 27);
            sideA.TabIndex = 0;
            // 
            // sideB
            // 
            sideB.Location = new Point(117, 175);
            sideB.Margin = new Padding(3, 4, 3, 4);
            sideB.Name = "sideB";
            sideB.Size = new Size(114, 27);
            sideB.TabIndex = 1;
            // 
            // sideC
            // 
            sideC.Location = new Point(117, 213);
            sideC.Margin = new Padding(3, 4, 3, 4);
            sideC.Name = "sideC";
            sideC.Size = new Size(114, 27);
            sideC.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 99);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 3;
            label1.Text = "Enter 3 double value.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 138);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 4;
            label2.Text = "- 1-st side";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 178);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 5;
            label3.Text = "- 2-nd side";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 213);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 6;
            label4.Text = "- 3-rd side";
            // 
            // button1
            // 
            button1.Location = new Point(31, 263);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(214, 36);
            button1.TabIndex = 3;
            button1.Text = "Check";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 30);
            label5.Name = "label5";
            label5.Size = new Size(407, 20);
            label5.TabIndex = 8;
            label5.Text = "Task: Given real positive numbers a, b, c. If there is a triangle ";
            // 
            // message1
            // 
            message1.AutoSize = true;
            message1.Location = new Point(290, 145);
            message1.Name = "message1";
            message1.Size = new Size(0, 20);
            message1.TabIndex = 9;
            // 
            // message2
            // 
            message2.AutoSize = true;
            message2.Location = new Point(293, 182);
            message2.Name = "message2";
            message2.Size = new Size(0, 20);
            message2.TabIndex = 10;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(30, 323);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(215, 34);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 59);
            label6.Name = "label6";
            label6.Size = new Size(398, 20);
            label6.TabIndex = 12;
            label6.Text = "with sides a, b, c, then determine whether it is right-angled.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 376);
            Controls.Add(label6);
            Controls.Add(btnClear);
            Controls.Add(message2);
            Controls.Add(message1);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(sideC);
            Controls.Add(sideB);
            Controls.Add(sideA);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Task \"Triangle\"";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox sideA;
        private TextBox sideB;
        private TextBox sideC;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
        private Label message1;
        private Label message2;
        private Button btnClear;
        private Label label6;
    }
}