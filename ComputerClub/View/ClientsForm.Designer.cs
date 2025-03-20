namespace ComputerClub
{
    partial class ClientsForm
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
            this.clientsGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.discountBox = new System.Windows.Forms.NumericUpDown();
            this.balanceBox = new System.Windows.Forms.NumericUpDown();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.clientIdBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelСontrol = new System.Windows.Forms.GroupBox();
            this.deleteClient = new System.Windows.Forms.Button();
            this.updateClient = new System.Windows.Forms.Button();
            this.addClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceBox)).BeginInit();
            this.panelСontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientsGrid
            // 
            this.clientsGrid.BackgroundColor = System.Drawing.Color.Black;
            this.clientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientsGrid.Location = new System.Drawing.Point(0, 0);
            this.clientsGrid.Name = "clientsGrid";
            this.clientsGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientsGrid.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.clientsGrid.RowTemplate.Height = 24;
            this.clientsGrid.Size = new System.Drawing.Size(1033, 372);
            this.clientsGrid.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.discountBox);
            this.panel1.Controls.Add(this.balanceBox);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.phoneBox);
            this.panel1.Controls.Add(this.loginBox);
            this.panel1.Controls.Add(this.clientIdBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panelСontrol);
            this.panel1.Location = new System.Drawing.Point(80, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 236);
            this.panel1.TabIndex = 19;
            // 
            // discountBox
            // 
            this.discountBox.DecimalPlaces = 2;
            this.discountBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.discountBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.discountBox.Location = new System.Drawing.Point(156, 109);
            this.discountBox.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.discountBox.Name = "discountBox";
            this.discountBox.Size = new System.Drawing.Size(282, 27);
            this.discountBox.TabIndex = 31;
            // 
            // balanceBox
            // 
            this.balanceBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.balanceBox.Location = new System.Drawing.Point(156, 178);
            this.balanceBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.balanceBox.Name = "balanceBox";
            this.balanceBox.Size = new System.Drawing.Size(282, 27);
            this.balanceBox.TabIndex = 30;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(719, 48);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(181, 35);
            this.searchBox.TabIndex = 29;
            this.searchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(77, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Номер";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(71, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Баланс";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(56, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(70, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Скидка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(81, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Логин";
            // 
            // phoneBox
            // 
            this.phoneBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.phoneBox.Location = new System.Drawing.Point(156, 141);
            this.phoneBox.Multiline = true;
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(282, 31);
            this.phoneBox.TabIndex = 21;
            // 
            // loginBox
            // 
            this.loginBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.loginBox.Location = new System.Drawing.Point(156, 72);
            this.loginBox.Multiline = true;
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(282, 31);
            this.loginBox.TabIndex = 19;
            // 
            // clientIdBox
            // 
            this.clientIdBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.clientIdBox.FormattingEnabled = true;
            this.clientIdBox.Location = new System.Drawing.Point(156, 35);
            this.clientIdBox.Name = "clientIdBox";
            this.clientIdBox.Size = new System.Drawing.Size(282, 31);
            this.clientIdBox.TabIndex = 16;
            this.clientIdBox.SelectedValueChanged += new System.EventHandler(this.ClientIdBox_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(222, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Текущие данные";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(715, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Поиск";
            // 
            // panelСontrol
            // 
            this.panelСontrol.Controls.Add(this.deleteClient);
            this.panelСontrol.Controls.Add(this.updateClient);
            this.panelСontrol.Controls.Add(this.addClient);
            this.panelСontrol.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.panelСontrol.ForeColor = System.Drawing.Color.White;
            this.panelСontrol.Location = new System.Drawing.Point(471, 22);
            this.panelСontrol.Name = "panelСontrol";
            this.panelСontrol.Size = new System.Drawing.Size(217, 159);
            this.panelСontrol.TabIndex = 1;
            this.panelСontrol.TabStop = false;
            this.panelСontrol.Text = "Действия над Клиентом";
            // 
            // deleteClient
            // 
            this.deleteClient.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.deleteClient.ForeColor = System.Drawing.Color.Black;
            this.deleteClient.Location = new System.Drawing.Point(6, 114);
            this.deleteClient.Name = "deleteClient";
            this.deleteClient.Size = new System.Drawing.Size(205, 38);
            this.deleteClient.TabIndex = 2;
            this.deleteClient.Text = "Удалить клиента";
            this.deleteClient.UseVisualStyleBackColor = true;
            this.deleteClient.Click += new System.EventHandler(this.DeleteClient_Click);
            // 
            // updateClient
            // 
            this.updateClient.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.updateClient.ForeColor = System.Drawing.Color.Black;
            this.updateClient.Location = new System.Drawing.Point(6, 70);
            this.updateClient.Name = "updateClient";
            this.updateClient.Size = new System.Drawing.Size(205, 38);
            this.updateClient.TabIndex = 1;
            this.updateClient.Text = "Обновить клиента";
            this.updateClient.UseVisualStyleBackColor = true;
            this.updateClient.Click += new System.EventHandler(this.UpdateClient_Click);
            // 
            // addClient
            // 
            this.addClient.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.addClient.ForeColor = System.Drawing.Color.Black;
            this.addClient.Location = new System.Drawing.Point(6, 26);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(205, 38);
            this.addClient.TabIndex = 0;
            this.addClient.Text = "Добавить клиента";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1033, 626);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clientsGrid);
            this.Name = "ClientsForm";
            this.Text = "ClientsForm";
            ((System.ComponentModel.ISupportInitialize)(this.clientsGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceBox)).EndInit();
            this.panelСontrol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView clientsGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox clientIdBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox panelСontrol;
        private System.Windows.Forms.Button deleteClient;
        private System.Windows.Forms.Button updateClient;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.NumericUpDown balanceBox;
        private System.Windows.Forms.NumericUpDown discountBox;
    }
}