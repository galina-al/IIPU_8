namespace Lab8
{
    partial class MainWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fileSize = new System.Windows.Forms.NumericUpDown();
            this.hideMode = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.saveConfig = new System.Windows.Forms.Button();
            this.logMod = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hotKeyMode = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSize)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(65, 64);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(209, 27);
            this.email.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Размер файлов:";
            // 
            // fileSize
            // 
            this.fileSize.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.fileSize.Location = new System.Drawing.Point(139, 33);
            this.fileSize.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.fileSize.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.fileSize.Name = "fileSize";
            this.fileSize.Size = new System.Drawing.Size(86, 27);
            this.fileSize.TabIndex = 4;
            this.fileSize.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // hideMode
            // 
            this.hideMode.AutoSize = true;
            this.hideMode.Location = new System.Drawing.Point(6, 57);
            this.hideMode.Name = "hideMode";
            this.hideMode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hideMode.Size = new System.Drawing.Size(159, 25);
            this.hideMode.TabIndex = 21;
            this.hideMode.Text = ":Скрытый режим";
            this.hideMode.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(205, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 21);
            this.label13.TabIndex = 23;
            // 
            // saveConfig
            // 
            this.saveConfig.Location = new System.Drawing.Point(189, 142);
            this.saveConfig.Name = "saveConfig";
            this.saveConfig.Size = new System.Drawing.Size(104, 27);
            this.saveConfig.TabIndex = 24;
            this.saveConfig.Text = "Применить";
            this.saveConfig.UseVisualStyleBackColor = true;
            this.saveConfig.Click += new System.EventHandler(this.SaveSettingsButtonClick);
            // 
            // logMod
            // 
            this.logMod.AutoSize = true;
            this.logMod.Location = new System.Drawing.Point(6, 26);
            this.logMod.Name = "logMod";
            this.logMod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.logMod.Size = new System.Drawing.Size(133, 25);
            this.logMod.TabIndex = 28;
            this.logMod.Text = ":Логирование";
            this.logMod.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "байт";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.fileSize);
            this.groupBox1.Location = new System.Drawing.Point(211, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 124);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление логированием";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hotKeyMode);
            this.groupBox2.Controls.Add(this.logMod);
            this.groupBox2.Controls.Add(this.hideMode);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 124);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Режимы работы";
            // 
            // hotKeyMode
            // 
            this.hotKeyMode.AutoSize = true;
            this.hotKeyMode.Location = new System.Drawing.Point(6, 89);
            this.hotKeyMode.Name = "hotKeyMode";
            this.hotKeyMode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hotKeyMode.Size = new System.Drawing.Size(82, 25);
            this.hotKeyMode.TabIndex = 29;
            this.hotKeyMode.Text = ":Block A";
            this.hotKeyMode.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(515, 180);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveConfig);
            this.Controls.Add(this.label13);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Lab8";
            this.Shown += new System.EventHandler(this.MainWindowShown);
            ((System.ComponentModel.ISupportInitialize)(this.fileSize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown fileSize;
        private System.Windows.Forms.CheckBox hideMode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button saveConfig;
        private System.Windows.Forms.CheckBox logMod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox hotKeyMode;
    }
}

