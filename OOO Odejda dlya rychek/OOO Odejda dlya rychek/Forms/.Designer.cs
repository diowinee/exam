namespace OOO_Odejda_dlya_rychek
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.verhnayaPanel = new System.Windows.Forms.Panel();
            this.zagolovok = new System.Windows.Forms.Label();
            this.logotip = new System.Windows.Forms.PictureBox();
            this.nijnyaPanel = new System.Windows.Forms.Panel();
            this.redactirovat = new System.Windows.Forms.Button();
            this.dobavitMaterial = new System.Windows.Forms.Button();
            this.vivodMaterialov = new System.Windows.Forms.DataGridView();
            this.filtracia = new System.Windows.Forms.ComboBox();
            this.sortirovka = new System.Windows.Forms.ComboBox();
            this.poisk = new System.Windows.Forms.TextBox();
            this.verhnayaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logotip)).BeginInit();
            this.nijnyaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vivodMaterialov)).BeginInit();
            this.SuspendLayout();
            // 
            // verhnayaPanel
            // 
            this.verhnayaPanel.Controls.Add(this.zagolovok);
            this.verhnayaPanel.Controls.Add(this.logotip);
            this.verhnayaPanel.Location = new System.Drawing.Point(-9, -9);
            this.verhnayaPanel.Name = "verhnayaPanel";
            this.verhnayaPanel.Size = new System.Drawing.Size(1019, 230);
            this.verhnayaPanel.TabIndex = 0;
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
            // nijnyaPanel
            // 
            this.nijnyaPanel.Controls.Add(this.redactirovat);
            this.nijnyaPanel.Controls.Add(this.dobavitMaterial);
            this.nijnyaPanel.Controls.Add(this.vivodMaterialov);
            this.nijnyaPanel.Controls.Add(this.filtracia);
            this.nijnyaPanel.Controls.Add(this.sortirovka);
            this.nijnyaPanel.Controls.Add(this.poisk);
            this.nijnyaPanel.Location = new System.Drawing.Point(-15, 207);
            this.nijnyaPanel.Name = "nijnyaPanel";
            this.nijnyaPanel.Size = new System.Drawing.Size(1038, 499);
            this.nijnyaPanel.TabIndex = 1;
            // 
            // redactirovat
            // 
            this.redactirovat.FlatAppearance.BorderSize = 0;
            this.redactirovat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redactirovat.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redactirovat.Location = new System.Drawing.Point(753, 342);
            this.redactirovat.Name = "redactirovat";
            this.redactirovat.Size = new System.Drawing.Size(179, 55);
            this.redactirovat.TabIndex = 5;
            this.redactirovat.Text = "Редактировать материал";
            this.redactirovat.UseVisualStyleBackColor = true;
            this.redactirovat.Click += new System.EventHandler(this.redactirovat_Click);
            // 
            // dobavitMaterial
            // 
            this.dobavitMaterial.FlatAppearance.BorderSize = 0;
            this.dobavitMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dobavitMaterial.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dobavitMaterial.Location = new System.Drawing.Point(75, 342);
            this.dobavitMaterial.Name = "dobavitMaterial";
            this.dobavitMaterial.Size = new System.Drawing.Size(179, 55);
            this.dobavitMaterial.TabIndex = 4;
            this.dobavitMaterial.Text = "Добавить материал";
            this.dobavitMaterial.UseVisualStyleBackColor = true;
            this.dobavitMaterial.Click += new System.EventHandler(this.dobavitMaterial_Click);
            // 
            // vivodMaterialov
            // 
            this.vivodMaterialov.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vivodMaterialov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vivodMaterialov.Location = new System.Drawing.Point(56, 83);
            this.vivodMaterialov.Name = "vivodMaterialov";
            this.vivodMaterialov.RowHeadersWidth = 51;
            this.vivodMaterialov.RowTemplate.Height = 24;
            this.vivodMaterialov.Size = new System.Drawing.Size(898, 227);
            this.vivodMaterialov.TabIndex = 3;
            // 
            // filtracia
            // 
            this.filtracia.FormattingEnabled = true;
            this.filtracia.Location = new System.Drawing.Point(753, 30);
            this.filtracia.Name = "filtracia";
            this.filtracia.Size = new System.Drawing.Size(201, 24);
            this.filtracia.TabIndex = 2;
            this.filtracia.SelectedIndexChanged += new System.EventHandler(this.filtracia_SelectedIndexChanged);
            // 
            // sortirovka
            // 
            this.sortirovka.FormattingEnabled = true;
            this.sortirovka.Location = new System.Drawing.Point(511, 30);
            this.sortirovka.Name = "sortirovka";
            this.sortirovka.Size = new System.Drawing.Size(201, 24);
            this.sortirovka.TabIndex = 1;
            this.sortirovka.SelectedIndexChanged += new System.EventHandler(this.sortirovka_SelectedIndexChanged);
            // 
            // poisk
            // 
            this.poisk.Location = new System.Drawing.Point(56, 32);
            this.poisk.Name = "poisk";
            this.poisk.Size = new System.Drawing.Size(410, 22);
            this.poisk.TabIndex = 0;
            this.poisk.TextChanged += new System.EventHandler(this.poisk_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.nijnyaPanel);
            this.Controls.Add(this.verhnayaPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Form1";
            this.Text = "ООО Одежда для ручек - Главное меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.verhnayaPanel.ResumeLayout(false);
            this.verhnayaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logotip)).EndInit();
            this.nijnyaPanel.ResumeLayout(false);
            this.nijnyaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vivodMaterialov)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel verhnayaPanel;
        private System.Windows.Forms.Panel nijnyaPanel;
        private System.Windows.Forms.PictureBox logotip;
        private System.Windows.Forms.Label zagolovok;
        private System.Windows.Forms.Button redactirovat;
        private System.Windows.Forms.Button dobavitMaterial;
        private System.Windows.Forms.DataGridView vivodMaterialov;
        private System.Windows.Forms.ComboBox filtracia;
        private System.Windows.Forms.ComboBox sortirovka;
        private System.Windows.Forms.TextBox poisk;
    }
}

