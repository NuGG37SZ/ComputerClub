namespace ComputerClub
{
    partial class SessionsForm
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
            this.swapPanelForm = new System.Windows.Forms.Panel();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.isBusyBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteSession = new System.Windows.Forms.Button();
            this.addSession = new System.Windows.Forms.Button();
            this.updateSession = new System.Windows.Forms.Button();
            this.endPlay = new System.Windows.Forms.DateTimePicker();
            this.startPlay = new System.Windows.Forms.DateTimePicker();
            this.sessionBox = new System.Windows.Forms.ComboBox();
            this.computerBox = new System.Windows.Forms.ComboBox();
            this.clientBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.computersRoomsPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckSessions = new System.Windows.Forms.Timer(this.components);
            this.swapPanelForm.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.computersRoomsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // swapPanelForm
            // 
            this.swapPanelForm.BackColor = System.Drawing.Color.Gray;
            this.swapPanelForm.Controls.Add(this.controlPanel);
            this.swapPanelForm.Controls.Add(this.computersRoomsPanel);
            this.swapPanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swapPanelForm.Location = new System.Drawing.Point(0, 0);
            this.swapPanelForm.Name = "swapPanelForm";
            this.swapPanelForm.Size = new System.Drawing.Size(1039, 672);
            this.swapPanelForm.TabIndex = 2;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.Gray;
            this.controlPanel.Controls.Add(this.label14);
            this.controlPanel.Controls.Add(this.label13);
            this.controlPanel.Controls.Add(this.label12);
            this.controlPanel.Controls.Add(this.label5);
            this.controlPanel.Controls.Add(this.label4);
            this.controlPanel.Controls.Add(this.label2);
            this.controlPanel.Controls.Add(this.isBusyBox);
            this.controlPanel.Controls.Add(this.groupBox1);
            this.controlPanel.Controls.Add(this.endPlay);
            this.controlPanel.Controls.Add(this.startPlay);
            this.controlPanel.Controls.Add(this.sessionBox);
            this.controlPanel.Controls.Add(this.computerBox);
            this.controlPanel.Controls.Add(this.clientBox);
            this.controlPanel.Controls.Add(this.label3);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(0, 447);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1039, 225);
            this.controlPanel.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(304, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 23);
            this.label14.TabIndex = 15;
            this.label14.Text = "Номер ПК";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(12, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 23);
            this.label13.TabIndex = 14;
            this.label13.Text = "Номер сесси";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(304, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 23);
            this.label12.TabIndex = 13;
            this.label12.Text = "Занят ли ПК";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Клиент";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(304, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Конец игры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Старт игры";
            // 
            // isBusyBox
            // 
            this.isBusyBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.isBusyBox.FormattingEnabled = true;
            this.isBusyBox.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.isBusyBox.Location = new System.Drawing.Point(304, 114);
            this.isBusyBox.Name = "isBusyBox";
            this.isBusyBox.Size = new System.Drawing.Size(280, 31);
            this.isBusyBox.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteSession);
            this.groupBox1.Controls.Add(this.addSession);
            this.groupBox1.Controls.Add(this.updateSession);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(774, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 178);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия над сессиями";
            // 
            // deleteSession
            // 
            this.deleteSession.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.deleteSession.ForeColor = System.Drawing.Color.Black;
            this.deleteSession.Location = new System.Drawing.Point(6, 124);
            this.deleteSession.Name = "deleteSession";
            this.deleteSession.Size = new System.Drawing.Size(226, 38);
            this.deleteSession.TabIndex = 8;
            this.deleteSession.Text = "Удалить";
            this.deleteSession.UseVisualStyleBackColor = true;
            this.deleteSession.Click += new System.EventHandler(this.DeleteSession_Click);
            // 
            // addSession
            // 
            this.addSession.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.addSession.ForeColor = System.Drawing.Color.Black;
            this.addSession.Location = new System.Drawing.Point(6, 36);
            this.addSession.Name = "addSession";
            this.addSession.Size = new System.Drawing.Size(226, 38);
            this.addSession.TabIndex = 7;
            this.addSession.Text = "Добавить";
            this.addSession.UseVisualStyleBackColor = true;
            this.addSession.Click += new System.EventHandler(this.AddSession_Click);
            // 
            // updateSession
            // 
            this.updateSession.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.updateSession.ForeColor = System.Drawing.Color.Black;
            this.updateSession.Location = new System.Drawing.Point(6, 80);
            this.updateSession.Name = "updateSession";
            this.updateSession.Size = new System.Drawing.Size(226, 38);
            this.updateSession.TabIndex = 6;
            this.updateSession.Text = "Обновить";
            this.updateSession.UseVisualStyleBackColor = true;
            this.updateSession.Click += new System.EventHandler(this.UpdateSession_Click);
            // 
            // endPlay
            // 
            this.endPlay.CustomFormat = "dd.MM.yyyy HH:mm";
            this.endPlay.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.endPlay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endPlay.Location = new System.Drawing.Point(304, 172);
            this.endPlay.Name = "endPlay";
            this.endPlay.Size = new System.Drawing.Size(282, 27);
            this.endPlay.TabIndex = 7;
            this.endPlay.Value = new System.DateTime(2025, 2, 19, 0, 0, 0, 0);
            // 
            // startPlay
            // 
            this.startPlay.CustomFormat = "dd.MM.yyyy HH:mm";
            this.startPlay.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.startPlay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startPlay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.startPlay.Location = new System.Drawing.Point(12, 172);
            this.startPlay.Name = "startPlay";
            this.startPlay.Size = new System.Drawing.Size(282, 27);
            this.startPlay.TabIndex = 6;
            this.startPlay.Value = new System.DateTime(2025, 2, 21, 0, 0, 0, 0);
            // 
            // sessionBox
            // 
            this.sessionBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.sessionBox.FormattingEnabled = true;
            this.sessionBox.Location = new System.Drawing.Point(16, 53);
            this.sessionBox.Name = "sessionBox";
            this.sessionBox.Size = new System.Drawing.Size(278, 31);
            this.sessionBox.TabIndex = 5;
            this.sessionBox.SelectedValueChanged += new System.EventHandler(this.SessionBox_SelectedValueChanged);
            // 
            // computerBox
            // 
            this.computerBox.DropDownHeight = 70;
            this.computerBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.computerBox.FormattingEnabled = true;
            this.computerBox.IntegralHeight = false;
            this.computerBox.Location = new System.Drawing.Point(304, 53);
            this.computerBox.Name = "computerBox";
            this.computerBox.Size = new System.Drawing.Size(277, 31);
            this.computerBox.TabIndex = 4;
            // 
            // clientBox
            // 
            this.clientBox.DropDownHeight = 70;
            this.clientBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.clientBox.FormattingEnabled = true;
            this.clientBox.IntegralHeight = false;
            this.clientBox.Location = new System.Drawing.Point(12, 113);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(282, 31);
            this.clientBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(227, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Текущие данные";
            // 
            // computersRoomsPanel
            // 
            this.computersRoomsPanel.BackColor = System.Drawing.Color.Black;
            this.computersRoomsPanel.Controls.Add(this.label11);
            this.computersRoomsPanel.Controls.Add(this.label10);
            this.computersRoomsPanel.Controls.Add(this.label9);
            this.computersRoomsPanel.Controls.Add(this.label8);
            this.computersRoomsPanel.Controls.Add(this.label7);
            this.computersRoomsPanel.Controls.Add(this.label6);
            this.computersRoomsPanel.Controls.Add(this.label1);
            this.computersRoomsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.computersRoomsPanel.Location = new System.Drawing.Point(0, 0);
            this.computersRoomsPanel.Name = "computersRoomsPanel";
            this.computersRoomsPanel.Size = new System.Drawing.Size(1039, 447);
            this.computersRoomsPanel.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(866, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 23);
            this.label11.TabIndex = 17;
            this.label11.Text = "STREAM зал";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(72, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 23);
            this.label10.TabIndex = 16;
            this.label10.Text = "STREAM зал";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(472, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "XBOX зал";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(866, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "VIP зал";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(159, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "VIP зал";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(463, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Основной зал";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(413, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текущие сессии";
            // 
            // CheckSessions
            // 
            this.CheckSessions.Tick += new System.EventHandler(this.CheckSessions_Tick);
            // 
            // SessionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 672);
            this.Controls.Add(this.swapPanelForm);
            this.Name = "SessionsForm";
            this.Text = "SessionForm";
            this.swapPanelForm.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.computersRoomsPanel.ResumeLayout(false);
            this.computersRoomsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel swapPanelForm;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteSession;
        private System.Windows.Forms.Button addSession;
        private System.Windows.Forms.Button updateSession;
        private System.Windows.Forms.DateTimePicker endPlay;
        private System.Windows.Forms.DateTimePicker startPlay;
        private System.Windows.Forms.ComboBox sessionBox;
        private System.Windows.Forms.ComboBox computerBox;
        private System.Windows.Forms.ComboBox clientBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel computersRoomsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox isBusyBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer CheckSessions;
    }
}