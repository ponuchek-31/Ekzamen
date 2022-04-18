
namespace Ekzamen
{
    partial class Katalog
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label описаниеLabel;
            System.Windows.Forms.Label количество_на_складеLabel;
            System.Windows.Forms.Label кол_во_в_магазинеLabel;
            System.Windows.Forms.Label авторLabel;
            System.Windows.Forms.Label жанрLabel;
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label ценаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Katalog));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekzamenDataSet = new Ekzamen.EkzamenDataSet();
            this.книжкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.книжкиTableAdapter = new Ekzamen.EkzamenDataSetTableAdapters.КнижкиTableAdapter();
            this.tableAdapterManager = new Ekzamen.EkzamenDataSetTableAdapters.TableAdapterManager();
            this.книжкиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.каталогBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ekzamenDataSet1 = new Ekzamen.EkzamenDataSet1();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.каталогTableAdapter = new Ekzamen.EkzamenDataSet1TableAdapters.КаталогTableAdapter();
            this.tableAdapterManager1 = new Ekzamen.EkzamenDataSet1TableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.описаниеLabel1 = new System.Windows.Forms.Label();
            this.количество_на_складеLabel1 = new System.Windows.Forms.Label();
            this.кол_во_в_магазинеLabel1 = new System.Windows.Forms.Label();
            this.авторLabel1 = new System.Windows.Forms.Label();
            this.жанрLabel1 = new System.Windows.Forms.Label();
            this.названиеLabel1 = new System.Windows.Forms.Label();
            this.ценаLabel1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.книжкиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            описаниеLabel = new System.Windows.Forms.Label();
            количество_на_складеLabel = new System.Windows.Forms.Label();
            кол_во_в_магазинеLabel = new System.Windows.Forms.Label();
            авторLabel = new System.Windows.Forms.Label();
            жанрLabel = new System.Windows.Forms.Label();
            названиеLabel = new System.Windows.Forms.Label();
            ценаLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ekzamenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книжкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книжкиBindingNavigator)).BeginInit();
            this.книжкиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.каталогBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekzamenDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // описаниеLabel
            // 
            описаниеLabel.AutoSize = true;
            описаниеLabel.Location = new System.Drawing.Point(240, 16);
            описаниеLabel.Name = "описаниеLabel";
            описаниеLabel.Size = new System.Drawing.Size(60, 13);
            описаниеLabel.TabIndex = 19;
            описаниеLabel.Text = "Описание:";
            // 
            // количество_на_складеLabel
            // 
            количество_на_складеLabel.AutoSize = true;
            количество_на_складеLabel.Location = new System.Drawing.Point(13, 85);
            количество_на_складеLabel.Name = "количество_на_складеLabel";
            количество_на_складеLabel.Size = new System.Drawing.Size(123, 13);
            количество_на_складеLabel.TabIndex = 18;
            количество_на_складеLabel.Text = "Количество на складе:";
            // 
            // кол_во_в_магазинеLabel
            // 
            кол_во_в_магазинеLabel.AutoSize = true;
            кол_во_в_магазинеLabel.Location = new System.Drawing.Point(14, 106);
            кол_во_в_магазинеLabel.Name = "кол_во_в_магазинеLabel";
            кол_во_в_магазинеLabel.Size = new System.Drawing.Size(105, 13);
            кол_во_в_магазинеLabel.TabIndex = 17;
            кол_во_в_магазинеLabel.Text = "Кол-во в магазине:";
            // 
            // авторLabel
            // 
            авторLabel.AutoSize = true;
            авторLabel.Location = new System.Drawing.Point(13, 62);
            авторLabel.Name = "авторLabel";
            авторLabel.Size = new System.Drawing.Size(40, 13);
            авторLabel.TabIndex = 16;
            авторLabel.Text = "Автор:";
            // 
            // жанрLabel
            // 
            жанрLabel.AutoSize = true;
            жанрLabel.Location = new System.Drawing.Point(14, 39);
            жанрLabel.Name = "жанрLabel";
            жанрLabel.Size = new System.Drawing.Size(39, 13);
            жанрLabel.TabIndex = 15;
            жанрLabel.Text = "Жанр:";
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Location = new System.Drawing.Point(12, 16);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(60, 13);
            названиеLabel.TabIndex = 14;
            названиеLabel.Text = "Название:";
            // 
            // ценаLabel
            // 
            ценаLabel.AutoSize = true;
            ценаLabel.Location = new System.Drawing.Point(14, 129);
            ценаLabel.Name = "ценаLabel";
            ценаLabel.Size = new System.Drawing.Size(36, 13);
            ценаLabel.TabIndex = 13;
            ценаLabel.Text = "Цена:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.инструментыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 25);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
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
            // ekzamenDataSet
            // 
            this.ekzamenDataSet.DataSetName = "EkzamenDataSet";
            this.ekzamenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // книжкиBindingSource
            // 
            this.книжкиBindingSource.DataMember = "Книжки";
            this.книжкиBindingSource.DataSource = this.ekzamenDataSet;
            // 
            // книжкиTableAdapter
            // 
            this.книжкиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Ekzamen.EkzamenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КнижкиTableAdapter = this.книжкиTableAdapter;
            // 
            // книжкиBindingNavigator
            // 
            this.книжкиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.книжкиBindingNavigator.BindingSource = this.каталогBindingSource;
            this.книжкиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.книжкиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.книжкиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.книжкиBindingNavigatorSaveItem});
            this.книжкиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.книжкиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.книжкиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.книжкиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.книжкиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.книжкиBindingNavigator.Name = "книжкиBindingNavigator";
            this.книжкиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.книжкиBindingNavigator.Size = new System.Drawing.Size(704, 25);
            this.книжкиBindingNavigator.TabIndex = 2;
            this.книжкиBindingNavigator.Text = "bindingNavigator1";
            this.книжкиBindingNavigator.RefreshItems += new System.EventHandler(this.книжкиBindingNavigator_RefreshItems);
            // 
            // каталогBindingSource
            // 
            this.каталогBindingSource.DataMember = "Каталог";
            this.каталогBindingSource.DataSource = this.ekzamenDataSet1;
            // 
            // ekzamenDataSet1
            // 
            this.ekzamenDataSet1.DataSetName = "EkzamenDataSet1";
            this.ekzamenDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // каталогTableAdapter
            // 
            this.каталогTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = Ekzamen.EkzamenDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.КаталогTableAdapter = this.каталогTableAdapter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(описаниеLabel);
            this.groupBox1.Controls.Add(this.описаниеLabel1);
            this.groupBox1.Controls.Add(количество_на_складеLabel);
            this.groupBox1.Controls.Add(this.количество_на_складеLabel1);
            this.groupBox1.Controls.Add(кол_во_в_магазинеLabel);
            this.groupBox1.Controls.Add(this.кол_во_в_магазинеLabel1);
            this.groupBox1.Controls.Add(авторLabel);
            this.groupBox1.Controls.Add(this.авторLabel1);
            this.groupBox1.Controls.Add(жанрLabel);
            this.groupBox1.Controls.Add(this.жанрLabel1);
            this.groupBox1.Controls.Add(названиеLabel);
            this.groupBox1.Controls.Add(this.названиеLabel1);
            this.groupBox1.Controls.Add(ценаLabel);
            this.groupBox1.Controls.Add(this.ценаLabel1);
            this.groupBox1.Location = new System.Drawing.Point(129, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 203);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить в корзину";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // описаниеLabel1
            // 
            this.описаниеLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.каталогBindingSource, "Описание", true));
            this.описаниеLabel1.Location = new System.Drawing.Point(302, 16);
            this.описаниеLabel1.Name = "описаниеLabel1";
            this.описаниеLabel1.Size = new System.Drawing.Size(273, 126);
            this.описаниеLabel1.TabIndex = 20;
            this.описаниеLabel1.Text = "label1";
            // 
            // количество_на_складеLabel1
            // 
            this.количество_на_складеLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.каталогBindingSource, "Количество на складе", true));
            this.количество_на_складеLabel1.Location = new System.Drawing.Point(142, 85);
            this.количество_на_складеLabel1.Name = "количество_на_складеLabel1";
            this.количество_на_складеLabel1.Size = new System.Drawing.Size(100, 23);
            this.количество_на_складеLabel1.TabIndex = 19;
            this.количество_на_складеLabel1.Text = "label1";
            // 
            // кол_во_в_магазинеLabel1
            // 
            this.кол_во_в_магазинеLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.каталогBindingSource, "Кол-во в магазине", true));
            this.кол_во_в_магазинеLabel1.Location = new System.Drawing.Point(125, 106);
            this.кол_во_в_магазинеLabel1.Name = "кол_во_в_магазинеLabel1";
            this.кол_во_в_магазинеLabel1.Size = new System.Drawing.Size(100, 23);
            this.кол_во_в_магазинеLabel1.TabIndex = 18;
            this.кол_во_в_магазинеLabel1.Text = "label1";
            // 
            // авторLabel1
            // 
            this.авторLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.каталогBindingSource, "Автор", true));
            this.авторLabel1.Location = new System.Drawing.Point(59, 62);
            this.авторLabel1.Name = "авторLabel1";
            this.авторLabel1.Size = new System.Drawing.Size(100, 23);
            this.авторLabel1.TabIndex = 17;
            this.авторLabel1.Text = "label1";
            // 
            // жанрLabel1
            // 
            this.жанрLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.каталогBindingSource, "Жанр", true));
            this.жанрLabel1.Location = new System.Drawing.Point(59, 39);
            this.жанрLabel1.Name = "жанрLabel1";
            this.жанрLabel1.Size = new System.Drawing.Size(100, 23);
            this.жанрLabel1.TabIndex = 16;
            this.жанрLabel1.Text = "label1";
            // 
            // названиеLabel1
            // 
            this.названиеLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.каталогBindingSource, "Название", true));
            this.названиеLabel1.Location = new System.Drawing.Point(78, 16);
            this.названиеLabel1.Name = "названиеLabel1";
            this.названиеLabel1.Size = new System.Drawing.Size(156, 23);
            this.названиеLabel1.TabIndex = 15;
            this.названиеLabel1.Text = "label1";
            // 
            // ценаLabel1
            // 
            this.ценаLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.каталогBindingSource, "Цена", true));
            this.ценаLabel1.Location = new System.Drawing.Point(56, 129);
            this.ценаLabel1.Name = "ценаLabel1";
            this.ценаLabel1.Size = new System.Drawing.Size(100, 23);
            this.ценаLabel1.TabIndex = 14;
            this.ценаLabel1.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(425, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(267, 24);
            this.button2.TabIndex = 22;
            this.button2.Text = "Посмотреть содержимое корзины";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(38, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(648, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Количество товаров:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(554, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Сумма товаров:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // книжкиBindingNavigatorSaveItem
            // 
            this.книжкиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.книжкиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("книжкиBindingNavigatorSaveItem.Image")));
            this.книжкиBindingNavigatorSaveItem.Name = "книжкиBindingNavigatorSaveItem";
            this.книжкиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.книжкиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.книжкиBindingNavigatorSaveItem.Click += new System.EventHandler(this.книжкиBindingNavigatorSaveItem_Click);
            // 
            // Katalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 365);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.книжкиBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Katalog";
            this.Text = "Книжный магазин";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ekzamenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книжкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книжкиBindingNavigator)).EndInit();
            this.книжкиBindingNavigator.ResumeLayout(false);
            this.книжкиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.каталогBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekzamenDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private EkzamenDataSet ekzamenDataSet;
        private System.Windows.Forms.BindingSource книжкиBindingSource;
        private EkzamenDataSetTableAdapters.КнижкиTableAdapter книжкиTableAdapter;
        private EkzamenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator книжкиBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton книжкиBindingNavigatorSaveItem;
        private EkzamenDataSet1 ekzamenDataSet1;
        private System.Windows.Forms.BindingSource каталогBindingSource;
        private EkzamenDataSet1TableAdapters.КаталогTableAdapter каталогTableAdapter;
        private EkzamenDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label описаниеLabel1;
        private System.Windows.Forms.Label количество_на_складеLabel1;
        private System.Windows.Forms.Label кол_во_в_магазинеLabel1;
        private System.Windows.Forms.Label авторLabel1;
        private System.Windows.Forms.Label жанрLabel1;
        private System.Windows.Forms.Label названиеLabel1;
        private System.Windows.Forms.Label ценаLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

