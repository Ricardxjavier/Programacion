namespace TraductorWinForms
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

        private void InitializeComponent()
        {
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonTranslate = new System.Windows.Forms.Button();
            this.dataGridViewTranslations = new System.Windows.Forms.DataGridView();
            this.LanguageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TranslationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStudentInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTranslations)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(25, 40);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(300, 23);
            this.textBoxInput.TabIndex = 0;
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Location = new System.Drawing.Point(340, 40);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(75, 23);
            this.buttonTranslate.TabIndex = 1;
            this.buttonTranslate.Text = "Traducir";
            this.buttonTranslate.UseVisualStyleBackColor = true;
            this.buttonTranslate.Click += new System.EventHandler(this.buttonTranslate_Click);
            // 
            // dataGridViewTranslations
            // 
            this.dataGridViewTranslations.AllowUserToAddRows = false;
            this.dataGridViewTranslations.AllowUserToDeleteRows = false;
            this.dataGridViewTranslations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTranslations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LanguageColumn,
            this.TranslationColumn});
            this.dataGridViewTranslations.Location = new System.Drawing.Point(25, 80);
            this.dataGridViewTranslations.Name = "dataGridViewTranslations";
            this.dataGridViewTranslations.ReadOnly = true;
            this.dataGridViewTranslations.Size = new System.Drawing.Size(390, 150);
            this.dataGridViewTranslations.TabIndex = 2;
            // 
            // LanguageColumn
            // 
            this.LanguageColumn.HeaderText = "Idioma";
            this.LanguageColumn.Name = "LanguageColumn";
            this.LanguageColumn.ReadOnly = true;
            this.LanguageColumn.Width = 120;
            // 
            // TranslationColumn
            // 
            this.TranslationColumn.HeaderText = "Traducción";
            this.TranslationColumn.Name = "TranslationColumn";
            this.TranslationColumn.ReadOnly = true;
            this.TranslationColumn.Width = 240;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Texto a traducir (ES):";
            // 
            // labelStudentInfo
            // 
            this.labelStudentInfo.AutoSize = true;
            this.labelStudentInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelStudentInfo.Location = new System.Drawing.Point(25, 240);
            this.labelStudentInfo.Name = "labelStudentInfo";
            this.labelStudentInfo.Size = new System.Drawing.Size(190, 15);
            this.labelStudentInfo.TabIndex = 4;
            this.labelStudentInfo.Text = "Ricardo Javier Frias - Matrícula: #2022-2099";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 270);
            this.Controls.Add(this.labelStudentInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTranslations);
            this.Controls.Add(this.buttonTranslate);
            this.Controls.Add(this.textBoxInput);
            this.Name = "MainForm";
            this.Text = "Traductor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTranslations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonTranslate;
        private System.Windows.Forms.DataGridView dataGridViewTranslations;
        private System.Windows.Forms.DataGridViewTextBoxColumn LanguageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TranslationColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStudentInfo;
    }
}
