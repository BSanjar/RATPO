using parserDecimal.Parser;
using System;
using System.Windows.Forms;
using System.Globalization;
using System.Diagnostics;

namespace BisectionMethod
{
    class BisectionMethod
    {
        Computer parser;
        public decimal x_result { get; set; }
        public decimal f_result { get; set; }
        public decimal l_result { get; set; }
        public decimal r_result { get; set; }
        public decimal iter_result { get; set; }
        public int time_result { get; set; }
        public decimal tol_result { get; set; }
        
        Stopwatch stopwatch = new Stopwatch();
        public decimal fx(string F,decimal v)
        {
            parser = new Computer();
            return parser.Compute(F, v);
        }
        public decimal Bisection_algo(TextBox funct,  TextBox L_text, TextBox R_text, TextBox tol, TextBox k_max, TextBox maxt_time, ProgressBar pb)
        {
            int iter;
            string F;
            decimal a;
            decimal b;
            decimal Tol;
            
            a = Convert.ToDecimal(L_text.Text);
            b = Convert.ToDecimal(R_text.Text);
            Tol = Decimal.Parse(tol.Text, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint);
            iter = Convert.ToInt32(k_max.Text);
            F = funct.Text;
            decimal fa;
            decimal fb,fd;
            decimal fm;
            decimal m=0; 
            int max_iter = Convert.ToInt16(k_max.Text);
            int max_iter2 = max_iter;
            int max_time = Convert.ToInt16(maxt_time.Text);
            int max_time2 = max_time;
            decimal tol2;
            stopwatch.Start();
            pb.Value = 1;
            fa = fx(F, a);
            fb = fx(F, b);

            if (Math.Sign(fa) == Math.Sign(fb))
            {
                MessageBox.Show("Выбранны неправильные границы для вычисления! проверьте границы 'a' и 'b'");               
            }
            else
            {
                
                iter = 0;
                while (Math.Abs(b-a)> Tol) //проверка на точность
                {                 
                    if (iter >= max_iter) //проверка на итерацию
                    {
                        stopwatch.Stop();
                        DialogResult dr = MessageBox.Show("Указанная точность за " + iter + " итераций не достигнута.Продолжить вычисление ? Будет добавлено " + max_iter + " итераций.", "Продолжить вычисления ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(dr == DialogResult.No)
                        {                         
                            break;                           
                        }
                        else if (dr == DialogResult.Yes)
                        {
                            max_iter = max_iter + max_iter2;
                            pb.Maximum = max_iter + 1;
                            k_max.Text = (max_iter).ToString();
                            stopwatch.Start();
                        }
                    }
                   
                    //if (max_time<=Convert.ToInt16(stopwatch.ElapsedMilliseconds))
                    //{
                    //    stopwatch.Stop();        
                    //    DialogResult dr = MessageBox.Show("Время вышло. Продолжить вычисление? Будет добавлено " + max_time2 + " миллисекунд", "Продолжить вычисления?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //    if (dr == DialogResult.No)
                    //    {
                    //        break;
                    //    }
                    //    else if(dr == DialogResult.Yes)
                    //    {
                    //        max_time += max_time2;
                    //        maxt_time.Text = max_time.ToString();
                    //        stopwatch.Start();
                    //    }
                    //}

                    //m = l + (r - l) / 2;
                    fa = fx(F,a);
                    fb = fx(F,b);

                    if (fa == 0)
                    {
                        a = b;
                        break;
                    }
                    if (fb == 0)
                    {
                        break;
                    }
                    //c = a + ((-yx1) / (-yx1 + yx2)) * (b - a)
                    m = a + ((-fa) / (fa - fb)) * (b - a);
                    fm = fx(F, m);
                    if (Math.Sign(fa) == Math.Sign(fm))
                    {
                        a = m;
                        pb.Value++;
                    }
                    else
                    {
                        b = m;
                        pb.Value += 1;
                    }
                    iter++;
                    tol2 = (b - a);
                }
                f_result = fx(F,a);
                l_result = a;
                r_result = b;
                pb.Value = pb.Maximum;
                pb.Visible = false;                
                stopwatch.Stop();
                time_result = Convert.ToInt16(stopwatch.ElapsedMilliseconds);
                iter_result = iter;                  
            }
            return a; 
        }      
    }
}
