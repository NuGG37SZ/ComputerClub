using System;
using System.Windows.Forms;
using ComputerClub.Entity;
using ComputerClub.Service;

namespace ComputerClub
{
    public partial class ClientsForm : Form
    {
        private IClientService _clientService;

        public ClientsForm()
        {
            InitializeComponent();
            _clientService = new ClientServiceImpl();
            ShowClientsInDataGrid();
            FillClientIdBox();
        }

        private void FillControls(Client client)
        {
            loginBox.Text = client.Login;
            discountBox.Text = client.Discount.ToString();
            phoneBox.Text = client.Phone;
            balanceBox.Text = client.Balance.ToString();
        }

        private void ShowClientsInDataGrid()
        {
            clientsGrid.DataSource = _clientService.GetAll();
            ApplySettingsToDataGrid();
        }

        private void ApplySettingsToDataGrid()
        {
            clientsGrid.ReadOnly = true;
            clientsGrid.RowHeadersVisible = false;
            clientsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            clientsGrid.Columns["Id"].HeaderText = "Номер";
            clientsGrid.Columns["Login"].HeaderText = "Логин";
            clientsGrid.Columns["Discount"].HeaderText = "Скидка";
            clientsGrid.Columns["Phone"].HeaderText = "Номер телефона";
            clientsGrid.Columns["Balance"].HeaderText = "Баланс";
        }

        private void FillClientIdBox() 
        {
            clientIdBox.Items.Clear();
            foreach(var client in _clientService.GetAll())
            {
                clientIdBox.Items.Add(client.Id);
            }
        }

        private void ClientIdBox_SelectedValueChanged(object sender, EventArgs e)
        {
            int currentId = Convert.ToInt32(clientIdBox.SelectedItem);
            Client currentClient = _clientService.GetById(currentId);
            FillControls(currentClient);
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            _clientService.Create(new Client(
                loginBox.Text,
                Convert.ToDouble(discountBox.Text),
                phoneBox.Text,
                Convert.ToInt32(balanceBox.Text)
            ));
            ShowClientsInDataGrid();
            FillClientIdBox();
        }

        private void UpdateClient_Click(object sender, EventArgs e)
        {
            _clientService.Update(Convert.ToInt32(clientIdBox.Text), new Client(
                Convert.ToInt32(clientIdBox.Text),
                loginBox.Text,
                Convert.ToDouble(discountBox.Text),
                phoneBox.Text,
                Convert.ToInt32(balanceBox.Text)
            ));
            ShowClientsInDataGrid();
            FillClientIdBox();
        }

        private void DeleteClient_Click(object sender, EventArgs e)
        {
            _clientService.Delete(Convert.ToInt32(clientIdBox.Text));
            ShowClientsInDataGrid();
            FillClientIdBox();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            clientsGrid.DataSource = _clientService.FindClientsByLoginOrPhone(searchBox.Text);
            ApplySettingsToDataGrid();
        }
    }
}
