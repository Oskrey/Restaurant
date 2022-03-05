
namespace Ресторан
{
    partial class FormPriceList
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
            this.listBoxCat = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewPriceList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listBoxCat
            // 
            this.listBoxCat.FormattingEnabled = true;
            this.listBoxCat.Location = new System.Drawing.Point(25, 29);
            this.listBoxCat.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxCat.Name = "listBoxCat";
            this.listBoxCat.Size = new System.Drawing.Size(91, 69);
            this.listBoxCat.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 174);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewPriceList
            // 
            this.listViewPriceList.HideSelection = false;
            this.listViewPriceList.Location = new System.Drawing.Point(176, 29);
            this.listViewPriceList.Name = "listViewPriceList";
            this.listViewPriceList.Size = new System.Drawing.Size(412, 334);
            this.listViewPriceList.TabIndex = 4;
            this.listViewPriceList.UseCompatibleStateImageBehavior = false;
            // 
            // FormPriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.listViewPriceList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxCat);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPriceList";
            this.Text = "FormPriceList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPriceList_FormClosed);
            this.Load += new System.EventHandler(this.FormPriceList_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxCat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listViewPriceList;
    }
}