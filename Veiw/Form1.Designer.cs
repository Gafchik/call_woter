namespace call_woter
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
            this.rb_m = new System.Windows.Forms.RadioButton();
            this.rb_w = new System.Windows.Forms.RadioButton();
            this.txt_v = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.NumericUpDown();
            this.txt_live = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.go = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.weight)).BeginInit();
            this.SuspendLayout();
            // 
            // rb_m
            // 
            this.rb_m.AutoSize = true;
            this.rb_m.Location = new System.Drawing.Point(42, 151);
            this.rb_m.Name = "rb_m";
            this.rb_m.Size = new System.Drawing.Size(34, 17);
            this.rb_m.TabIndex = 0;
            this.rb_m.TabStop = true;
            this.rb_m.Text = "M";
            this.rb_m.UseVisualStyleBackColor = true;
            // 
            // rb_w
            // 
            this.rb_w.AutoSize = true;
            this.rb_w.Location = new System.Drawing.Point(224, 151);
            this.rb_w.Name = "rb_w";
            this.rb_w.Size = new System.Drawing.Size(36, 17);
            this.rb_w.TabIndex = 1;
            this.rb_w.TabStop = true;
            this.rb_w.Text = "Ж";
            this.rb_w.UseVisualStyleBackColor = true;
            // 
            // txt_v
            // 
            this.txt_v.AutoSize = true;
            this.txt_v.Location = new System.Drawing.Point(39, 26);
            this.txt_v.Name = "txt_v";
            this.txt_v.Size = new System.Drawing.Size(26, 13);
            this.txt_v.TabIndex = 2;
            this.txt_v.Text = "Вес";
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(140, 24);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(120, 20);
            this.weight.TabIndex = 3;
            // 
            // txt_live
            // 
            this.txt_live.AutoSize = true;
            this.txt_live.Location = new System.Drawing.Point(29, 83);
            this.txt_live.Name = "txt_live";
            this.txt_live.Size = new System.Drawing.Size(74, 13);
            this.txt_live.TabIndex = 5;
            this.txt_live.Text = "Образ жизни";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(139, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // go
            // 
            this.go.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.go.Location = new System.Drawing.Point(185, 203);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(75, 23);
            this.go.TabIndex = 7;
            this.go.Text = "--->";
            this.go.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 236);
            this.Controls.Add(this.go);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_live);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.txt_v);
            this.Controls.Add(this.rb_w);
            this.Controls.Add(this.rb_m);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.weight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
    }
}

