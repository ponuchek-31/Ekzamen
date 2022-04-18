
namespace Ekzamen
{
    partial class Korzina
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Korzina));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.корзинаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ekzamenDataSet2 = new Ekzamen.EkzamenDataSet2();
            this.корзинаTableAdapter = new Ekzamen.EkzamenDataSet2TableAdapters.КорзинаTableAdapter();
            this.Delett = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.izmeneni = new System.Windows.Forms.Button();
            this.ekzamenDataSet3 = new Ekzamen.EkzamenDataSet3();
            this.корзинаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.корзинаTableAdapter1 = new Ekzamen.EkzamenDataSet3TableAdapters.КорзинаTableAdapter();
            this.ekzamenDataSet4 = new Ekzamen.EkzamenDataSet4();
            this.корзинаBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.корзинаTableAdapter2 = new Ekzamen.EkzamenDataSet4TableAdapters.КорзинаTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерзаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.корзинаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekzamenDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekzamenDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.корзинаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekzamenDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.корзинаBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.инструментыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьToolStripMenuItem});
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            // 
            // корзинаBindingSource
            // 
            this.корзинаBindingSource.DataMember = "Корзина";
            this.корзинаBindingSource.DataSource = this.ekzamenDataSet2;
            // 
            // ekzamenDataSet2
            // 
            this.ekzamenDataSet2.DataSetName = "EkzamenDataSet2";
            this.ekzamenDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // корзинаTableAdapter
            // 
            this.корзинаTableAdapter.ClearBeforeFill = true;
            // 
            // Delett
            // 
            this.Delett.Location = new System.Drawing.Point(388, 334);
            this.Delett.Name = "Delett";
            this.Delett.Size = new System.Drawing.Size(75, 23);
            this.Delett.TabIndex = 7;
            this.Delett.Text = "Удалить";
            this.Delett.UseVisualStyleBackColor = true;
            this.Delett.Click += new System.EventHandler(this.Delett_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 334);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 9;
            this.Back.Text = "<<Каталог";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // izmeneni
            // 
            this.izmeneni.Location = new System.Drawing.Point(138, 334);
            this.izmeneni.Name = "izmeneni";
            this.izmeneni.Size = new System.Drawing.Size(75, 23);
            this.izmeneni.TabIndex = 10;
            this.izmeneni.Text = "Изменить";
            this.izmeneni.UseVisualStyleBackColor = true;
            this.izmeneni.Click += new System.EventHandler(this.izmeneni_Click);
            // 
            // ekzamenDataSet3
            // 
            this.ekzamenDataSet3.DataSetName = "EkzamenDataSet3";
            this.ekzamenDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // корзинаBindingSource1
            // 
            this.корзинаBindingSource1.DataMember = "Корзина";
            this.корзинаBindingSource1.DataSource = this.ekzamenDataSet3;
            // 
            // корзинаTableAdapter1
            // 
            this.корзинаTableAdapter1.ClearBeforeFill = true;
            // 
            // ekzamenDataSet4
            // 
            this.ekzamenDataSet4.DataSetName = "EkzamenDataSet4";
            this.ekzamenDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // корзинаBindingSource2
            // 
            this.корзинаBindingSource2.DataMember = "Корзина";
            this.корзинаBindingSource2.DataSource = this.ekzamenDataSet4;
            // 
            // корзинаTableAdapter2
            // 
            this.корзинаTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.номерзаказаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.корзинаBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(21, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            // 
            // номерзаказаDataGridViewTextBoxColumn
            // 
            this.номерзаказаDataGridViewTextBoxColumn.DataPropertyName = "Номер_заказа";
            this.номерзаказаDataGridViewTextBoxColumn.HeaderText = "Номер_заказа";
            this.номерзаказаDataGridViewTextBoxColumn.Name = "номерзаказаDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Сделать заказ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Korzina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 369);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.izmeneni);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Delett);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Korzina";
            this.Text = "Корзина";
            this.Load += new System.EventHandler(this.Korzina_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.корзинаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekzamenDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekzamenDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.корзинаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekzamenDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.корзинаBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private EkzamenDataSet2 ekzamenDataSet2;
        private System.Windows.Forms.BindingSource корзинаBindingSource;
        private EkzamenDataSet2TableAdapters.КорзинаTableAdapter корзинаTableAdapter;
        private System.Windows.Forms.Button Delett;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button izmeneni;
        private EkzamenDataSet3 ekzamenDataSet3;
        private System.Windows.Forms.BindingSource корзинаBindingSource1;
        private EkzamenDataSet3TableAdapters.КорзинаTableAdapter корзинаTableAdapter1;
        private EkzamenDataSet4 ekzamenDataSet4;
        private System.Windows.Forms.BindingSource корзинаBindingSource2;
        private EkzamenDataSet4TableAdapters.КорзинаTableAdapter корзинаTableAdapter2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерзаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}