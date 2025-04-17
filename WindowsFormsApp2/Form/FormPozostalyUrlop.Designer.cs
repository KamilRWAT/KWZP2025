namespace WindowsFormsApp2
{
    partial class FormPozostalyUrlop
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
            this.dgv_PozostalyUrlop = new System.Windows.Forms.DataGridView();
            this.btn_DodajProdukt = new System.Windows.Forms.Button();
            this.btn_trash = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PozostalyUrlop)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_PozostalyUrlop
            // 
            this.dgv_PozostalyUrlop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PozostalyUrlop.Location = new System.Drawing.Point(12, 12);
            this.dgv_PozostalyUrlop.Name = "dgv_PozostalyUrlop";
            this.dgv_PozostalyUrlop.Size = new System.Drawing.Size(430, 235);
            this.dgv_PozostalyUrlop.TabIndex = 0;
            // 
            // btn_DodajProdukt
            // 
            this.btn_DodajProdukt.Location = new System.Drawing.Point(12, 253);
            this.btn_DodajProdukt.Name = "btn_DodajProdukt";
            this.btn_DodajProdukt.Size = new System.Drawing.Size(160, 23);
            this.btn_DodajProdukt.TabIndex = 1;
            this.btn_DodajProdukt.Text = "Dodaj Produkt";
            this.btn_DodajProdukt.UseVisualStyleBackColor = true;
            this.btn_DodajProdukt.Click += new System.EventHandler(this.btn_DodajProdukt_Click);
            // 
            // btn_trash
            // 
            this.btn_trash.Location = new System.Drawing.Point(282, 253);
            this.btn_trash.Name = "btn_trash";
            this.btn_trash.Size = new System.Drawing.Size(160, 23);
            this.btn_trash.TabIndex = 2;
            this.btn_trash.Text = "Usuń ostatni produkt";
            this.btn_trash.UseVisualStyleBackColor = true;
            this.btn_trash.Click += new System.EventHandler(this.btn_trash_Click);
            // 
            // FormPozostalyUrlop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_trash);
            this.Controls.Add(this.btn_DodajProdukt);
            this.Controls.Add(this.dgv_PozostalyUrlop);
            this.Name = "FormPozostalyUrlop";
            this.Text = "FormPozostalyUrlop";
            this.Load += new System.EventHandler(this.FormPozostalyUrlop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PozostalyUrlop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PozostalyUrlop;
        private System.Windows.Forms.Button btn_DodajProdukt;
        private System.Windows.Forms.Button btn_trash;
    }
}