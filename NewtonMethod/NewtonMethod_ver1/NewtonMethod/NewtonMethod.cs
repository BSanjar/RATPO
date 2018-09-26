using parserDecimal.Parser;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;


namespace NewtonMethod
{
    class NewtonMethod
    {
        public decimal x_result { get; set; }
        public decimal f_result { get; set; }
        public decimal df_result { get; set; }
        public decimal l_result { get; set; }
        public decimal iter_result { get; set; }
        public int time_result { get; set; }
        public decimal tol_result { get; set; }
        public int message_result { get; set; }
        
        Computer f_parser;
        Derivative df_parser;
        public decimal Fx(string F, decimal v)
        {
            f_parser = new Computer();
            return f_parser.Compute(F, v);      
        }
        public string Fd(string F)
        {
            df_parser = new Derivative();
            return df_parser.ReturnDerivative(F);
        }

        public void Calculate(ComboBox func_text, TextBox x_text, TextBox tol_text, TextBox maxiter_text, TextBox maxtime_text, ProgressBar pb,TextBox Der)
        {
            Stopwatch stopwatch = new Stopwatch();
            int iter;
            string FD_text;
            decimal x, xn;
            decimal f, fd;

            



            int cond=0; //cond=1: Остановка по времени, cond=2; Остановка по итерации, cond=3: Решения найдена с заданной точностью, cond=4: деление на ноль

            x = Convert.ToDecimal(x_text.Text);
            string F_text = func_text.Text;
            decimal Tol = Decimal.Parse(tol_text.Text, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint); ;
            int max_iter = Convert.ToInt16(maxiter_text.Text);
            int max_iter2 = max_iter;
            int max_time = Convert.ToInt16(maxtime_text.Text);
            int max_time2 = max_time;

            stopwatch.Start();
            pb.Value = 0;
         
            FD_text = Fd(F_text);

            decimal h;
           
            iter = 0;

            decimal fx0 = Fx(F_text, x);
            decimal dfx0 = Fx(FD_text, x);
            int qnd;
            decimal dp=0,dp0=0;
            decimal x1;
            decimal R=10;
            decimal fx1, dfx1;
            decimal delta = Tol;
            decimal RelError = 0;
            do
            {
                iter++;
                pb.Value++;


                if (Math.Abs(dfx0) <= Tol)
                {
                    cond = 1;
                    qnd = 0;
                }
                else
                    dp = (fx0 / dfx0);
                if (iter == 1)
                    dp0 = dp;
                if (Math.Sign(dp0) == Math.Sign(dp))
                {
                    x1 = x - dp;
                }
                else
                    x1 = x - dp / R;
                dp0 = dp;
                fx1 = Fx(F_text, x1);
                dfx1 = Fx(FD_text, x1);
                RelError = 2 * Math.Abs(dp) / (Math.Abs(x1) + Tol);

                if (RelError < delta)
                {
                    if (cond != 1)
                    {
                        cond = 2;
                    }
                }
                x = x1;
                dfx0 = dfx1;


                    //if (max_time <= Convert.ToInt16(stopwatch.ElapsedMilliseconds) && (xn - x) > Tol) //Проверка на время
                    //{
                    //    stopwatch.Stop();
                    //    DialogResult dr = MessageBox.Show("Время вышло. Продолжить вычисление? Будет добавлено " + max_time2 + " миллисекунд", "Продолжить вычисления?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //    if (dr == DialogResult.No)
                    //    {
                    //        cond = 1;
                    //    }
                    //    else if (dr == DialogResult.Yes)
                    //    {
                    //        max_time += max_time2;
                    //        maxtime_text.Text = max_time.ToString();
                    //        stopwatch.Start();
                    //    }
                    //}

                    //if (iter >= max_iter && (xn - x) > Tol) //проверка на итерацию
                    //{
                    //    stopwatch.Stop();
                    //    DialogResult dr = MessageBox.Show("Указанная точность за " + iter + " итераций не достигнута.Продолжить вычисление ? Будет добавлено " + max_iter + " итераций.", "Продолжить вычисления ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //    if (dr == DialogResult.No)
                    //    {
                    //        cond = 2;
                    //    }
                    //    else if (dr == DialogResult.Yes)
                    //    {
                    //        max_iter = max_iter + max_iter2;
                    //        pb.Maximum = max_iter + 1;
                    //        maxiter_text.Text = (max_iter).ToString();
                    //        stopwatch.Start();
                    //    }
                    //}
                    //if ((xn - x) <= Tol)  //Проверка на точность
                    //    cond = 3;
                
                
            } while (cond==0);

            stopwatch.Stop();
            x_result = x;
            message_result = cond;
            Der.Text = FD_text;
            f_result = Fx(F_text, x);
            df_result = Fx(FD_text, x);
            tol_result = /*xn - x;*/ RelError;
            iter_result = iter;
            time_result = Convert.ToInt16(stopwatch.ElapsedMilliseconds);
            
            pb.Value = pb.Maximum;
            pb.Visible = false;
        }
    }
}
