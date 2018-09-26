
using parserDecimal.Parser;
using System;
using System.Windows.Forms;
using System.Globalization;
using info.lundin.math;

namespace BisectionMethod
{
    class BisectionMethod
    {
        

        public static System.Timers.Timer tm;

        ExpressionParser parser;
        public double x_result { get; set; }
        public double f_result { get; set; }
        public double l_result { get; set; }
        public double r_result { get; set; }
        public double iter_result { get; set; }
        public double time_result { get; set; }
        public double tol_result { get; set; }

        public int elapsedtime;
        public int time_val;

        public double fx(string F, double v)
        {
            parser = new ExpressionParser();
            double vv = Convert.ToDouble(v);
            parser.Values.Add("x",vv);

            return Convert.ToDouble(parser.Parse(F));
            
        }
        public double Bisection_algo(TextBox funct,  TextBox L_text, TextBox R_text, TextBox tol, TextBox k_max, TextBox maxt_time, ProgressBar pb)
        {
            int iter;
            string F;
            double l;
            double r;
            double Tol;
            
            decimal x;

            l = Convert.ToDouble(L_text.Text);
            r = Convert.ToDouble(R_text.Text);
            Tol = Double.Parse(tol.Text, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint);
            iter = Convert.ToInt32(k_max.Text);
            F = funct.Text;
            // x = Decimal.Parse(X_text.Text);
            double fa;
            double fb;
            double fm;
            double m; //Что это
            int max_iter = Convert.ToInt16(k_max.Text);
            int max_iter2 = max_iter;
            int max_time = Convert.ToInt16(maxt_time.Text);
            int max_time2 = max_time;

            tm = new System.Timers.Timer(15);
            tm.AutoReset = true;

            tm.Elapsed += Tm_Elapsed;
            tm.Start();
            pb.Value = 1;
            fa = fx(F, l);
            fb = fx(F, r);

            if (Math.Sign(fa) == Math.Sign(fb))
            {
                MessageBox.Show("Выбранны неправильные границы для вычисления! проверьте границы 'a' и 'b'");
               
            }
            else
            {
                iter = 0;
                while ((r - l) > Tol) //проверка на точность
                {
                    if (iter >= max_iter) //проверка на итерацию
                    {
                        tm.Stop();
                        DialogResult dr = MessageBox.Show("Указанная точность за " + iter + " итераций не достигнута.Продолжить вычисление ? Будет добавлено " + max_iter + " итераций.", "Продолжить вычисления ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(dr == DialogResult.No)
                        {
                            time_val = 0;
                            break;
                            
                        }
                        else if (dr == DialogResult.Yes)
                        {
                            max_iter = max_iter + max_iter2;
                            pb.Maximum = max_iter + 1;
                            tm.Start();
                        }
                    }
                    if (time_val >= max_time)
                    {
                        tm.Stop();
                        DialogResult dr = MessageBox.Show("Время вышло. Продолжить вычисление? Будет добавлено " + max_time2 + " миллисекунд", "Продолжить вычисления?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.No)
                        {
                            time_val = 0;
                            break;
                        }
                        else if(dr == DialogResult.Yes)
                        {
                            max_time += max_time2;
                            tm.Start();
                        }
                    }
                    m = l + (r - l) / 2;
                    fa = fx(F,l);
                    fm = fx(F, m);
                    if (Math.Sign(fa) == Math.Sign(fm))
                    {
                        l = m;
                        pb.Value++;
                    }
                    else
                    {
                        r = m;
                        pb.Value += 1;
                    }
                    iter++;
                }
                f_result = fx(F,l);
                l_result = l;
                r_result = r;
                pb.Value = pb.Maximum;
                pb.Visible = false;
                tm.Stop();
                tm.Dispose();
                time_result = elapsedtime;
                iter_result = iter;
                time_val = 0;     
            }



            return l; 
        }

        private void Tm_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            time_val += 15;
            elapsedtime = time_val;
        }
    }
}
