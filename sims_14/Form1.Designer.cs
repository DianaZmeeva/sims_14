namespace sims_14
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
            this.components = new System.ComponentModel.Container();
            this.button_start = new System.Windows.Forms.Button();
            this.label_ta = new System.Windows.Forms.Label();
            this.label_x = new System.Windows.Forms.Label();
            this.label_y = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowpanel_agent = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(95, 12);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_ta
            // 
            this.label_ta.AutoSize = true;
            this.label_ta.Location = new System.Drawing.Point(11, 120);
            this.label_ta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ta.Name = "label_ta";
            this.label_ta.Size = new System.Drawing.Size(206, 13);
            this.label_ta.TabIndex = 16;
            this.label_ta.Text = "Время прихода следующего клиента: 0";
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Location = new System.Drawing.Point(11, 99);
            this.label_x.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(185, 13);
            this.label_x.TabIndex = 15;
            this.label_x.Text = "Количество занятых операторов: 0";
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.Location = new System.Drawing.Point(11, 76);
            this.label_y.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(181, 13);
            this.label_y.TabIndex = 14;
            this.label_y.Text = "Количество клиентов в очереди: 0";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(11, 51);
            this.label_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(42, 13);
            this.label_time.TabIndex = 13;
            this.label_time.Text = "Time: 0";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // flowpanel_agent
            // 
            this.flowpanel_agent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowpanel_agent.Location = new System.Drawing.Point(0, 155);
            this.flowpanel_agent.Name = "flowpanel_agent";
            this.flowpanel_agent.Size = new System.Drawing.Size(284, 100);
            this.flowpanel_agent.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 255);
            this.Controls.Add(this.flowpanel_agent);
            this.Controls.Add(this.label_ta);
            this.Controls.Add(this.label_x);
            this.Controls.Add(this.label_y);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.button_start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_ta;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel flowpanel_agent;
    }
}

