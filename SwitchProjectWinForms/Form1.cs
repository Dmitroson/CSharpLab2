using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchProjectWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            panelStartChoise.Visible = false;
            panelDay.Location = panelStartChoise.Location;
            panelDay.Visible = true;
            linkLabelGo_Back.Visible = true;
            linkLabelEXIT2.Visible = true;
            
        }
        private void ButtonDayIdentify_Click(object sender, EventArgs e)
        {
            int Day;
            if(int.TryParse(textBoxDay.Text, out Day) == false)
            {
                MessageBox.Show("Ошибка ввода!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                switch (Day)
                {
                    case 1: labelDayResult.Text = "Понедельник"; labelDayResult.Visible = true; break;
                    case 2: labelDayResult.Text = "Вторник"; labelDayResult.Visible = true; break;
                    case 3: labelDayResult.Text = "Среда"; labelDayResult.Visible = true; break;
                    case 4: labelDayResult.Text = "Четверг"; labelDayResult.Visible = true; break;
                    case 5: labelDayResult.Text = "Пятница"; labelDayResult.Visible = true; break;
                    case 6: labelDayResult.Text = "Суббота"; labelDayResult.Visible = true; break;
                    case 7: labelDayResult.Text = "Воскресенье"; labelDayResult.Visible = true; break;
                    default: MessageBox.Show("Ошибка ввода!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                }
            }
        }
        private void Mounth_Click(object sender, EventArgs e)
        {
            panelStartChoise.Visible = false;
            panelMonth.Location = panelStartChoise.Location;
            panelMonth.Visible = true;
            linkLabelGo_Back.Visible = true;
            linkLabelEXIT2.Visible = true;
        }
        private void ButtonMounthIdentify_Click(object sender, EventArgs e)
        {
            int Month;
            if (int.TryParse(textBoxMonth.Text, out Month) == false)
            {
                MessageBox.Show("Ошибка ввода!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                switch (Month)
                {
                    case 1: labelMonthResult.Text = "Январь"; labelMonthResult.Visible = true; break;
                    case 2: labelMonthResult.Text = "Февраль"; labelMonthResult.Visible = true; break;
                    case 3: labelMonthResult.Text = "Март"; labelMonthResult.Visible = true; break;
                    case 4: labelMonthResult.Text = "Апрель"; labelMonthResult.Visible = true; break;
                    case 5: labelMonthResult.Text = "Май"; labelMonthResult.Visible = true; break;
                    case 6: labelMonthResult.Text = "Июнь"; labelMonthResult.Visible = true; break;
                    case 7: labelMonthResult.Text = "Июль"; labelMonthResult.Visible = true; break;
                    case 8: labelMonthResult.Text = "Август"; labelMonthResult.Visible = true; break;
                    case 9: labelMonthResult.Text = "Сентябрь"; labelMonthResult.Visible = true; break;
                    case 10: labelMonthResult.Text = "Октябрь"; labelMonthResult.Visible = true; break;
                    case 11: labelMonthResult.Text = "Ноябрь"; labelMonthResult.Visible = true; break;
                    case 12: labelMonthResult.Text = "Декабрь"; labelMonthResult.Visible = true; break;
                    default: MessageBox.Show("Ошибка ввода!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                }
            }
        }
        private void Operations_Click(object sender, EventArgs e)
        {
            panelStartChoise.Visible = false;
            panelOperations.Visible = true;
            panelOperations.Location = panelStartChoise.Location;
            linkLabelGo_Back.Visible = true;
            linkLabelEXIT2.Visible = true;
        }
        private void Button1_Click_1(object sender, EventArgs e)
        {
            double A, B;
            if (double.TryParse(textBoxA.Text, out A) == false || double.TryParse(textBoxB.Text, out B) == false)
            {
                MessageBox.Show("Ошибка ввода!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textBoxOperation.Text == "+" || textBoxOperation.Text == "-" || textBoxOperation.Text == "*" || textBoxOperation.Text == "/")
                {
                    double result;
                    labelResult.Visible = true;
                    switch (textBoxOperation.Text)
                    {
                        case "+": result = A + B; labelResult.Text = result.ToString(); break;
                        case "-": result = A - B; labelResult.Text = result.ToString(); break;
                        case "*": result = A * B; labelResult.Text = result.ToString(); break;
                        case "/": result = A / B; labelResult.Text = result.ToString(); break;
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка ввода!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LinkLabelGoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelStartChoise.Visible = true;
            panelDay.Visible = false;
            panelMonth.Visible = false;
            panelOperations.Visible = false;
            linkLabelGo_Back.Visible = false;
            linkLabelEXIT2.Visible = false;
        }
       private void LinkLabelEXIT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           this.Close();
        }
        private void EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void LabelDayResult_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxMounth_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LinkLabelGo_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelStartChoise.Visible = true;
            panelDay.Visible = false;
            panelMonth.Visible = false;
            panelOperations.Visible = false;
            linkLabelGo_Back.Visible = false;
            linkLabelEXIT2.Visible = false;
        }

        private void LinkLabelEXIT2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
