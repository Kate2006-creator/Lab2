namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxInput.Text = Properties.Settings.Default.LastInput;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string sentence = textBoxInput.Text;
            double percentage = Logic.Count(sentence);

            labelResultValue.Text = $"{percentage:F2}%";


            Properties.Settings.Default.LastInput = sentence;
            Properties.Settings.Default.Save();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = "";
            labelResultText.Text = "";
            labelResultValue.Text = "";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ActiveControl == textBoxInput) { buttonCalculate.Focus(); }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }


    public class Logic
    {
        public static double Count(string sentence)
        {
            int letterCount = 0;
            int totalCharsWithoutSpaces = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                char currentChar = sentence[i];

                if (char.IsLetter(currentChar))
                {
                    letterCount++;
                    totalCharsWithoutSpaces++;
                }
                else if (!char.IsWhiteSpace(currentChar))
                {
                    totalCharsWithoutSpaces++;
                }
            }

            if (totalCharsWithoutSpaces > 0)
            {
                return (double)letterCount / totalCharsWithoutSpaces * 100;
            }
            else
            {
                return 0;
            }
        }
    }
}
