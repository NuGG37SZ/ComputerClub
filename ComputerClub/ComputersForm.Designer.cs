namespace ComputerClub
{
    partial class ComputersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.computersGrid = new System.Windows.Forms.DataGridView();
            this.panelСontrol = new System.Windows.Forms.GroupBox();
            this.deleteComputer = new System.Windows.Forms.Button();
            this.updateComputer = new System.Windows.Forms.Button();
            this.addComputer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hallNameBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.computerIdBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.computersGrid)).BeginInit();
            this.panelСontrol.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // computersGrid
            // 
            this.computersGrid.BackgroundColor = System.Drawing.Color.Black;
            this.computersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.computersGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.computersGrid.Location = new System.Drawing.Point(0, 0);
            this.computersGrid.Name = "computersGrid";
            this.computersGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.computersGrid.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.computersGrid.RowTemplate.Height = 24;
            this.computersGrid.Size = new System.Drawing.Size(1033, 372);
            this.computersGrid.TabIndex = 0;
            // 
            // panelСontrol
            // 
            this.panelСontrol.Controls.Add(this.deleteComputer);
            this.panelСontrol.Controls.Add(this.updateComputer);
            this.panelСontrol.Controls.Add(this.addComputer);
            this.panelСontrol.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.panelСontrol.ForeColor = System.Drawing.Color.White;
            this.panelСontrol.Location = new System.Drawing.Point(496, 19);
            this.panelСontrol.Name = "panelСontrol";
            this.panelСontrol.Size = new System.Drawing.Size(217, 159);
            this.panelСontrol.TabIndex = 1;
            this.panelСontrol.TabStop = false;
            this.panelСontrol.Text = "Действия над ПК";
            // 
            // deleteComputer
            // 
            this.deleteComputer.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.deleteComputer.ForeColor = System.Drawing.Color.Black;
            this.deleteComputer.Location = new System.Drawing.Point(6, 114);
            this.deleteComputer.Name = "deleteComputer";
            this.deleteComputer.Size = new System.Drawing.Size(205, 38);
            this.deleteComputer.TabIndex = 2;
            this.deleteComputer.Text = "Удалить ПК";
            this.deleteComputer.UseVisualStyleBackColor = true;
            this.deleteComputer.Click += new System.EventHandler(this.DeleteComputer_Click);
            // 
            // updateComputer
            // 
            this.updateComputer.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.updateComputer.ForeColor = System.Drawing.Color.Black;
            this.updateComputer.Location = new System.Drawing.Point(6, 70);
            this.updateComputer.Name = "updateComputer";
            this.updateComputer.Size = new System.Drawing.Size(205, 38);
            this.updateComputer.TabIndex = 1;
            this.updateComputer.Text = "Обновить ПК";
            this.updateComputer.UseVisualStyleBackColor = true;
            this.updateComputer.Click += new System.EventHandler(this.UpdateComputer_Click);
            // 
            // addComputer
            // 
            this.addComputer.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.addComputer.ForeColor = System.Drawing.Color.Black;
            this.addComputer.Location = new System.Drawing.Point(6, 26);
            this.addComputer.Name = "addComputer";
            this.addComputer.Size = new System.Drawing.Size(205, 38);
            this.addComputer.TabIndex = 0;
            this.addComputer.Text = "Добавить ПК";
            this.addComputer.UseVisualStyleBackColor = true;
            this.addComputer.Click += new System.EventHandler(this.AddComputer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(729, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Поиск";
            // 
            // hallNameBox
            // 
            this.hallNameBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.hallNameBox.FormattingEnabled = true;
            this.hallNameBox.Location = new System.Drawing.Point(185, 82);
            this.hallNameBox.Name = "hallNameBox";
            this.hallNameBox.Size = new System.Drawing.Size(282, 31);
            this.hallNameBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(251, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Текущие данные";
            // 
            // computerIdBox
            // 
            this.computerIdBox.DropDownHeight = 80;
            this.computerIdBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.computerIdBox.FormattingEnabled = true;
            this.computerIdBox.IntegralHeight = false;
            this.computerIdBox.ItemHeight = 23;
            this.computerIdBox.Location = new System.Drawing.Point(185, 45);
            this.computerIdBox.Name = "computerIdBox";
            this.computerIdBox.Size = new System.Drawing.Size(282, 31);
            this.computerIdBox.TabIndex = 16;
            this.computerIdBox.SelectedValueChanged += new System.EventHandler(this.ComputerIdBox_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.computerIdBox);
            this.panel1.Controls.Add(this.hallNameBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panelСontrol);
            this.panel1.Location = new System.Drawing.Point(36, 402);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 194);
            this.panel1.TabIndex = 18;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.searchBox.Location = new System.Drawing.Point(733, 43);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(205, 33);
            this.searchBox.TabIndex = 21;
            this.searchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(130, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Зал";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(108, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Номер";
            // 
            // ComputersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1033, 626);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.computersGrid);
            this.Name = "ComputersForm";
            this.Text = "ComputersForm";
            ((System.ComponentModel.ISupportInitialize)(this.computersGrid)).EndInit();
            this.panelСontrol.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView computersGrid;
        private System.Windows.Forms.GroupBox panelСontrol;
        private System.Windows.Forms.Button addComputer;
        private System.Windows.Forms.Button deleteComputer;
        private System.Windows.Forms.Button updateComputer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox hallNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox computerIdBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchBox;
    }
}