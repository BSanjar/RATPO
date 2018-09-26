namespace SecantMethod
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.x1_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Message_label = new System.Windows.Forms.Label();
            this.Clear_button = new System.Windows.Forms.Button();
            this.Solve_button = new System.Windows.Forms.Button();
            this.ABS_TextBox = new System.Windows.Forms.TextBox();
            this.ResultIteration_TextBox = new System.Windows.Forms.TextBox();
            this.ResultTime_TextBox = new System.Windows.Forms.TextBox();
            this.ResultFunction_TextBox = new System.Windows.Forms.TextBox();
            this.ResultX_TextBox = new System.Windows.Forms.TextBox();
            this.ABS_label = new System.Windows.Forms.Label();
            this.ResultIteration_label = new System.Windows.Forms.Label();
            this.ResultTime_label = new System.Windows.Forms.Label();
            this.ResultFunction_label = new System.Windows.Forms.Label();
            this.ResultX_label = new System.Windows.Forms.Label();
            this.PB_ProgressBar = new System.Windows.Forms.ProgressBar();
            this.Res_label = new System.Windows.Forms.Label();
            this.Function_ComboBox = new System.Windows.Forms.ComboBox();
            this.MAXTime_TextBox = new System.Windows.Forms.TextBox();
            this.MAXIteration_TextBox = new System.Windows.Forms.TextBox();
            this.Tolerance_TextBox = new System.Windows.Forms.TextBox();
            this.x0_TextBox = new System.Windows.Forms.TextBox();
            this.MAXTime_label = new System.Windows.Forms.Label();
            this.MAXIteration_label = new System.Windows.Forms.Label();
            this.Tolerance_label = new System.Windows.Forms.Label();
            this.A_label = new System.Windows.Forms.Label();
            this.Function_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // x1_TextBox
            // 
            this.x1_TextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x1_TextBox.Location = new System.Drawing.Point(252, 89);
            this.x1_TextBox.Name = "x1_TextBox";
            this.x1_TextBox.Size = new System.Drawing.Size(100, 26);
            this.x1_TextBox.TabIndex = 178;
            this.x1_TextBox.Text = "3";
            this.x1_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x1_TextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(92, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 19);
            this.label1.TabIndex = 177;
            this.label1.Text = "X1:";
            // 
            // Message_label
            // 
            this.Message_label.AutoSize = true;
            this.Message_label.Location = new System.Drawing.Point(175, 318);
            this.Message_label.Name = "Message_label";
            this.Message_label.Size = new System.Drawing.Size(10, 13);
            this.Message_label.TabIndex = 176;
            this.Message_label.Text = ":";
            this.Message_label.Visible = false;
            // 
            // Clear_button
            // 
            this.Clear_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Clear_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Clear_button.Location = new System.Drawing.Point(369, 472);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(100, 58);
            this.Clear_button.TabIndex = 174;
            this.Clear_button.Text = "Сброс";
            this.Clear_button.UseVisualStyleBackColor = false;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // Solve_button
            // 
            this.Solve_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Solve_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Solve_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Solve_button.Location = new System.Drawing.Point(252, 242);
            this.Solve_button.Name = "Solve_button";
            this.Solve_button.Size = new System.Drawing.Size(217, 39);
            this.Solve_button.TabIndex = 173;
            this.Solve_button.Text = "Поиск";
            this.Solve_button.UseVisualStyleBackColor = false;
            this.Solve_button.Click += new System.EventHandler(this.Solve_button_Click);
            // 
            // ABS_TextBox
            // 
            this.ABS_TextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ABS_TextBox.Location = new System.Drawing.Point(252, 504);
            this.ABS_TextBox.Name = "ABS_TextBox";
            this.ABS_TextBox.ReadOnly = true;
            this.ABS_TextBox.Size = new System.Drawing.Size(100, 26);
            this.ABS_TextBox.TabIndex = 172;
            // 
            // ResultIteration_TextBox
            // 
            this.ResultIteration_TextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultIteration_TextBox.Location = new System.Drawing.Point(252, 472);
            this.ResultIteration_TextBox.Name = "ResultIteration_TextBox";
            this.ResultIteration_TextBox.ReadOnly = true;
            this.ResultIteration_TextBox.Size = new System.Drawing.Size(100, 26);
            this.ResultIteration_TextBox.TabIndex = 171;
            // 
            // ResultTime_TextBox
            // 
            this.ResultTime_TextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultTime_TextBox.Location = new System.Drawing.Point(252, 440);
            this.ResultTime_TextBox.Name = "ResultTime_TextBox";
            this.ResultTime_TextBox.ReadOnly = true;
            this.ResultTime_TextBox.Size = new System.Drawing.Size(100, 26);
            this.ResultTime_TextBox.TabIndex = 170;
            // 
            // ResultFunction_TextBox
            // 
            this.ResultFunction_TextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultFunction_TextBox.Location = new System.Drawing.Point(252, 404);
            this.ResultFunction_TextBox.Name = "ResultFunction_TextBox";
            this.ResultFunction_TextBox.ReadOnly = true;
            this.ResultFunction_TextBox.Size = new System.Drawing.Size(217, 26);
            this.ResultFunction_TextBox.TabIndex = 169;
            // 
            // ResultX_TextBox
            // 
            this.ResultX_TextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultX_TextBox.Location = new System.Drawing.Point(252, 372);
            this.ResultX_TextBox.Name = "ResultX_TextBox";
            this.ResultX_TextBox.ReadOnly = true;
            this.ResultX_TextBox.Size = new System.Drawing.Size(217, 26);
            this.ResultX_TextBox.TabIndex = 168;
            // 
            // ABS_label
            // 
            this.ABS_label.AutoSize = true;
            this.ABS_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ABS_label.Location = new System.Drawing.Point(91, 506);
            this.ABS_label.Name = "ABS_label";
            this.ABS_label.Size = new System.Drawing.Size(109, 19);
            this.ABS_label.TabIndex = 167;
            this.ABS_label.Text = "Abs (x1 - x0):";
            // 
            // ResultIteration_label
            // 
            this.ResultIteration_label.AutoSize = true;
            this.ResultIteration_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultIteration_label.Location = new System.Drawing.Point(92, 474);
            this.ResultIteration_label.Name = "ResultIteration_label";
            this.ResultIteration_label.Size = new System.Drawing.Size(145, 19);
            this.ResultIteration_label.TabIndex = 166;
            this.ResultIteration_label.Text = "Количество итер.:";
            // 
            // ResultTime_label
            // 
            this.ResultTime_label.AutoSize = true;
            this.ResultTime_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultTime_label.Location = new System.Drawing.Point(91, 442);
            this.ResultTime_label.Name = "ResultTime_label";
            this.ResultTime_label.Size = new System.Drawing.Size(109, 19);
            this.ResultTime_label.TabIndex = 165;
            this.ResultTime_label.Text = "Время (мсек):";
            // 
            // ResultFunction_label
            // 
            this.ResultFunction_label.AutoSize = true;
            this.ResultFunction_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultFunction_label.Location = new System.Drawing.Point(91, 406);
            this.ResultFunction_label.Name = "ResultFunction_label";
            this.ResultFunction_label.Size = new System.Drawing.Size(153, 19);
            this.ResultFunction_label.TabIndex = 164;
            this.ResultFunction_label.Text = "Значение функции:";
            // 
            // ResultX_label
            // 
            this.ResultX_label.AutoSize = true;
            this.ResultX_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultX_label.Location = new System.Drawing.Point(92, 374);
            this.ResultX_label.Name = "ResultX_label";
            this.ResultX_label.Size = new System.Drawing.Size(59, 19);
            this.ResultX_label.TabIndex = 163;
            this.ResultX_label.Text = "Ответ:";
            // 
            // PB_ProgressBar
            // 
            this.PB_ProgressBar.Location = new System.Drawing.Point(96, 287);
            this.PB_ProgressBar.Name = "PB_ProgressBar";
            this.PB_ProgressBar.Size = new System.Drawing.Size(373, 17);
            this.PB_ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PB_ProgressBar.TabIndex = 175;
            this.PB_ProgressBar.Visible = false;
            // 
            // Res_label
            // 
            this.Res_label.AutoSize = true;
            this.Res_label.Location = new System.Drawing.Point(93, 318);
            this.Res_label.Name = "Res_label";
            this.Res_label.Size = new System.Drawing.Size(62, 13);
            this.Res_label.TabIndex = 162;
            this.Res_label.Text = "Результат:";
            this.Res_label.Visible = false;
            // 
            // Function_ComboBox
            // 
            this.Function_ComboBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Function_ComboBox.FormattingEnabled = true;
            this.Function_ComboBox.Items.AddRange(new object[] {
            "x^2-4*sin(x)",
            "x^2-exp(x)",
            "(x-2)^2-ln(x)",
            "(x-2)^2-log(x)",
            "1600*(1-exp(-x/5))-160*x",
            "x*exp(-x)",
            "4*x^3-2*x-6",
            "1500*x^3-0,001*exp(2*x)-0,01*exp(z)^2"});
            this.Function_ComboBox.Location = new System.Drawing.Point(252, 21);
            this.Function_ComboBox.Name = "Function_ComboBox";
            this.Function_ComboBox.Size = new System.Drawing.Size(217, 26);
            this.Function_ComboBox.TabIndex = 161;
            this.Function_ComboBox.Text = "x^2-4*sin(x)";
            // 
            // MAXTime_TextBox
            // 
            this.MAXTime_TextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MAXTime_TextBox.Location = new System.Drawing.Point(252, 187);
            this.MAXTime_TextBox.Name = "MAXTime_TextBox";
            this.MAXTime_TextBox.Size = new System.Drawing.Size(100, 26);
            this.MAXTime_TextBox.TabIndex = 160;
            this.MAXTime_TextBox.Text = "50";
            this.MAXTime_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MAXTime_TextBox_KeyPress);
            // 
            // MAXIteration_TextBox
            // 
            this.MAXIteration_TextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MAXIteration_TextBox.Location = new System.Drawing.Point(252, 155);
            this.MAXIteration_TextBox.Name = "MAXIteration_TextBox";
            this.MAXIteration_TextBox.Size = new System.Drawing.Size(100, 26);
            this.MAXIteration_TextBox.TabIndex = 159;
            this.MAXIteration_TextBox.Text = "100";
            this.MAXIteration_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MAXIteration_TextBox_KeyPress);
            // 
            // Tolerance_TextBox
            // 
            this.Tolerance_TextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tolerance_TextBox.Location = new System.Drawing.Point(252, 123);
            this.Tolerance_TextBox.Name = "Tolerance_TextBox";
            this.Tolerance_TextBox.Size = new System.Drawing.Size(100, 26);
            this.Tolerance_TextBox.TabIndex = 158;
            this.Tolerance_TextBox.Text = "1e-15";
            this.Tolerance_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tolerance_TextBox_KeyPress);
            // 
            // x0_TextBox
            // 
            this.x0_TextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x0_TextBox.Location = new System.Drawing.Point(252, 57);
            this.x0_TextBox.Name = "x0_TextBox";
            this.x0_TextBox.Size = new System.Drawing.Size(100, 26);
            this.x0_TextBox.TabIndex = 157;
            this.x0_TextBox.Text = "1";
            this.x0_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x0_TextBox_KeyPress);
            // 
            // MAXTime_label
            // 
            this.MAXTime_label.AutoSize = true;
            this.MAXTime_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MAXTime_label.Location = new System.Drawing.Point(92, 189);
            this.MAXTime_label.Name = "MAXTime_label";
            this.MAXTime_label.Size = new System.Drawing.Size(108, 19);
            this.MAXTime_label.TabIndex = 156;
            this.MAXTime_label.Text = "(MAX) Время:";
            // 
            // MAXIteration_label
            // 
            this.MAXIteration_label.AutoSize = true;
            this.MAXIteration_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MAXIteration_label.Location = new System.Drawing.Point(91, 157);
            this.MAXIteration_label.Name = "MAXIteration_label";
            this.MAXIteration_label.Size = new System.Drawing.Size(135, 19);
            this.MAXIteration_label.TabIndex = 155;
            this.MAXIteration_label.Text = "(MAX) Итераций:";
            // 
            // Tolerance_label
            // 
            this.Tolerance_label.AutoSize = true;
            this.Tolerance_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tolerance_label.Location = new System.Drawing.Point(92, 125);
            this.Tolerance_label.Name = "Tolerance_label";
            this.Tolerance_label.Size = new System.Drawing.Size(112, 19);
            this.Tolerance_label.TabIndex = 154;
            this.Tolerance_label.Text = "Погрешность:";
            // 
            // A_label
            // 
            this.A_label.AutoSize = true;
            this.A_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A_label.Location = new System.Drawing.Point(92, 57);
            this.A_label.Name = "A_label";
            this.A_label.Size = new System.Drawing.Size(33, 19);
            this.A_label.TabIndex = 153;
            this.A_label.Text = "X0:";
            // 
            // Function_label
            // 
            this.Function_label.AutoSize = true;
            this.Function_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Function_label.Location = new System.Drawing.Point(88, 23);
            this.Function_label.Name = "Function_label";
            this.Function_label.Size = new System.Drawing.Size(78, 19);
            this.Function_label.TabIndex = 152;
            this.Function_label.Text = "Функция:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 570);
            this.Controls.Add(this.x1_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Message_label);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Solve_button);
            this.Controls.Add(this.ABS_TextBox);
            this.Controls.Add(this.ResultIteration_TextBox);
            this.Controls.Add(this.ResultTime_TextBox);
            this.Controls.Add(this.ResultFunction_TextBox);
            this.Controls.Add(this.ResultX_TextBox);
            this.Controls.Add(this.ABS_label);
            this.Controls.Add(this.ResultIteration_label);
            this.Controls.Add(this.ResultTime_label);
            this.Controls.Add(this.ResultFunction_label);
            this.Controls.Add(this.ResultX_label);
            this.Controls.Add(this.PB_ProgressBar);
            this.Controls.Add(this.Res_label);
            this.Controls.Add(this.Function_ComboBox);
            this.Controls.Add(this.MAXTime_TextBox);
            this.Controls.Add(this.MAXIteration_TextBox);
            this.Controls.Add(this.Tolerance_TextBox);
            this.Controls.Add(this.x0_TextBox);
            this.Controls.Add(this.MAXTime_label);
            this.Controls.Add(this.MAXIteration_label);
            this.Controls.Add(this.Tolerance_label);
            this.Controls.Add(this.A_label);
            this.Controls.Add(this.Function_label);
            this.Name = "Form1";
            this.Text = "Метод секущих для поиска корня от F(x)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x1_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Message_label;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button Solve_button;
        private System.Windows.Forms.TextBox ABS_TextBox;
        private System.Windows.Forms.TextBox ResultIteration_TextBox;
        private System.Windows.Forms.TextBox ResultTime_TextBox;
        private System.Windows.Forms.TextBox ResultFunction_TextBox;
        private System.Windows.Forms.TextBox ResultX_TextBox;
        private System.Windows.Forms.Label ABS_label;
        private System.Windows.Forms.Label ResultIteration_label;
        private System.Windows.Forms.Label ResultTime_label;
        private System.Windows.Forms.Label ResultFunction_label;
        private System.Windows.Forms.Label ResultX_label;
        private System.Windows.Forms.ProgressBar PB_ProgressBar;
        private System.Windows.Forms.Label Res_label;
        private System.Windows.Forms.ComboBox Function_ComboBox;
        private System.Windows.Forms.TextBox MAXTime_TextBox;
        private System.Windows.Forms.TextBox MAXIteration_TextBox;
        private System.Windows.Forms.TextBox Tolerance_TextBox;
        private System.Windows.Forms.TextBox x0_TextBox;
        private System.Windows.Forms.Label MAXTime_label;
        private System.Windows.Forms.Label MAXIteration_label;
        private System.Windows.Forms.Label Tolerance_label;
        private System.Windows.Forms.Label A_label;
        private System.Windows.Forms.Label Function_label;
    }
}

