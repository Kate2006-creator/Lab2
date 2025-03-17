namespace WinFormsApp2
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
            buttonCalculate = new Button();
            textBoxInput = new TextBox();
            labelInput = new Label();
            labelResultText = new Label();
            labelResultValue = new Label();
            btn_clear = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(180, 156);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(205, 29);
            buttonCalculate.TabIndex = 0;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(180, 63);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(466, 27);
            textBoxInput.TabIndex = 1;
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Location = new Point(33, 66);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(141, 20);
            labelInput.TabIndex = 2;
            labelInput.Text = "Enter your sentence:";
            // 
            // labelResultText
            // 
            labelResultText.AutoSize = true;
            labelResultText.Location = new Point(26, 115);
            labelResultText.Name = "labelResultText";
            labelResultText.Size = new Size(148, 20);
            labelResultText.TabIndex = 3;
            labelResultText.Text = "Percentage of letters:";
            // 
            // labelResultValue
            // 
            labelResultValue.AutoSize = true;
            labelResultValue.Location = new Point(213, 115);
            labelResultValue.Name = "labelResultValue";
            labelResultValue.Size = new Size(0, 20);
            labelResultValue.TabIndex = 4;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(422, 156);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(224, 29);
            btn_clear.TabIndex = 5;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 18);
            label1.Name = "label1";
            label1.Size = new Size(435, 20);
            label1.TabIndex = 6;
            label1.Text = "Given a sentence. Determine the proportion (in %) of letters in it.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 232);
            Controls.Add(label1);
            Controls.Add(btn_clear);
            Controls.Add(labelResultValue);
            Controls.Add(labelResultText);
            Controls.Add(labelInput);
            Controls.Add(textBoxInput);
            Controls.Add(buttonCalculate);
            KeyPreview = true;
            Name = "Form1";
            Text = "Task \"Sentence\"";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCalculate;
        private TextBox textBoxInput;
        private Label labelInput;
        private Label labelResultText;
        private Label labelResultValue;
        private Button btn_clear;
        private Label label1;
    }
}
