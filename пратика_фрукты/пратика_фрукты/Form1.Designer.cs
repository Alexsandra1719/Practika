namespace FruityViceApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstFruits = new System.Windows.Forms.ListBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(18, 46);
            this.txtOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(298, 26);
            this.txtOrder.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(327, 43);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 35);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstFruits
            // 
            this.lstFruits.FormattingEnabled = true;
            this.lstFruits.ItemHeight = 20;
            this.lstFruits.Location = new System.Drawing.Point(18, 108);
            this.lstFruits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstFruits.Name = "lstFruits";
            this.lstFruits.Size = new System.Drawing.Size(298, 444);
            this.lstFruits.TabIndex = 2;
            this.lstFruits.SelectedIndexChanged += new System.EventHandler(this.lstFruits_SelectedIndexChanged);
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(327, 108);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ReadOnly = true;
            this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetails.Size = new System.Drawing.Size(373, 444);
            this.txtDetails.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите порядок фруктов (например: Rosales)";
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Location = new System.Drawing.Point(461, 42);
            this.btnLoadAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(112, 35);
            this.btnLoadAll.TabIndex = 1;
            this.btnLoadAll.Text = "все фрукты";
            this.btnLoadAll.UseVisualStyleBackColor = true;
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 571);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.lstFruits);
            this.Controls.Add(this.btnLoadAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtOrder);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "FruityVice - Поиск фруктов по порядку";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstFruits;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadAll;
    }
}