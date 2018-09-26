using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace BisectionMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            label13.Text = "";
            label12.Text = "";
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (textBox2.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (e.KeyChar == '-')
            {
                if (textBox2.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            e.Handled = true;
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (textBox3.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            e.Handled = true;
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == 'e')
            {
                return;
            }
            if (e.KeyChar == '-')
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (textBox4.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            e.Handled = true;
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            e.Handled = true;
        }
        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label12.Text = "";
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox11.Text == "")
            {
                MessageBox.Show("Не все данные введены!");
            }
            else
            {              
                try
                {
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox10.Text = "";

                    decimal tol1;
                    decimal x_result;
                    decimal f_result;
                    decimal l_result;
                    decimal r_result;
                    decimal iter_result;
                    decimal time_result;
                    decimal tol_result;
                    progressBar1.Visible = true;
                    progressBar1.Maximum = Convert.ToInt32(textBox5.Text) + 1;

                    BisectionMethod method = new BisectionMethod();
                    x_result = method.Bisection_algo(textBox1, textBox2, textBox3, textBox4, textBox5, textBox11, progressBar1);

                    tol1 =  Decimal.Parse(textBox4.Text, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint);
                    f_result = method.f_result;
                    l_result = method.l_result;
                    r_result = method.r_result;
                    iter_result = method.iter_result;
                    time_result = method.time_result;
                    tol_result = r_result - l_result;

                    textBox10.Text = x_result.ToString();
                    textBox9.Text = f_result.ToString();
                    textBox8.Text = time_result.ToString();
                    textBox7.Text = iter_result.ToString();
                    textBox6.Text = tol_result.ToString("0e0");
                    //textBox12.Text = tol_result.ToString();


                    if (iter_result == 0)
                    {
                        label13.Visible = true;
                        label12.ForeColor = Color.Red;
                        label12.Text = "Ошибка";
                    }
                    else
                    {
                        if (tol_result > tol1)
                        {
                            label13.Visible = true;
                            label12.ForeColor = Color.Red;
                            label12.Text = "Результат с заданной точностью не достигнут!";
                        }
                        else
                        {
                            label13.Visible = true;
                            label12.ForeColor = Color.Green;
                            label12.Text = "Результат с заданной точностью достигнут!";
                        }
                    }
                }
                
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message + "Неверно введены начальные значения!");
                    progressBar1.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Неверно введена функция!");
                    progressBar1.Visible = false;
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
