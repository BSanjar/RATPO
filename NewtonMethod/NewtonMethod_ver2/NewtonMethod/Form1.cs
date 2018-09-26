using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace NewtonMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Solve_button_Click(object sender, EventArgs e)
        {
            Message_label.Text = "";
            if (Function_ComboBox.Text == "" || A_TextBox.Text == "" || Tolerance_TextBox.Text == "" || MAXIteration_TextBox.Text == "" || MAXTime_TextBox.Text == "")
            {
                MessageBox.Show("Не все данные введены!");
            }
            else
            {
                try
                {
                    decimal tol1;
                    decimal x_result;
                    decimal f_result;
                    decimal iter_result;
                    decimal time_result;
                    decimal tol_result;
                    decimal der_result;
                    int error;
                    PB_ProgressBar.Visible = true;
                    PB_ProgressBar.Maximum = Convert.ToInt32(MAXIteration_TextBox.Text) + 1;

                    NewtonMethod method = new NewtonMethod();
                    x_result = method.Calculate(Function_ComboBox, A_TextBox, Tolerance_TextBox, MAXIteration_TextBox, MAXTime_TextBox, PB_ProgressBar, Derivative_text);
                    tol1 = Decimal.Parse(Tolerance_TextBox.Text, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint);

                    f_result = method.f_result;
                    iter_result = method.iter_result;
                    time_result = method.time_result;
                    tol_result = method.tol_result;
                    der_result = method.df_result;
                    error = method.cond_result;

                    ResultX_TextBox.Text = x_result.ToString();
                    ResultFunction_TextBox.Text = f_result.ToString();
                    DerivativeFunction_TextBox.Text = der_result.ToString();
                    ResultIteration_TextBox.Text = iter_result.ToString();
                    ABS_TextBox.Text = tol_result.ToString("0e0");                    
                    ResultTime_TextBox.Text = time_result.ToString();

                if (iter_result == 0)
                {
                    Message_label.Visible = true;
                    Message_label.ForeColor = Color.Red;
                    Message_label.Text = "Ошибка";
                }
                else
                {
                    if (error == 4)
                    {
                        Message_label.Visible = true;
                        Message_label.ForeColor = Color.Red;
                        Message_label.Text = "Ошибка";
                    }
                    else if (error == 1)
                    {
                        Message_label.Visible = true;
                        Message_label.ForeColor = Color.Red;
                        Message_label.Text = "Результат с заданной точностью не достигнут \n из за лимита времени!";
                    }
                    else if (error == 2)
                    {
                        Message_label.Visible = true;
                        Message_label.ForeColor = Color.Red;
                        Message_label.Text = "Результат с заданной точностью не достигнут \n из за лимита итерации!";
                    }
                    else
                    { 
                        Message_label.Visible = true;
                        Message_label.ForeColor = Color.Green;
                        Message_label.Text = "Результат с заданной точностью достигнут !";
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message + "Неверно введены начальные значения!");
                PB_ProgressBar.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Неверно введена функция!");
                PB_ProgressBar.Visible = false;
            }
                PB_ProgressBar.Maximum = Convert.ToInt32(MAXIteration_TextBox.Text);
            }
           
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            Message_label.Text = "";
            ResultX_TextBox.Text = "";
            ResultFunction_TextBox.Text = "";
            DerivativeFunction_TextBox.Text = "";
            ResultTime_TextBox.Text = "";
            ResultIteration_TextBox.Text = "";
            ABS_TextBox.Text = "";
            Derivative_text.Text = "";
        }

        private void A_TextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                if (A_TextBox.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (e.KeyChar == '-')
            {
                if (A_TextBox.Text.IndexOf('-') != -1)
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

        private void Tolerance_TextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                if (Tolerance_TextBox.Text.IndexOf(',') != -1)
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

        private void MAXIteration_TextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void MAXTime_TextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
