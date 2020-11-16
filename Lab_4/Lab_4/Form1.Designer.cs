namespace Lab_4
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
            this.button_Refill = new System.Windows.Forms.Button();
            this.richTextBox_info = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Out = new System.Windows.Forms.RichTextBox();
            this.button_Get = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Refill
            // 
            this.button_Refill.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Refill.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Refill.Location = new System.Drawing.Point(257, 79);
            this.button_Refill.Name = "button_Refill";
            this.button_Refill.Size = new System.Drawing.Size(102, 42);
            this.button_Refill.TabIndex = 0;
            this.button_Refill.Text = "Перезаполнить";
            this.button_Refill.UseVisualStyleBackColor = false;
            this.button_Refill.Click += new System.EventHandler(this.Button_Refill_Click);
            // 
            // richTextBox_info
            // 
            this.richTextBox_info.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_info.Location = new System.Drawing.Point(47, 79);
            this.richTextBox_info.Name = "richTextBox_info";
            this.richTextBox_info.ReadOnly = true;
            this.richTextBox_info.Size = new System.Drawing.Size(204, 56);
            this.richTextBox_info.TabIndex = 1;
            this.richTextBox_info.Text = "";
            // 
            // richTextBox_Out
            // 
            this.richTextBox_Out.Location = new System.Drawing.Point(36, 152);
            this.richTextBox_Out.Name = "richTextBox_Out";
            this.richTextBox_Out.Size = new System.Drawing.Size(215, 96);
            this.richTextBox_Out.TabIndex = 2;
            this.richTextBox_Out.Text = "";
            this.richTextBox_Out.TextChanged += new System.EventHandler(this.RichTextBox_Out_TextChanged);
            // 
            // button_Get
            // 
            this.button_Get.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Get.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Get.Location = new System.Drawing.Point(257, 179);
            this.button_Get.Name = "button_Get";
            this.button_Get.Size = new System.Drawing.Size(102, 37);
            this.button_Get.TabIndex = 3;
            this.button_Get.Text = "Взять";
            this.button_Get.UseVisualStyleBackColor = false;
            this.button_Get.Click += new System.EventHandler(this.Button_Get_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(110, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Задание";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(371, 295);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Get);
            this.Controls.Add(this.richTextBox_Out);
            this.Controls.Add(this.richTextBox_info);
            this.Controls.Add(this.button_Refill);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Refill;
        private System.Windows.Forms.RichTextBox richTextBox_info;
        private System.Windows.Forms.RichTextBox richTextBox_Out;
        private System.Windows.Forms.Button button_Get;
        private System.Windows.Forms.Button button1;
    }
}

