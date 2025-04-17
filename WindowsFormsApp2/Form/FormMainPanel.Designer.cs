namespace WindowsFormsApp2
{
    partial class FormMainPanel
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Main = new System.Windows.Forms.Panel();
            this.btn_Form1 = new System.Windows.Forms.Button();
            this.btn_PozostalyUrlop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel_Main
            // 
            this.panel_Main.Location = new System.Drawing.Point(216, 12);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1676, 1017);
            this.panel_Main.TabIndex = 0;
            // 
            // btn_Form1
            // 
            this.btn_Form1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Form1.Location = new System.Drawing.Point(12, 12);
            this.btn_Form1.Name = "btn_Form1";
            this.btn_Form1.Size = new System.Drawing.Size(198, 57);
            this.btn_Form1.TabIndex = 0;
            this.btn_Form1.Text = "Form1";
            this.btn_Form1.UseVisualStyleBackColor = true;
            this.btn_Form1.Click += new System.EventHandler(this.btn_Form1_Click);
            // 
            // btn_PozostalyUrlop
            // 
            this.btn_PozostalyUrlop.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_PozostalyUrlop.Location = new System.Drawing.Point(12, 75);
            this.btn_PozostalyUrlop.Name = "btn_PozostalyUrlop";
            this.btn_PozostalyUrlop.Size = new System.Drawing.Size(198, 57);
            this.btn_PozostalyUrlop.TabIndex = 1;
            this.btn_PozostalyUrlop.Text = "Pozały Urlop";
            this.btn_PozostalyUrlop.UseVisualStyleBackColor = true;
            this.btn_PozostalyUrlop.Click += new System.EventHandler(this.btn_PozostalyUrlop_Click);
            // 
            // FormMainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btn_PozostalyUrlop);
            this.Controls.Add(this.btn_Form1);
            this.Controls.Add(this.panel_Main);
            this.Name = "FormMainPanel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Button btn_Form1;
        private System.Windows.Forms.Button btn_PozostalyUrlop;
    }
}

