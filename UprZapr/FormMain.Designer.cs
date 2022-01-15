namespace UprZapr
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStruct = new System.Windows.Forms.ToolStripMenuItem();
            this.enterpriseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sotrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addStruct,
            this.delToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(637, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.loadToolStripMenuItem.Text = "Загрузить";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "Выйти";
            // 
            // addStruct
            // 
            this.addStruct.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterpriseToolStripMenuItem,
            this.departToolStripMenuItem,
            this.sectorToolStripMenuItem,
            this.sotrToolStripMenuItem});
            this.addStruct.Name = "addStruct";
            this.addStruct.Size = new System.Drawing.Size(83, 20);
            this.addStruct.Text = "Добавить ...";
            // 
            // enterpriseToolStripMenuItem
            // 
            this.enterpriseToolStripMenuItem.Name = "enterpriseToolStripMenuItem";
            this.enterpriseToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.enterpriseToolStripMenuItem.Text = "Предприятие";
            this.enterpriseToolStripMenuItem.Click += new System.EventHandler(this.enterpriseToolStripMenuItem_Click);
            // 
            // departToolStripMenuItem
            // 
            this.departToolStripMenuItem.Name = "departToolStripMenuItem";
            this.departToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.departToolStripMenuItem.Text = "Цех/отдел";
            this.departToolStripMenuItem.Click += new System.EventHandler(this.departToolStripMenuItem_Click);
            // 
            // sectorToolStripMenuItem
            // 
            this.sectorToolStripMenuItem.Name = "sectorToolStripMenuItem";
            this.sectorToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sectorToolStripMenuItem.Text = "Участок/бюро";
            this.sectorToolStripMenuItem.Click += new System.EventHandler(this.sectorToolStripMenuItem_Click);
            // 
            // sotrToolStripMenuItem
            // 
            this.sotrToolStripMenuItem.Name = "sotrToolStripMenuItem";
            this.sotrToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sotrToolStripMenuItem.Text = "Сотрудника";
            this.sotrToolStripMenuItem.Click += new System.EventHandler(this.sotrToolStripMenuItem_Click);
            // 
            // delToolStripMenuItem
            // 
            this.delToolStripMenuItem.Name = "delToolStripMenuItem";
            this.delToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.delToolStripMenuItem.Text = "Удалить";
            this.delToolStripMenuItem.Click += new System.EventHandler(this.delToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(12, 40);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(615, 384);
            this.treeView1.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 433);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Структура предприятия";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStruct;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem enterpriseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sotrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delToolStripMenuItem;
    }
}

