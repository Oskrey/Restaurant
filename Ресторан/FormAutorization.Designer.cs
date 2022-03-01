
namespace Ресторан
{
    partial class FormAutorization
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAutorization));
            this.textBoxPasswd = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonChangePass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPasswd
            // 
            this.textBoxPasswd.Location = new System.Drawing.Point(13, 46);
            this.textBoxPasswd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPasswd.Name = "textBoxPasswd";
            this.textBoxPasswd.Size = new System.Drawing.Size(223, 26);
            this.textBoxPasswd.TabIndex = 4;
            this.textBoxPasswd.UseSystemPasswordChar = true;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(13, 87);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(276, 35);
            this.buttonEnter.TabIndex = 7;
            this.buttonEnter.Text = "Войти";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonChangePass
            // 
            this.buttonChangePass.Location = new System.Drawing.Point(13, 132);
            this.buttonChangePass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonChangePass.Name = "buttonChangePass";
            this.buttonChangePass.Size = new System.Drawing.Size(275, 35);
            this.buttonChangePass.TabIndex = 8;
            this.buttonChangePass.Text = "Изменить пароль";
            this.buttonChangePass.UseVisualStyleBackColor = true;
            this.buttonChangePass.Click += new System.EventHandler(this.buttonChangePass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Для продолжения введите пароль";
            // 
            // buttonLook
            // 
            this.buttonLook.BackColor = System.Drawing.Color.Transparent;
            this.buttonLook.BackgroundImage = global::Ресторан.Properties.Resources.пароль;
            this.buttonLook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLook.Location = new System.Drawing.Point(244, 39);
            this.buttonLook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLook.Name = "buttonLook";
            this.buttonLook.Size = new System.Drawing.Size(44, 38);
            this.buttonLook.TabIndex = 6;
            this.buttonLook.UseCompatibleTextRendering = true;
            this.buttonLook.UseVisualStyleBackColor = false;
            this.buttonLook.Click += new System.EventHandler(this.buttonLook_Click);
            // 
            // FormAutorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 173);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChangePass);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.buttonLook);
            this.Controls.Add(this.textBoxPasswd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAutorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPasswd;
        private System.Windows.Forms.Button buttonLook;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonChangePass;
        private System.Windows.Forms.Label label1;
    }
}