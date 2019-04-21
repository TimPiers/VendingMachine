namespace VendingMachine.App
{
    partial class ReturnProductApp
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
            this.productImage = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productImage
            // 
            this.productImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.productImage.Location = new System.Drawing.Point(85, 12);
            this.productImage.Name = "productImage";
            this.productImage.Size = new System.Drawing.Size(354, 343);
            this.productImage.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(235)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(109)))), ((int)(((byte)(229)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(126, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pak product";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReturnProductApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(533, 507);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.productImage);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ReturnProductApp";
            this.Text = "ReturnProductApp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel productImage;
        private System.Windows.Forms.Button button1;
    }
}