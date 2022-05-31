namespace OOO_Odejda_dlya_rychek.Forms
{
    partial class EditMaterial
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
            this.logotip = new System.Windows.Forms.PictureBox();
            this.verhnayaPanel = new System.Windows.Forms.Panel();
            this.zagolovok = new System.Windows.Forms.Label();
            this.nijnyaPanel = new System.Windows.Forms.Panel();
            this.nazad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logotip)).BeginInit();
            this.verhnayaPanel.SuspendLayout();
            this.nijnyaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logotip
            // 
            this.logotip.Image = global::OOO_Odejda_dlya_rychek.Properties.Resources.Одежда_для_ручек;
            this.logotip.Location = new System.Drawing.Point(21, 10);
            this.logotip.Name = "logotip";
            this.logotip.Size = new System.Drawing.Size(200, 200);
            this.logotip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logotip.TabIndex = 0;
            this.logotip.TabStop = false;
            // 
            // verhnayaPanel
            // 
            this.verhnayaPanel.Controls.Add(this.zagolovok);
            this.verhnayaPanel.Controls.Add(this.logotip);
            this.verhnayaPanel.Location = new System.Drawing.Point(-22, -31);
            this.verhnayaPanel.Name = "verhnayaPanel";
            this.verhnayaPanel.Size = new System.Drawing.Size(1019, 230);
            this.verhnayaPanel.TabIndex = 4;
            // 
            // zagolovok
            // 
            this.zagolovok.AutoSize = true;
            this.zagolovok.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zagolovok.Location = new System.Drawing.Point(480, 92);
            this.zagolovok.Name = "zagolovok";
            this.zagolovok.Size = new System.Drawing.Size(303, 35);
            this.zagolovok.TabIndex = 1;
            this.zagolovok.Text = "ООО Одежда для ручек";
            // 
            // nijnyaPanel
            // 
            this.nijnyaPanel.Controls.Add(this.nazad);
            this.nijnyaPanel.Location = new System.Drawing.Point(-28, 185);
            this.nijnyaPanel.Name = "nijnyaPanel";
            this.nijnyaPanel.Size = new System.Drawing.Size(1038, 499);
            this.nijnyaPanel.TabIndex = 5;
            // 
            // nazad
            // 
            this.nazad.FlatAppearance.BorderSize = 0;
            this.nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nazad.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nazad.Location = new System.Drawing.Point(48, 401);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(179, 55);
            this.nazad.TabIndex = 6;
            this.nazad.Text = "Назад";
            this.nazad.UseVisualStyleBackColor = true;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // EditMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.verhnayaPanel);
            this.Controls.Add(this.nijnyaPanel);
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "EditMaterial";
            this.Text = "ООО Одежда для ручек - Редактировать материал";
            this.Load += new System.EventHandler(this.EditMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logotip)).EndInit();
            this.verhnayaPanel.ResumeLayout(false);
            this.verhnayaPanel.PerformLayout();
            this.nijnyaPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logotip;
        private System.Windows.Forms.Panel verhnayaPanel;
        private System.Windows.Forms.Label zagolovok;
        private System.Windows.Forms.Panel nijnyaPanel;
        private System.Windows.Forms.Button nazad;
    }
}