namespace WindowsFormsApp2
{
    partial class FormAD
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
            this.btn_AD = new System.Windows.Forms.Button();
            this.dgv_osoba = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_osoba)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AD
            // 
            this.btn_AD.Location = new System.Drawing.Point(12, 35);
            this.btn_AD.Name = "btn_AD";
            this.btn_AD.Size = new System.Drawing.Size(209, 41);
            this.btn_AD.TabIndex = 1;
            this.btn_AD.Text = "Osoby";
            this.btn_AD.UseVisualStyleBackColor = true;
            this.btn_AD.Click += new System.EventHandler(this.btn_AD_Click);
            // 
            // dgv_osoba
            // 
            this.dgv_osoba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_osoba.Location = new System.Drawing.Point(266, 35);
            this.dgv_osoba.Name = "dgv_osoba";
            this.dgv_osoba.Size = new System.Drawing.Size(492, 359);
            this.dgv_osoba.TabIndex = 2;
            this.dgv_osoba.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ZatrudnieniPracownicy_CellContentClick);
            // 
            // FormAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_osoba);
            this.Controls.Add(this.btn_AD);
            this.Name = "FormAD";
            this.Text = "FormAD";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_osoba)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_AD;
        private System.Windows.Forms.DataGridView dgv_osoba;
    }
}