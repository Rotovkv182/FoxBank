namespace foxbank
{
    partial class AuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.AuthBtn = new System.Windows.Forms.Button();
            this.LoginTextb = new System.Windows.Forms.TextBox();
            this.PassTextb = new System.Windows.Forms.TextBox();
            this.RegBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AuthBtn
            // 
            this.AuthBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.AuthBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthBtn.ForeColor = System.Drawing.Color.LightGray;
            this.AuthBtn.Location = new System.Drawing.Point(58, 297);
            this.AuthBtn.Name = "AuthBtn";
            this.AuthBtn.Size = new System.Drawing.Size(93, 36);
            this.AuthBtn.TabIndex = 0;
            this.AuthBtn.Text = "Авторизация";
            this.AuthBtn.UseVisualStyleBackColor = false;
            this.AuthBtn.Click += new System.EventHandler(this.AuthBtn_Click);
            // 
            // LoginTextb
            // 
            this.LoginTextb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.LoginTextb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginTextb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextb.ForeColor = System.Drawing.Color.LightGray;
            this.LoginTextb.Location = new System.Drawing.Point(58, 165);
            this.LoginTextb.Multiline = true;
            this.LoginTextb.Name = "LoginTextb";
            this.LoginTextb.Size = new System.Drawing.Size(200, 33);
            this.LoginTextb.TabIndex = 1;
            this.LoginTextb.Text = "Логин";
            // 
            // PassTextb
            // 
            this.PassTextb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.PassTextb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassTextb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassTextb.ForeColor = System.Drawing.Color.LightGray;
            this.PassTextb.Location = new System.Drawing.Point(58, 231);
            this.PassTextb.Multiline = true;
            this.PassTextb.Name = "PassTextb";
            this.PassTextb.Size = new System.Drawing.Size(200, 33);
            this.PassTextb.TabIndex = 2;
            this.PassTextb.Text = "Пароль";
            // 
            // RegBtn
            // 
            this.RegBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.RegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegBtn.ForeColor = System.Drawing.Color.LightGray;
            this.RegBtn.Location = new System.Drawing.Point(165, 297);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(93, 36);
            this.RegBtn.TabIndex = 3;
            this.RegBtn.Text = "Регистрация";
            this.RegBtn.UseVisualStyleBackColor = false;
            this.RegBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(317, 385);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RegBtn);
            this.Controls.Add(this.PassTextb);
            this.Controls.Add(this.LoginTextb);
            this.Controls.Add(this.AuthBtn);
            this.Name = "AuthForm";
            this.Text = "Авторизация - FoxBank";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AuthBtn;
        private System.Windows.Forms.TextBox LoginTextb;
        private System.Windows.Forms.TextBox PassTextb;
        private System.Windows.Forms.Button RegBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

