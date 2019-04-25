namespace VendingMachine.BeheerPaneel
{
    partial class Form1
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
            this.lbProducten = new System.Windows.Forms.ListBox();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.pbProductBeheer = new System.Windows.Forms.PictureBox();
            this.tbPrijs = new System.Windows.Forms.TextBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblPrijs = new System.Windows.Forms.Label();
            this.btnWijzig = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductBeheer)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProducten
            // 
            this.lbProducten.FormattingEnabled = true;
            this.lbProducten.ItemHeight = 16;
            this.lbProducten.Location = new System.Drawing.Point(13, 13);
            this.lbProducten.Name = "lbProducten";
            this.lbProducten.Size = new System.Drawing.Size(337, 436);
            this.lbProducten.TabIndex = 0;
            // 
            // tbNaam
            // 
            this.tbNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbNaam.Location = new System.Drawing.Point(371, 204);
            this.tbNaam.Multiline = true;
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(186, 39);
            this.tbNaam.TabIndex = 1;
            this.tbNaam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbProductBeheer
            // 
            this.pbProductBeheer.Location = new System.Drawing.Point(371, 13);
            this.pbProductBeheer.Name = "pbProductBeheer";
            this.pbProductBeheer.Size = new System.Drawing.Size(186, 155);
            this.pbProductBeheer.TabIndex = 2;
            this.pbProductBeheer.TabStop = false;
            // 
            // tbPrijs
            // 
            this.tbPrijs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbPrijs.Location = new System.Drawing.Point(371, 279);
            this.tbPrijs.Multiline = true;
            this.tbPrijs.Name = "tbPrijs";
            this.tbPrijs.Size = new System.Drawing.Size(186, 39);
            this.tbPrijs.TabIndex = 3;
            // 
            // lblNaam
            // 
            this.lblNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaam.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNaam.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNaam.Location = new System.Drawing.Point(371, 175);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(186, 26);
            this.lblNaam.TabIndex = 4;
            this.lblNaam.Text = "Naam";
            this.lblNaam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrijs
            // 
            this.lblPrijs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrijs.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrijs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPrijs.Location = new System.Drawing.Point(371, 246);
            this.lblPrijs.Name = "lblPrijs";
            this.lblPrijs.Size = new System.Drawing.Size(186, 26);
            this.lblPrijs.TabIndex = 5;
            this.lblPrijs.Text = "Prijs";
            this.lblPrijs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWijzig
            // 
            this.btnWijzig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWijzig.Location = new System.Drawing.Point(371, 371);
            this.btnWijzig.Name = "btnWijzig";
            this.btnWijzig.Size = new System.Drawing.Size(186, 36);
            this.btnWijzig.TabIndex = 6;
            this.btnWijzig.Text = "Wijzig";
            this.btnWijzig.UseVisualStyleBackColor = true;
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerwijder.Location = new System.Drawing.Point(371, 413);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(186, 36);
            this.btnVerwijder.TabIndex = 7;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(592, 475);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnWijzig);
            this.Controls.Add(this.lblPrijs);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.tbPrijs);
            this.Controls.Add(this.pbProductBeheer);
            this.Controls.Add(this.tbNaam);
            this.Controls.Add(this.lbProducten);
            this.Name = "Form1";
            this.Text = "Prijs";
            ((System.ComponentModel.ISupportInitialize)(this.pbProductBeheer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProducten;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.PictureBox pbProductBeheer;
        private System.Windows.Forms.TextBox tbPrijs;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblPrijs;
        private System.Windows.Forms.Button btnWijzig;
        private System.Windows.Forms.Button btnVerwijder;
    }
}

