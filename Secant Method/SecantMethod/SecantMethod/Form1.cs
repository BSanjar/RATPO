using System;
using System.Drawing;
using System.Windows.Forms;

namespace SecantMethod
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
            if (Function_ComboBox.Text == "" || x0_TextBox.Text == "" || x1_TextBox.Text == "" || Tolerance_TextBox.Text == "" || MAXIteration_TextBox.Text == "" || MAXTime_TextBox.Text == "")
            {
                MessageBox.Show("Не все данные введены!");
            }
            else
            {
                try
                {
                    decimal tol;
                    decimal x_result;
                    decimal f_result;
                    int iter_result;
                    long time_result;
                    decimal tol_result;
                    int cond;
                    PB_ProgressBar.Visible = true;
                    PB_ProgressBar.Maximum = Convert.ToInt32(MAXIteration_TextBox.Text) + 1;

                    SecantMethod method = new SecantMethod();
                     method.FindX(Function_ComboBox, x0_TextBox, x1_TextBox, Tolerance_TextBox, MAXIteration_TextBox, MAXTime_TextBox, PB_ProgressBar);

                    x_result = method.x_result;
                    f_result = method.f_result;
                    iter_result = method.iter_result;
                    time_result = method.time_result;
                    tol_result = method.tol_result;
                   

                    ResultX_TextBox.Text = x_result.ToString();
                    ResultFunction_TextBox.Text = f_result.ToString();
                    ResultIteration_TextBox.Text = iter_result.ToString();
                    ResultTime_TextBox.Text = time_result.ToString();
                    ABS_TextBox.Text = tol_result.ToString("0e0");

                    //switch (cond)
                    //{
                    //    case 1:
                    //        Message_label.Visible = true;
                    //        Message_label.ForeColor = Color.Red;
                    //        Message_label.Text = "Результат с заданной точностью не найден! \n из за лимита итерации";
                    //        break;
                    //    case 2:                          

                    //        Message_label.Visible = true;
                    //        Message_label.ForeColor = Color.Red;
                    //        Message_label.Text = "Результат с заданной точностью не найден! \n из за лимита времени";
                    //        break;
                    //    case 3:
                    //        Message_label.Visible = true;
                    //        Message_label.ForeColor = Color.Green;
                    //        Message_label.Text = "Результат с заданной точностью найден!";
                    //        break;
                    //    default:
                    //        Message_label.Visible = true;
                    //        Message_label.ForeColor = Color.Red;
                    //        Message_label.Text = "Ошибка";
                    //        break;
                    //}
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message + "Неверно введены начальные значения!");
                    PB_ProgressBar.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "Неизвестная функция!");
                    PB_ProgressBar.Visible = false;
                }
                
            }
            PB_ProgressBar.Maximum = Convert.ToInt32(MAXIteration_TextBox.Text);
        }

        private void x0_TextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                if (x0_TextBox.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (e.KeyChar == '-')
            {
                if (x0_TextBox.Text.IndexOf('-') != -1)
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

        private void x1_TextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                if (x1_TextBox.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (e.KeyChar == '-')
            {
                if (x1_TextBox.Text.IndexOf('-') != -1)
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

        private void Clear_button_Click(object sender, EventArgs e)
        {
            Message_label.Text = "";
            ResultX_TextBox.Text = "";
            ResultFunction_TextBox.Text = "";
           
            ResultTime_TextBox.Text = "";
            ResultIteration_TextBox.Text = "";
            ABS_TextBox.Text = "";
           
        }
    }
}
