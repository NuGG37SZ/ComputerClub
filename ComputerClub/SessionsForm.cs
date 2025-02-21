using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ComputerClub.Entity;
using ComputerClub.Service;

namespace ComputerClub
{
    public partial class SessionsForm : Form
    {
        private ISessionService _sessionService;

        private IComputerService _computerService;

        private IClientService _clientService;

        private IHallService _hallService;

        private List<int> _hallsIds;

        public SessionsForm()
        {
            InitializeComponent();
            _sessionService = new SessionServiceImpl();
            _hallService = new HallServiceImpl();
            _computerService = new ComputerServiceImpl();
            _clientService = new ClientServiceImpl();
            _hallsIds = _hallService.GetAll().Select(el => el.Id).ToList();
            PaintAllHalls();
            FillAllBox();
            StartTimer();
        }

        private void PaintStandartHall()
        {
            int count, currentNumEl = 0, rows, columns = 10;

            count = _hallService.FindCountComputerById(_hallsIds[1]);
            double valueRows = count / columns;
            rows = Convert.ToInt32(Math.Ceiling(valueRows));

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Panel panel = new Panel();
                    panel.Name = $"PanelStandart {i}{j}";
                    panel.Width = 30;
                    panel.Height = 30;

                    currentNumEl++;
                    if (currentNumEl <= count)
                    {
                        int currentId = _computerService.FindAllIdByHallsId(_hallsIds[1])[currentNumEl - 1];
                        Computer currentComputer = _computerService.GetById(currentId);

                        if (currentComputer.IsBusy)
                            panel.BackColor = Color.Red;
                        else
                            panel.BackColor = Color.Green;

                        int x = 200 + (j * (panel.Width + 10));
                        int y = 80 + (i * (panel.Height + 10));
                        panel.Location = new Point(x, y);

                        Label label = new Label();
                        label.Text = currentId.ToString();
                        panel.Controls.Add(label);
                        computersRoomsPanel.Controls.Add(panel);
                    }
                }
            }
        }

        private void PaintVipHall(int startX, int startY, int startNumEl)
        {
            int count, columns = 5;

            count = _hallService.FindCountComputerById(_hallsIds[0]);

            for (int i = 0; i < columns; i++)
            {
                Panel panel = new Panel();
                panel.Width = 30;
                panel.Height = 30;

                startNumEl++;
                if (startNumEl <= count)
                {
                    int currentId = _computerService.FindAllIdByHallsId(_hallsIds[0])[startNumEl - 1];
                    panel.Name = $"PanelVip {i}";
                    Computer currentComputer = _computerService.GetById(currentId);

                    if (currentComputer.IsBusy)
                        panel.BackColor = Color.Red;
                    else
                        panel.BackColor = Color.Green;

                    int x = startX + (i * (panel.Width + 10));
                    int y = startY;
                    panel.Location = new Point(x, y);

                    Label label = new Label();
                    label.Text = currentId.ToString();
                    panel.Controls.Add(label);
                    computersRoomsPanel.Controls.Add(panel);
                }
            }
        }

        private void PaintStreamerHall(int startX, int startY, int startNumEl) 
        {
            int count;

            count = _hallService.FindCountComputerById(_hallsIds[3]);

            for (int i = 0; i < count - 1; i++)
            {
                Panel panel = new Panel();
                panel.Width = 30;
                panel.Height = 30;

                startNumEl++;
                if (startNumEl <= count)
                {
                    int currentId = _computerService.FindAllIdByHallsId(_hallsIds[3])[startNumEl - 1];
                    panel.Name = $"PanelStreamer {currentId}";
                    Computer currentComputer = _computerService.GetById(currentId);

                    if (currentComputer.IsBusy)
                        panel.BackColor = Color.Red;
                    else
                        panel.BackColor = Color.Green;

                    int x = startX + (i * (panel.Width + 10));
                    int y = startY;
                    panel.Location = new Point(x, y);

                    Label label = new Label();
                    label.Text = currentId.ToString();
                    panel.Controls.Add(label);
                    computersRoomsPanel.Controls.Add(panel);
                }
            }
        }

        private void PaintXboxHall()
        {
            int count, startNumEl = 0;

            count = _hallService.FindCountComputerById(_hallsIds[2]);

            for (int i = 0; i < count; i++)
            {
                Panel panel = new Panel();
                panel.Width = 30;
                panel.Height = 30;

                startNumEl++;
                if (startNumEl <= count)
                {
                    int currentId = _computerService.FindAllIdByHallsId(_hallsIds[2])[startNumEl - 1];
                    panel.Name = $"PanelXbox {currentId}";
                    Computer currentComputer = _computerService.GetById(currentId);

                    if (currentComputer.IsBusy)
                        panel.BackColor = Color.Red;
                    else
                        panel.BackColor = Color.Green;

                    int x = 330 + (i * (panel.Width + 10));
                    int y = 310;
                    panel.Location = new Point(x, y);

                    Label label = new Label();
                    label.Text = currentId.ToString();
                    panel.Controls.Add(label);
                    computersRoomsPanel.Controls.Add(panel);
                }
            }
        }

        private void PaintAllHalls()
        {
            PaintStandartHall();
            PaintVipHall(60, 220, 0);
            PaintVipHall(580, 220, 5);
            PaintStreamerHall(80, 310, 0);
            PaintStreamerHall(680, 310, 1);
            PaintXboxHall();
        }

        private void FillAllBox()
        {
            FillSessionBox();
            FillClientBox();
            FillComputerBox();
        }

        private void FillSessionBox()
        {
            sessionBox.Items.Clear();
            foreach(var session in _sessionService.GetAll())
            {
                sessionBox.Items.Add(session.Id);
            }
        }

        private void FillComputerBox()
        {
            computerBox.Items.Clear();
            List<Computer> computers = new List<Computer>();
            computers = _computerService.GetAll().FindAll(el => !el.IsBusy).ToList();

            foreach (var computer in computers)
            {
                computerBox.Items.Add(computer.Id);
            }
        }

        private void FillClientBox()
        {
            clientBox.Items.Clear();
            foreach (var client in _clientService.GetAll())
            {
                clientBox.Items.Add(client.Login);
            }
        }

        private void SessionBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Session currentSession = _sessionService.GetById(Convert.ToInt32(sessionBox.Text));
            Computer currentComputer = _computerService.GetById(currentSession.ComputerId);
            computerBox.Text = currentSession.ComputerId.ToString();
            clientBox.Text = _clientService.GetById(currentSession.ClientId).Login;
            startPlay.Value = currentSession.StartPlay;
            if (currentComputer.IsBusy)
                isBusyBox.Text = "Да";
            else
                isBusyBox.Text = "Нет";
        }

        private void AddSession_Click(object sender, EventArgs e)
        {
            Client currentClient = _clientService.GetClientByLogin(clientBox.Text);
            Computer currentComputer = _computerService.GetById(Convert.ToInt32(computerBox.Text));
            currentComputer.IsBusy = CheckBusyComputer();
            _computerService.Update(currentComputer.Id, currentComputer);

            _sessionService.Create(new Session(
                   currentClient.Id,
                   currentComputer.Id,
                   Convert.ToDateTime(startPlay.Text),
                   Convert.ToDateTime(endPlay.Text)
            ));
            FillAllBox();
            PaintAllHalls();
        }

        private void StartTimer()
        {
            CheckSessions.Interval = 300000;
            CheckSessions.Enabled = true;
            CheckSessions.Start();
        }

        private void CheckSessions_Tick(object sender, EventArgs e)
        {
            _sessionService.CheckEndSession();
        }

        private void UpdateSession_Click(object sender, EventArgs e)
        {
            Client currentClient = _clientService.GetClientByLogin(clientBox.Text);
            Computer currentComputer = _computerService.GetById(Convert.ToInt32(computerBox.Text));
            currentComputer.IsBusy = CheckBusyComputer();
            _computerService.Update(currentComputer.Id, currentComputer);

            _sessionService.Update(Convert.ToInt32(sessionBox.Text), new Session(
                   currentClient.Id,
                   currentComputer.Id,
                   Convert.ToDateTime(startPlay.Text),
                   Convert.ToDateTime(endPlay.Text)
            ));
            FillAllBox();
            PaintAllHalls();
        }

        private bool CheckBusyComputer()
        {
            return isBusyBox.Text.Contains("Да");
        }

        private void DeleteSession_Click(object sender, EventArgs e)
        {
            Computer currentComputer = _computerService.GetById(Convert.ToInt32(computerBox.Text));
            currentComputer.IsBusy = false;
            _computerService.Update(currentComputer.Id, currentComputer);
            _sessionService.Delete(Convert.ToInt32(sessionBox.Text));
            
            FillAllBox();
            PaintAllHalls();
        }

    }
}
