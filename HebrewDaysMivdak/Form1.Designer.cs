namespace HebrewDaysMivdak
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox_day = new ComboBox();
            comboBox_dInMonth = new ComboBox();
            comboBox_month = new ComboBox();
            comboBox_year = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBox_day
            // 
            comboBox_day.FormattingEnabled = true;
            comboBox_day.Location = new Point(595, 71);
            comboBox_day.Name = "comboBox_day";
            comboBox_day.Size = new Size(151, 28);
            comboBox_day.TabIndex = 0;
            // 
            // comboBoxdInMonth
            // 
            comboBox_dInMonth.FormattingEnabled = true;
            comboBox_dInMonth.Location = new Point(419, 71);
            comboBox_dInMonth.Name = "comboBoxdInMonth";
            comboBox_dInMonth.Size = new Size(151, 28);
            comboBox_dInMonth.TabIndex = 1;
            // 
            // comboBox_month
            // 
            comboBox_month.FormattingEnabled = true;
            comboBox_month.Location = new Point(240, 71);
            comboBox_month.Name = "comboBox_month";
            comboBox_month.Size = new Size(151, 28);
            comboBox_month.TabIndex = 2;
            // 
            // comboBox_year
            // 
            comboBox_year.FormattingEnabled = true;
            comboBox_year.Location = new Point(50, 71);
            comboBox_year.Name = "comboBox_year";
            comboBox_year.Size = new Size(151, 28);
            comboBox_year.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(308, 350);
            button1.Name = "button1";
            button1.Size = new Size(178, 58);
            button1.TabIndex = 4;
            button1.Text = "הצג תאריך";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(comboBox_year);
            Controls.Add(comboBox_month);
            Controls.Add(comboBox_dInMonth);
            Controls.Add(comboBox_day);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox_day;
        private ComboBox comboBox_dInMonth;
        private ComboBox comboBox_month;
        private ComboBox comboBox_year;
        private Button button1;
    }
}
