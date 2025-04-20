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
        }

        string message = "";
        private bool CheckFraction2(Fraction fraction1, Fraction fraction2)
        {

            if (!fraction1.IsValidDenominator() || !fraction2.IsValidDenominator())
            {
                message = "ОШИБКА! Знаменатель = 0!! Введите снова!";
                return false; // Возвращаем false, если проверка не прошла
            }
            if (!fraction1.IsValid() || !fraction2.IsValid())
            {
                message = "Ошибка: Числитель должен быть меньше знаменателя. Попробуйте ввести дроби ещё раз.";
                return false; // Возвращаем false, если проверка не прошла
            }

            return true; // Возвращаем true, если все проверки прошли
        }

        private bool CheckFraction1(Fraction fraction1)
        {

            if (!fraction1.IsValidDenominator())
            {
                message = "ОШИБКА! Знаменатель = 0!! Введите снова!";
                return false; // Возвращаем false, если проверка не прошла
            }
            if (!fraction1.IsValid())
            {
                message = "Ошибка: Числитель должен быть меньше знаменателя. Попробуйте ввести дроби ещё раз.";
                return false; // Возвращаем false, если проверка не прошла
            }

            return true; // Возвращаем true, если все проверки прошли
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Fraction fraction1 = GetFraction(textBoxNum1, textBoxDen1);
            Fraction fraction2 = GetFraction(textBoxNum2, textBoxDen2);

            if (!CheckFraction2(fraction1, fraction2))
            { 
                labelResult1.Text = message;
                return;
            }

            Fraction result = fraction1 + fraction2; 
                textBoxResultNum.Text = result.Numerator.ToString();
                textBoxResultDen.Text = result.Denominator.ToString();
                labelResult1.Text = "";
        }


        private void buttonReduce_Click(object sender, EventArgs e)
        {
            Fraction fraction1 = GetFraction(textBoxNum1, textBoxDen1);

            if (!CheckFraction1(fraction1))
            {
                labelResult1.Text = message;
                return;
            }

            Fraction result = Fraction.Reduce(fraction1);
                textBoxResultNum.Text = result.Numerator.ToString();
                textBoxResultDen.Text = result.Denominator.ToString();

        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            Fraction fraction1 = GetFraction(textBoxNum1, textBoxDen1);
            Fraction fraction2 = GetFraction(textBoxNum2, textBoxDen2);

            if (!CheckFraction2(fraction1, fraction2))
            {
                string message = "";
                labelResult1.Text = message;
                return;
            }

            if (fraction1 < fraction2)
            {
                labelResult1.Text = "fraction1 < fraction2";
            }
            else if (fraction1 > fraction2)
            {
                labelResult1.Text = "fraction1 > fraction2";
            }
            else
            {
                labelResult1.Text = "fraction1 = fraction2";
            }
        }


        private void buttonDivide_Click(object sender, EventArgs e)
        {
            Fraction fraction1 = GetFraction(textBoxNum1, textBoxDen1);
            Fraction fraction2 = GetFraction(textBoxNum2, textBoxDen2);

            if (!CheckFraction2(fraction1, fraction2))
            {
                string message = "";
                labelResult1.Text = message;
                return;
            }

            try { 
            Fraction result = fraction1 / fraction2;
                textBoxResultNum.Text = result.Numerator.ToString();
                textBoxResultDen.Text = result.Denominator.ToString();
                labelResult1.Text = "";
            } catch(DivideByZeroException ex)
            {
                labelResult1.Text = "Ошибка: Числитель 2-ой дроби не может быть равен 0.";
                return;
            }
            catch(NullReferenceException ex)
            {
                labelResult1.Text = "Ошибка: Числитель 2-ой дроби не может быть равен 0.";
                return;
            }
            }
            


        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            Fraction fraction1 = GetFraction(textBoxNum1, textBoxDen1);
            Fraction fraction2 = GetFraction(textBoxNum2, textBoxDen2);

            if (!CheckFraction2(fraction1, fraction2))
            {
                labelResult1.Text = message;
                return;
            }

            Fraction result = fraction1 * fraction2;
            textBoxResultNum.Text = result.Numerator.ToString();
            textBoxResultDen.Text = result.Denominator.ToString();
            labelResult1.Text = "";
        }

        private void buttonSubtract_Click_1(object sender, EventArgs e)
        {
            Fraction fraction1 = GetFraction(textBoxNum1, textBoxDen1);
            Fraction fraction2 = GetFraction(textBoxNum2, textBoxDen2);

            if (!CheckFraction2(fraction1, fraction2))
            {
                labelResult1.Text = message;
                return;
            }

            Fraction result = fraction1 - fraction2;
            textBoxResultNum.Text = result.Numerator.ToString();
            textBoxResultDen.Text = result.Denominator.ToString();
            labelResult1.Text = "";
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            textBoxNum1.Text = "";
            textBoxDen1.Text = "";
            textBoxNum2.Text = "";
            textBoxDen2.Text = "";
            textBoxResultNum.Text = "";
            textBoxResultDen.Text = "";
            labelResult1.Text = "";
            labelResult2.Text = "";
        }


        private void textBoxNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; 
                textBoxDen1.Focus(); 
            }
        }

        private void textBoxDen1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                textBoxNum2.Focus();
            }
        }

        private void textBoxNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                textBoxDen2.Focus();
            }
        }

        private void textBoxDen2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDen2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                buttonAdd.Focus();
            }
        }

        private Fraction GetFraction(TextBox numTextBox, TextBox denTextBox)
        {
            try
            {
                int num = int.Parse(numTextBox.Text);
                int den = int.Parse(denTextBox.Text);
                return new Fraction(num, den);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка: Введите целые числа.");
                return new Fraction(0, 1);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
  
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    
       
    }
}

