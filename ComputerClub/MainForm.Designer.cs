namespace ComputerClub
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userLabel = new System.Windows.Forms.Label();
            this.clientsButton = new System.Windows.Forms.Button();
            this.hallsButton = new System.Windows.Forms.Button();
            this.computersButton = new System.Windows.Forms.Button();
            this.sessionsButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.swapPanelForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Fuchsia;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.clientsButton);
            this.panel1.Controls.Add(this.hallsButton);
            this.panel1.Controls.Add(this.computersButton);
            this.panel1.Controls.Add(this.sessionsButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 673);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.userLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.panel3.Location = new System.Drawing.Point(0, 627);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 46);
            this.panel3.TabIndex = 6;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.ForeColor = System.Drawing.Color.White;
            this.userLabel.Location = new System.Drawing.Point(24, 14);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(163, 23);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "Добро пожаловать!";
            // 
            // clientsButton
            // 
            this.clientsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clientsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientsButton.FlatAppearance.BorderSize = 0;
            this.clientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsButton.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.clientsButton.ForeColor = System.Drawing.Color.White;
            this.clientsButton.Image = ((System.Drawing.Image)(resources.GetObject("clientsButton.Image")));
            this.clientsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientsButton.Location = new System.Drawing.Point(0, 302);
            this.clientsButton.Name = "clientsButton";
            this.clientsButton.Size = new System.Drawing.Size(211, 47);
            this.clientsButton.TabIndex = 5;
            this.clientsButton.Text = "Посетители";
            this.clientsButton.UseVisualStyleBackColor = true;
            this.clientsButton.Click += new System.EventHandler(this.ClientsButton_Click);
            // 
            // hallsButton
            // 
            this.hallsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hallsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.hallsButton.FlatAppearance.BorderSize = 0;
            this.hallsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hallsButton.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.hallsButton.ForeColor = System.Drawing.Color.White;
            this.hallsButton.Image = ((System.Drawing.Image)(resources.GetObject("hallsButton.Image")));
            this.hallsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hallsButton.Location = new System.Drawing.Point(0, 255);
            this.hallsButton.Name = "hallsButton";
            this.hallsButton.Size = new System.Drawing.Size(211, 47);
            this.hallsButton.TabIndex = 4;
            this.hallsButton.Text = "Залы";
            this.hallsButton.UseVisualStyleBackColor = true;
            this.hallsButton.Click += new System.EventHandler(this.HallsButton_Click);
            // 
            // computersButton
            // 
            this.computersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.computersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.computersButton.FlatAppearance.BorderSize = 0;
            this.computersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.computersButton.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.computersButton.ForeColor = System.Drawing.Color.White;
            this.computersButton.Image = ((System.Drawing.Image)(resources.GetObject("computersButton.Image")));
            this.computersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.computersButton.Location = new System.Drawing.Point(0, 208);
            this.computersButton.Name = "computersButton";
            this.computersButton.Size = new System.Drawing.Size(211, 47);
            this.computersButton.TabIndex = 3;
            this.computersButton.Text = "ПК";
            this.computersButton.UseVisualStyleBackColor = true;
            this.computersButton.Click += new System.EventHandler(this.ComputersButton_Click);
            // 
            // sessionsButton
            // 
            this.sessionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sessionsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.sessionsButton.FlatAppearance.BorderSize = 0;
            this.sessionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sessionsButton.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.sessionsButton.ForeColor = System.Drawing.Color.White;
            this.sessionsButton.Image = ((System.Drawing.Image)(resources.GetObject("sessionsButton.Image")));
            this.sessionsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sessionsButton.Location = new System.Drawing.Point(0, 161);
            this.sessionsButton.Name = "sessionsButton";
            this.sessionsButton.Size = new System.Drawing.Size(211, 47);
            this.sessionsButton.TabIndex = 2;
            this.sessionsButton.Text = "Сесси";
            this.sessionsButton.UseVisualStyleBackColor = true;
            this.sessionsButton.Click += new System.EventHandler(this.SessionsButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 161);
            this.panel2.TabIndex = 0;
            // 
            // swapPanelForm
            // 
            this.swapPanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swapPanelForm.Location = new System.Drawing.Point(211, 0);
            this.swapPanelForm.Name = "swapPanelForm";
            this.swapPanelForm.Size = new System.Drawing.Size(1051, 673);
            this.swapPanelForm.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.swapPanelForm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Компьютерный клуб";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button sessionsButton;
        private System.Windows.Forms.Button computersButton;
        private System.Windows.Forms.Button hallsButton;
        private System.Windows.Forms.Button clientsButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Panel swapPanelForm;
    }
}

