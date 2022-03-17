
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
            this.buttonIssueOrder = new System.Windows.Forms.Button();
            this.buttonMain = new System.Windows.Forms.Button();
            this.listBoxCat = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
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
            this.panel1.Controls.Add(this.buttonIssueOrder);
            this.panel1.Controls.Add(this.buttonMain);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 68);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.BackgroundImage = global::Ресторан.Properties.Resources.эмблема1;
            this.pictureBoxIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxIcon.Location = new System.Drawing.Point(23, -4);
            this.pictureBoxIcon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(73, 68);
            this.pictureBoxIcon.TabIndex = 2;
            this.pictureBoxIcon.TabStop = false;
            this.pictureBoxIcon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonIssueOrder
            // 
            this.buttonIssueOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonIssueOrder.Location = new System.Drawing.Point(122, 7);
            this.buttonIssueOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIssueOrder.Name = "buttonIssueOrder";
            this.buttonIssueOrder.Size = new System.Drawing.Size(203, 26);
            this.buttonIssueOrder.TabIndex = 1;
            this.buttonIssueOrder.Text = "Оформить заказ";
            this.buttonIssueOrder.UseVisualStyleBackColor = true;
            this.buttonIssueOrder.Click += new System.EventHandler(this.buttonIssueOrder_Click);
            // 
            // buttonMain
            // 
            this.buttonMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMain.Location = new System.Drawing.Point(122, 38);
            this.buttonMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.listBoxCat.Size = new System.Drawing.Size(71, 225);
            this.listBoxCat.TabIndex = 1;
            this.listBoxCat.SelectedIndexChanged += new System.EventHandler(this.listBoxCat_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listView1.BackgroundImage")));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(102, 75);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(285, 397);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ресторан.Properties.Resources.заказ;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(442, 527);
            this.ControlBox = false;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listBoxCat);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сделать заказ";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Button buttonIssueOrder;
        private System.Windows.Forms.Button buttonMain;
        private System.Windows.Forms.ListBox listBoxCat;
        private System.Windows.Forms.ListView listView1;
    }
}