
namespace Ресторан
{
    partial class FormOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelCalc = new System.Windows.Forms.Label();
            this.buttonAddToOrder = new System.Windows.Forms.Button();
            this.buttonMain = new System.Windows.Forms.Button();
            this.listBoxCat = new System.Windows.Forms.ListBox();
            this.listViewMenu = new System.Windows.Forms.ListView();
            this.listBoxDishes = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBoxIcon);
            this.panel1.Controls.Add(this.labelCalc);
            this.panel1.Controls.Add(this.buttonAddToOrder);
            this.panel1.Controls.Add(this.buttonMain);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 68);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.BackgroundImage = global::Ресторан.Properties.Resources.эмблема1;
            this.pictureBoxIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxIcon.Location = new System.Drawing.Point(23, -4);
            this.pictureBoxIcon.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(73, 68);
            this.pictureBoxIcon.TabIndex = 2;
            this.pictureBoxIcon.TabStop = false;
            this.pictureBoxIcon.Click += new System.EventHandler(this.buttonMain_Click);
            // 
            // labelCalc
            // 
            this.labelCalc.AutoSize = true;
            this.labelCalc.Location = new System.Drawing.Point(574, 20);
            this.labelCalc.Name = "labelCalc";
            this.labelCalc.Size = new System.Drawing.Size(35, 13);
            this.labelCalc.TabIndex = 4;
            this.labelCalc.Text = "label1";
            // 
            // buttonAddToOrder
            // 
            this.buttonAddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddToOrder.Location = new System.Drawing.Point(122, 7);
            this.buttonAddToOrder.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddToOrder.Name = "buttonAddToOrder";
            this.buttonAddToOrder.Size = new System.Drawing.Size(203, 26);
            this.buttonAddToOrder.TabIndex = 1;
            this.buttonAddToOrder.Text = "Добавить блюдо в заказ";
            this.buttonAddToOrder.UseVisualStyleBackColor = true;
            this.buttonAddToOrder.Click += new System.EventHandler(this.buttonGoToOrder_Click);
            // 
            // buttonMain
            // 
            this.buttonMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMain.Location = new System.Drawing.Point(122, 38);
            this.buttonMain.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.Size = new System.Drawing.Size(203, 26);
            this.buttonMain.TabIndex = 0;
            this.buttonMain.Text = "Вернуться на главную";
            this.buttonMain.UseVisualStyleBackColor = true;
            this.buttonMain.Click += new System.EventHandler(this.buttonMain_Click);
            // 
            // listBoxCat
            // 
            this.listBoxCat.BackColor = System.Drawing.Color.SandyBrown;
            this.listBoxCat.FormattingEnabled = true;
            this.listBoxCat.Location = new System.Drawing.Point(12, 75);
            this.listBoxCat.Name = "listBoxCat";
            this.listBoxCat.Size = new System.Drawing.Size(71, 537);
            this.listBoxCat.TabIndex = 1;
            this.listBoxCat.SelectedIndexChanged += new System.EventHandler(this.listBoxCat_SelectedIndexChanged);
            // 
            // listViewMenu
            // 
            this.listViewMenu.HideSelection = false;
            this.listViewMenu.Location = new System.Drawing.Point(102, 75);
            this.listViewMenu.Name = "listViewMenu";
            this.listViewMenu.Size = new System.Drawing.Size(482, 540);
            this.listViewMenu.TabIndex = 2;
            this.listViewMenu.UseCompatibleStateImageBehavior = false;
            // 
            // listBoxDishes
            // 
            this.listBoxDishes.FormattingEnabled = true;
            this.listBoxDishes.Location = new System.Drawing.Point(590, 75);
            this.listBoxDishes.Name = "listBoxDishes";
            this.listBoxDishes.Size = new System.Drawing.Size(331, 537);
            this.listBoxDishes.TabIndex = 5;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ресторан.Properties.Resources.заказ;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 627);
            this.ControlBox = false;
            this.Controls.Add(this.listBoxDishes);
            this.Controls.Add(this.listViewMenu);
            this.Controls.Add(this.listBoxCat);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сделать заказ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormOrder_FormClosed);
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Button buttonAddToOrder;
        private System.Windows.Forms.Button buttonMain;
        private System.Windows.Forms.ListBox listBoxCat;
        private System.Windows.Forms.ListView listViewMenu;
        private System.Windows.Forms.Label labelCalc;
        private System.Windows.Forms.ListBox listBoxDishes;
    }
}