namespace VendingMachine.App
{
    partial class ProductUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.lblTag = new System.Windows.Forms.Label();
            this.lblPrijs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pbProduct
            // 
            this.pbProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbProduct.Location = new System.Drawing.Point(0, 0);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(161, 163);
            this.pbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProduct.TabIndex = 0;
            this.pbProduct.TabStop = false;
            // 
            // lblTag
            // 
            this.lblTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.lblTag.Location = new System.Drawing.Point(3, 166);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(71, 27);
            this.lblTag.TabIndex = 1;
            this.lblTag.Text = "label1";
            this.lblTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrijs
            // 
            this.lblPrijs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrijs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.lblPrijs.Location = new System.Drawing.Point(87, 166);
            this.lblPrijs.Name = "lblPrijs";
            this.lblPrijs.Size = new System.Drawing.Size(71, 27);
            this.lblPrijs.TabIndex = 2;
            this.lblPrijs.Text = "label1";
            this.lblPrijs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPrijs);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.pbProduct);
            this.Name = "ProductUC";
            this.Size = new System.Drawing.Size(161, 196);
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbProduct;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Label lblPrijs;
    }
}
