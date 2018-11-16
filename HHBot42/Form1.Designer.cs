namespace HHBot42
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
            this.button1 = new System.Windows.Forms.Button();
            this.ResBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.ColInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Коннект";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResBox
            // 
            this.ResBox.Location = new System.Drawing.Point(43, 12);
            this.ResBox.Multiline = true;
            this.ResBox.Name = "ResBox";
            this.ResBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResBox.Size = new System.Drawing.Size(644, 47);
            this.ResBox.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(268, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Парсинг";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.CName,
            this.Empl,
            this.s_from,
            this.s_to,
            this.ColInfo});
            this.GridView.Location = new System.Drawing.Point(43, 145);
            this.GridView.Name = "GridView";
            this.GridView.Size = new System.Drawing.Size(644, 150);
            this.GridView.TabIndex = 3;
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            // 
            // CName
            // 
            this.CName.HeaderText = "Имя";
            this.CName.Name = "CName";
            // 
            // Empl
            // 
            this.Empl.HeaderText = "Работодатель";
            this.Empl.Name = "Empl";
            // 
            // s_from
            // 
            this.s_from.HeaderText = "Мин зп";
            this.s_from.Name = "s_from";
            // 
            // s_to
            // 
            this.s_to.HeaderText = "Макс зп";
            this.s_to.Name = "s_to";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(56, 115);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(394, 20);
            this.SearchBox.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Location = new System.Drawing.Point(470, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Найти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ColInfo
            // 
            this.ColInfo.HeaderText = "Info";
            this.ColInfo.Name = "ColInfo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 323);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ResBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ResBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empl;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_from;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_to;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInfo;
    }
}

