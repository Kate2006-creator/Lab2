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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxNum1 = new TextBox();
            textBoxDen1 = new TextBox();
            textBoxNum2 = new TextBox();
            textBoxDen2 = new TextBox();
            textBoxResultNum = new TextBox();
            textBoxResultDen = new TextBox();
            label5 = new Label();
            label10 = new Label();
            label11 = new Label();
            buttonAdd = new Button();
            buttonSubtract = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            buttonReduce = new Button();
            buttonCompare = new Button();
            labelResult1 = new Label();
            clearButton = new Button();
            labelResult2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(381, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите 2 правильные дроби и выберите операцию:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Fraction1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 79);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "Fraction2:";
            // 
            // textBoxNum1
            // 
            textBoxNum1.Location = new Point(91, 62);
            textBoxNum1.Name = "textBoxNum1";
            textBoxNum1.Size = new Size(47, 27);
            textBoxNum1.TabIndex = 3;
            textBoxNum1.KeyPress += textBoxNum1_KeyPress;
            // 
            // textBoxDen1
            // 
            textBoxDen1.Location = new Point(91, 100);
            textBoxDen1.Name = "textBoxDen1";
            textBoxDen1.Size = new Size(47, 27);
            textBoxDen1.TabIndex = 4;
            textBoxDen1.KeyPress += textBoxDen1_KeyPress;
            // 
            // textBoxNum2
            // 
            textBoxNum2.Location = new Point(252, 62);
            textBoxNum2.Name = "textBoxNum2";
            textBoxNum2.Size = new Size(52, 27);
            textBoxNum2.TabIndex = 6;
            textBoxNum2.KeyPress += textBoxNum2_KeyPress;
            // 
            // textBoxDen2
            // 
            textBoxDen2.Location = new Point(252, 100);
            textBoxDen2.Name = "textBoxDen2";
            textBoxDen2.Size = new Size(50, 27);
            textBoxDen2.TabIndex = 7;
            textBoxDen2.TextChanged += textBoxDen2_TextChanged;
            textBoxDen2.KeyPress += textBoxDen2_KeyPress;
            // 
            // textBoxResultNum
            // 
            textBoxResultNum.Location = new Point(416, 62);
            textBoxResultNum.Name = "textBoxResultNum";
            textBoxResultNum.ReadOnly = true;
            textBoxResultNum.Size = new Size(60, 27);
            textBoxResultNum.TabIndex = 8;
            // 
            // textBoxResultDen
            // 
            textBoxResultDen.Location = new Point(416, 100);
            textBoxResultDen.Name = "textBoxResultDen";
            textBoxResultDen.ReadOnly = true;
            textBoxResultDen.Size = new Size(60, 27);
            textBoxResultDen.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(361, 79);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 10;
            label5.Text = "Result";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(361, 163);
            label10.Name = "label10";
            label10.Size = new Size(258, 20);
            label10.TabIndex = 15;
            label10.Text = "*Сокращается только первая дробь";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(361, 204);
            label11.Name = "label11";
            label11.Size = new Size(213, 20);
            label11.TabIndex = 16;
            label11.Text = "Результат сравнения дробей:";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(51, 163);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(87, 37);
            buttonAdd.TabIndex = 17;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSubtract
            // 
            buttonSubtract.Location = new Point(155, 163);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(83, 37);
            buttonSubtract.TabIndex = 18;
            buttonSubtract.Text = "-";
            buttonSubtract.UseVisualStyleBackColor = true;
            buttonSubtract.Click += buttonSubtract_Click_1;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(252, 163);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(84, 37);
            buttonMultiply.TabIndex = 19;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Location = new Point(51, 216);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(87, 34);
            buttonDivide.TabIndex = 20;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += buttonDivide_Click;
            // 
            // buttonReduce
            // 
            buttonReduce.Location = new Point(155, 216);
            buttonReduce.Name = "buttonReduce";
            buttonReduce.Size = new Size(82, 34);
            buttonReduce.TabIndex = 21;
            buttonReduce.Text = "Reduce";
            buttonReduce.UseVisualStyleBackColor = true;
            buttonReduce.Click += buttonReduce_Click;
            // 
            // buttonCompare
            // 
            buttonCompare.Location = new Point(252, 216);
            buttonCompare.Name = "buttonCompare";
            buttonCompare.Size = new Size(84, 34);
            buttonCompare.TabIndex = 22;
            buttonCompare.Text = "Compare";
            buttonCompare.UseVisualStyleBackColor = true;
            buttonCompare.Click += buttonCompare_Click;
            // 
            // labelResult1
            // 
            labelResult1.AutoSize = true;
            labelResult1.Location = new Point(369, 230);
            labelResult1.Name = "labelResult1";
            labelResult1.Size = new Size(0, 20);
            labelResult1.TabIndex = 23;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(51, 265);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(285, 46);
            clearButton.TabIndex = 25;
            clearButton.Text = "Clear ALL";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // labelResult2
            // 
            labelResult2.AutoSize = true;
            labelResult2.Location = new Point(370, 265);
            labelResult2.Name = "labelResult2";
            labelResult2.Size = new Size(0, 20);
            labelResult2.TabIndex = 26;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 332);
            Controls.Add(labelResult2);
            Controls.Add(clearButton);
            Controls.Add(labelResult1);
            Controls.Add(buttonCompare);
            Controls.Add(buttonReduce);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonSubtract);
            Controls.Add(buttonAdd);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(textBoxResultDen);
            Controls.Add(textBoxResultNum);
            Controls.Add(textBoxDen2);
            Controls.Add(textBoxNum2);
            Controls.Add(textBoxDen1);
            Controls.Add(textBoxNum1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Калькулятор дробей";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxNum1;
        private TextBox textBoxDen1;
        private TextBox textBoxNum2;
        private TextBox textBoxDen2;
        private TextBox textBoxResultNum;
        private TextBox textBoxResultDen;
        private Label label5;
        private Label label10;
        private Label label11;
        private Button buttonAdd;
        private Button buttonSubtract;
        private Button buttonMultiply;
        private Button buttonDivide;
        private Button buttonReduce;
        private Button buttonCompare;
        private Label labelResult1;
        private Button clearButton;
        private Label labelResult2;
    }
}
