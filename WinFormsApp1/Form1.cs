using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            sideA.Text = Properties.Settings.Default.a.ToString();
            sideB.Text = Properties.Settings.Default.b.ToString();
            sideC.Text = Properties.Settings.Default.c.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            double a, b, c;

            try
            {
                a = double.Parse(this.sideA.Text);
                b = double.Parse(this.sideB.Text);
                c = double.Parse(this.sideC.Text);

                // Проверка на некорректный ввод
                if (a <= 0 || b <= 0 || c <= 0)
                {
                    throw new ArgumentException("The sides of a triangle must be positive numbers.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный формат ввода. Введите числа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Properties.Settings.Default.a = a;
            Properties.Settings.Default.b = b;
            Properties.Settings.Default.c = c;
            Properties.Settings.Default.Save();

            message1.Text = $"{Logic.IsTriangle(a, b, c)}";
            message2.Text = $"{Logic.IsRightTriangle(a, b, c)}";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            sideA.Text = "";
            sideB.Text = "";
            sideC.Text = "";
            message1.Text = "";
            message2.Text = "";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ActiveControl == sideA)
                    sideB.Focus();
                else if (ActiveControl == sideB)
                    sideC.Focus();
                else if (ActiveControl == sideC)
                    button1.Focus();
                
            }
        }
    }

    public class Logic
    {
        public static string IsTriangle(double a, double b, double c)
        {
            string outMessage1 = "";
            if (a + b > c && a + c > b && b + c > a)
            {
                outMessage1 = "A triangle exists.";
            }
            else { outMessage1 = "A triangle doesn`t exist."; }
            return outMessage1;
        }
        public static string IsRightTriangle(double a, double b, double c)
        {
            string outMessage2 = "";
            if (Math.Abs(a * a + b * b - c * c) < 0.0001 ||
                    Math.Abs(a * a + c * c - b * b) < 0.0001 ||
                    Math.Abs(b * b + c * c - a * a) < 0.0001)
            {
                outMessage2 = "The triangle has 90-angle.";
            }
            else
            {
                outMessage2 = "The triangle doesn`t have 90-angle.";
            }
            return outMessage2;
        }
    }
}