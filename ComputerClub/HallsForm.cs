using System;
using System.Windows.Forms;
using ComputerClub.Entity;
using ComputerClub.Service;

namespace ComputerClub
{
    public partial class HallsForm : Form
    {
        private IHallService _hallService;

        public HallsForm()
        {
            InitializeComponent();
            _hallService = new HallServiceImpl();
            FillHallBox(); 
            ShowHallsOnDataGrid();
        }

        private void ShowHallsOnDataGrid()
        {
            hallsGrid.DataSource = _hallService.GetAll();
            ApplySettingsToDataGrid();
        }

        private void ApplySettingsToDataGrid()
        {
            hallsGrid.ReadOnly = true;
            hallsGrid.RowHeadersVisible = false;
            hallsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            hallsGrid.Columns["Id"].HeaderText = "Номер";
            hallsGrid.Columns["Name"].HeaderText = "Имя зала";
            hallsGrid.Columns["PricePerHour"].HeaderText = "Стоимость за час";
            hallsGrid.Columns["MaxCountComputers"].HeaderText = "Максимальное количество ПК в зале";
        }

        private void AddHall_Click(object sender, EventArgs e)
        {
            _hallService.Create(new Hall(
                nameHallBox.Text,
                Convert.ToInt32(pricePerHourBox.Value),
                Convert.ToInt32(maxCountBox.Value)
            ));
            FillHallBox();
            ShowHallsOnDataGrid();
        }

        private void UpdateHall_Click(object sender, EventArgs e)
        {
            _hallService.Update(Convert.ToInt32(hallsIdBox.Text), new Hall(
                nameHallBox.Text,
                Convert.ToInt32(pricePerHourBox.Value),
                Convert.ToInt32(maxCountBox.Value)
            ));
            ShowHallsOnDataGrid();
        }

        private void DeleteHall_Click(object sender, EventArgs e)
        {
            _hallService.Delete(Convert.ToInt32(hallsIdBox.Text));
            FillHallBox();
            ShowHallsOnDataGrid();
        }

        private void FillHallBox()
        {
            hallsIdBox.Items.Clear();
            foreach(var hall in _hallService.GetAll())
            {
                hallsIdBox.Items.Add(hall.Id);
            }
        }

        private void HallsIdBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Hall currentHall = _hallService.GetById(Convert.ToInt32(hallsIdBox.Text));
            nameHallBox.Text = currentHall.Name;
            pricePerHourBox.Value = currentHall.PricePerHour;
            maxCountBox.Value = currentHall.MaxCountComputers;
        }
    }
}
