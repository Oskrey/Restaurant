
namespace Ресторан
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonMakeOrder = new System.Windows.Forms.Button();
            this.buttonManageMenu = new System.Windows.Forms.Button();
            this.buttonPriceList = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Ресторан.Properties.Resources.эмблема1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(147, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 124);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonMakeOrder
            // 
            this.buttonMakeOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMakeOrder.BackgroundImage")));
            this.buttonMakeOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMakeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMakeOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMakeOrder.Location = new System.Drawing.Point(143, 206);
            this.buttonMakeOrder.Name = "buttonMakeOrder";
            this.buttonMakeOrder.Size = new System.Drawing.Size(159, 66);
            this.buttonMakeOrder.TabIndex = 2;
            this.buttonMakeOrder.Text = "Сделать заказ";
            this.buttonMakeOrder.UseVisualStyleBackColor = true;
            this.buttonMakeOrder.Click += new System.EventHandler(this.buttonMakeOrder_Click);
            // 
            // buttonManageMenu
            // 
            this.buttonManageMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonManageMenu.BackgroundImage")));
            this.buttonManageMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonManageMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonManageMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonManageMenu.Location = new System.Drawing.Point(144, 278);
            this.buttonManageMenu.Name = "buttonManageMenu";
            this.buttonManageMenu.Size = new System.Drawing.Size(159, 66);
            this.buttonManageMenu.TabIndex = 3;
            this.buttonManageMenu.Text = "Управлять меню";
            this.buttonManageMenu.UseVisualStyleBackColor = true;
            this.buttonManageMenu.Click += new System.EventHandler(this.buttonManageMenu_Click);
            // 
            // buttonPriceList
            // 
            this.buttonPriceList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPriceList.BackgroundImage")));
            this.buttonPriceList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPriceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPriceList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPriceList.Location = new System.Drawing.Point(144, 351);
            this.buttonPriceList.Name = "buttonPriceList";
            this.buttonPriceList.Size = new System.Drawing.Size(159, 66);
            this.buttonPriceList.TabIndex = 4;
            this.buttonPriceList.Text = "Прайс-лист";
            this.buttonPriceList.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.BackgroundImage = global::Ресторан.Properties.Resources.Кнопка;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonExit.Location = new System.Drawing.Point(79, 490);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(277, 56);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Завершение работы";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(156, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "TRATTORIA";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ресторан.Properties.Resources.ресторан1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(436, 558);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPriceList);
            this.Controls.Add(this.buttonManageMenu);
            this.Controls.Add(this.buttonMakeOrder);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная страница";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonMakeOrder;
        private System.Windows.Forms.Button buttonManageMenu;
        private System.Windows.Forms.Button buttonPriceList;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
    }
}

