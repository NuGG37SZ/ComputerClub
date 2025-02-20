namespace ComputerClub
{
    partial class HallsForm
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
            this.hallsGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pricePerHourBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.maxCountBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameHallBox = new System.Windows.Forms.TextBox();
            this.hallsIdBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelСontrol = new System.Windows.Forms.GroupBox();
            this.deleteHall = new System.Windows.Forms.Button();
            this.updateHall = new System.Windows.Forms.Button();
            this.addHall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hallsGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pricePerHourBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxCountBox)).BeginInit();
            this.panelСontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // hallsGrid
            // 
            this.hallsGrid.BackgroundColor = System.Drawing.Color.Black;
            this.hallsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hallsGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.hallsGrid.Location = new System.Drawing.Point(0, 0);
            this.hallsGrid.Name = "hallsGrid";
            this.hallsGrid.RowHeadersWidth = 51;
            this.hallsGrid.RowTemplate.Height = 24;
            this.hallsGrid.Size = new System.Drawing.Size(1033, 372);
            this.hallsGrid.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pricePerHourBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.maxCountBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nameHallBox);
            this.panel1.Controls.Add(this.hallsIdBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panelСontrol);
            this.panel1.Location = new System.Drawing.Point(150, 404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 216);
            this.panel1.TabIndex = 19;
            // 
            // pricePerHourBox
            // 
            this.pricePerHourBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.pricePerHourBox.Location = new System.Drawing.Point(167, 119);
            this.pricePerHourBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.pricePerHourBox.Name = "pricePerHourBox";
            this.pricePerHourBox.Size = new System.Drawing.Size(282, 27);
            this.pricePerHourBox.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(43, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 46);
            this.label5.TabIndex = 32;
            this.label5.Text = "Количество \r\nмест";
            // 
            // maxCountBox
            // 
            this.maxCountBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.maxCountBox.Location = new System.Drawing.Point(167, 156);
            this.maxCountBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.maxCountBox.Name = "maxCountBox";
            this.maxCountBox.Size = new System.Drawing.Size(282, 27);
            this.maxCountBox.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(43, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Номер";
            // 
            // nameHallBox
            // 
            this.nameHallBox.Location = new System.Drawing.Point(167, 82);
            this.nameHallBox.Multiline = true;
            this.nameHallBox.Name = "nameHallBox";
            this.nameHallBox.Size = new System.Drawing.Size(282, 31);
            this.nameHallBox.TabIndex = 18;
            // 
            // hallsIdBox
            // 
            this.hallsIdBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.hallsIdBox.FormattingEnabled = true;
            this.hallsIdBox.Location = new System.Drawing.Point(167, 45);
            this.hallsIdBox.Name = "hallsIdBox";
            this.hallsIdBox.Size = new System.Drawing.Size(282, 31);
            this.hallsIdBox.TabIndex = 16;
            this.hallsIdBox.SelectedValueChanged += new System.EventHandler(this.HallsIdBox_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(233, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Текущие данные";
            // 
            // panelСontrol
            // 
            this.panelСontrol.Controls.Add(this.deleteHall);
            this.panelСontrol.Controls.Add(this.updateHall);
            this.panelСontrol.Controls.Add(this.addHall);
            this.panelСontrol.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.panelСontrol.ForeColor = System.Drawing.Color.White;
            this.panelСontrol.Location = new System.Drawing.Point(491, 19);
            this.panelСontrol.Name = "panelСontrol";
            this.panelСontrol.Size = new System.Drawing.Size(217, 159);
            this.panelСontrol.TabIndex = 1;
            this.panelСontrol.TabStop = false;
            this.panelСontrol.Text = "Действия над Залом";
            // 
            // deleteHall
            // 
            this.deleteHall.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.deleteHall.ForeColor = System.Drawing.Color.Black;
            this.deleteHall.Location = new System.Drawing.Point(6, 114);
            this.deleteHall.Name = "deleteHall";
            this.deleteHall.Size = new System.Drawing.Size(205, 38);
            this.deleteHall.TabIndex = 2;
            this.deleteHall.Text = "Удалить зал";
            this.deleteHall.UseVisualStyleBackColor = true;
            this.deleteHall.Click += new System.EventHandler(this.DeleteHall_Click);
            // 
            // updateHall
            // 
            this.updateHall.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.updateHall.ForeColor = System.Drawing.Color.Black;
            this.updateHall.Location = new System.Drawing.Point(6, 70);
            this.updateHall.Name = "updateHall";
            this.updateHall.Size = new System.Drawing.Size(205, 38);
            this.updateHall.TabIndex = 1;
            this.updateHall.Text = "Обновить зал";
            this.updateHall.UseVisualStyleBackColor = true;
            this.updateHall.Click += new System.EventHandler(this.UpdateHall_Click);
            // 
            // addHall
            // 
            this.addHall.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.addHall.ForeColor = System.Drawing.Color.Black;
            this.addHall.Location = new System.Drawing.Point(6, 26);
            this.addHall.Name = "addHall";
            this.addHall.Size = new System.Drawing.Size(205, 38);
            this.addHall.TabIndex = 0;
            this.addHall.Text = "Добавить зал";
            this.addHall.UseVisualStyleBackColor = true;
            this.addHall.Click += new System.EventHandler(this.AddHall_Click);
            // 
            // HallsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1033, 626);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hallsGrid);
            this.Name = "HallsForm";
            this.Text = "RoomsForm";
            ((System.ComponentModel.ISupportInitialize)(this.hallsGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pricePerHourBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxCountBox)).EndInit();
            this.panelСontrol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView hallsGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox hallsIdBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox panelСontrol;
        private System.Windows.Forms.Button deleteHall;
        private System.Windows.Forms.Button updateHall;
        private System.Windows.Forms.Button addHall;
        private System.Windows.Forms.TextBox nameHallBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown maxCountBox;
        private System.Windows.Forms.NumericUpDown pricePerHourBox;
    }
}