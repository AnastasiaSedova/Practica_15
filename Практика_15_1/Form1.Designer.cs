namespace Практика_15_1
{
    partial class HelloWorldForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTBx = new System.Windows.Forms.TextBox();
            this.helloBtn = new System.Windows.Forms.Button();
            this.helloTBx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(26, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(207, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Введите имя для приветствия";
            // 
            // nameTBx
            // 
            this.nameTBx.Location = new System.Drawing.Point(255, 23);
            this.nameTBx.Name = "nameTBx";
            this.nameTBx.Size = new System.Drawing.Size(234, 22);
            this.nameTBx.TabIndex = 1;
            // 
            // helloBtn
            // 
            this.helloBtn.Location = new System.Drawing.Point(81, 74);
            this.helloBtn.Name = "helloBtn";
            this.helloBtn.Size = new System.Drawing.Size(341, 23);
            this.helloBtn.TabIndex = 2;
            this.helloBtn.Text = "Поприветствовать";
            this.helloBtn.UseVisualStyleBackColor = true;
            this.helloBtn.Click += new System.EventHandler(this.helloBtn_Click);
            // 
            // helloTBx
            // 
            this.helloTBx.Location = new System.Drawing.Point(81, 123);
            this.helloTBx.Name = "helloTBx";
            this.helloTBx.Size = new System.Drawing.Size(341, 22);
            this.helloTBx.TabIndex = 3;
            // 
            // HelloWorldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 185);
            this.Controls.Add(this.helloTBx);
            this.Controls.Add(this.helloBtn);
            this.Controls.Add(this.nameTBx);
            this.Controls.Add(this.nameLabel);
            this.Name = "HelloWorldForm";
            this.Text = "HelloWorldForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTBx;
        private System.Windows.Forms.Button helloBtn;
        private System.Windows.Forms.TextBox helloTBx;
    }
}

