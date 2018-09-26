using parserDecimal.Parser;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;

namespace SecantMethod
{
    class SecantMethod
    {
        Computer parser;
        public decimal x_result { get; set; }
        public decimal f_result { get; set; }
        public int iter_result { get; set; }
        public long time_result { get; set; }
        public decimal tol_result { get; set; }

        Stopwatch stopwatch = new Stopwatch();

        public decimal fx(string F, decimal v)
        {
            parser = new Computer();
            return parser.Compute(F, v);
        }

        public decimal FindX(ComboBox f_text, TextBox x0_text, TextBox x1_text, TextBox tol_text, TextBox max_iter_text, TextBox max_time_text, ProgressBar pb)
        {
            int iter = 0;
            int max_iter = 0;
            int max_time = 0;
            decimal x0 = 0;
            decimal x1 = 0;
            decimal f = 0;
            decimal tol = 0;
            decimal m = 0;
            string func;

            max_iter = Convert.ToInt32(max_iter_text.Text);
            max_time = Convert.ToInt32(max_time_text.Text);
            x0 = Decimal.Parse(x0_text.Text);
            x1 = Decimal.Parse(x1_text.Text);
            tol = Decimal.Parse(tol_text.Text, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint);
            func = Convert.ToString(f_text.Text);

            int max_iter2 = max_iter;
            int max_time2 = max_time;
            int cond = 0;
            stopwatch.Start();
            pb.Value = 1;

            decimal fx0,fx1,fm;

           

            while (Math.Abs(x0 - x1) > tol)
            {
                          
                    if (iter >= max_iter) //проверка на итерацию
                    {
                        stopwatch.Stop();
                        DialogResult dr = MessageBox.Show("Указанная точность за " + iter + " итераций не достигнута.Продолжить вычисление ? Будет добавлено " + max_iter + " итераций.", "Продолжить вычисления ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.No)
                        {
                            break;
                        }
                        else if (dr == DialogResult.Yes)
                        {
                            max_iter = max_iter + max_iter2;
                            pb.Maximum = max_iter + 1;
                            max_iter_text.Text = (max_iter).ToString();
                            stopwatch.Start();
                        }
                    }

                    //if (max_time <= Convert.ToInt16(stopwatch.ElapsedMilliseconds))
                    //{
                    //    stopwatch.Stop();
                    //    DialogResult dr = MessageBox.Show("Время вышло. Продолжить вычисление? Будет добавлено " + max_time2 + " миллисекунд", "Продолжить вычисления?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //    if (dr == DialogResult.No)
                    //    {
                    //        break;
                    //    }
                    //    else if (dr == DialogResult.Yes)
                    //    {
                    //        max_time += max_time2;
                    //        max_time_text.Text = max_time.ToString();
                    //        stopwatch.Start();
                    //    }
                    //}


                

                fx0 = fx(func, x0);
                fx1 = fx(func, x1);

                if (fx1 == 0)
                {
                    fx0 = fx1;
                    break;
                }
                if (fx0 == 0)
                {
                    break;
                }

                //m = x0 + ((-fx0) / (-fx0 + fx1) * (x1 - x0));
                m = x0 + ((-fx0) / (-fx0 + fx1)) * (x1 - x0);
                //m = x0 - fx0 * (x1 - x0) / (fx1 - fx0);
                fm = fx(func, m);

                    if (Math.Sign(fx0) == Math.Sign(fm))
                    {
                        x0 = m;
                        pb.Value++;
                    }
                    else
                    {
                        x1 = m;
                        pb.Value++;
                    }
                iter++;
            }

            stopwatch.Stop();
            f_result = fx(func, x0);
            x_result = m;
            iter_result = iter;
            time_result = stopwatch.ElapsedMilliseconds;

            return m;
        }
    }
}
