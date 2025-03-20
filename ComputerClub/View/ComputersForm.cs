using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ComputerClub.Entity;
using ComputerClub.Mapper;
using ComputerClub.Service;

namespace ComputerClub
{
    public partial class ComputersForm : Form
    {
        private IComputerService _computerService;

        private IHallService _hallService;

        public ComputersForm()
        {
            InitializeComponent();
            _computerService = new ComputerServiceImpl();
            _hallService = new HallServiceImpl(); 
            ShowComputerOnDataGrid();
            ApplySettingsToDataGrid();
            FillComputerBox();
            FillHallBox();
        }

        private void ShowComputerOnDataGrid()
        {
            List<ComputerDisplay> computers = new List<ComputerDisplay>();
            computers = _computerService.GetAll()
                .Select(el => ComputerMapper.MapComputerToComputerDisplay(el))
                .ToList();
            computersGrid.DataSource = computers;
        }

        private void ApplySettingsToDataGrid()
        {
            computersGrid.ReadOnly = true;
            computersGrid.RowHeadersVisible = false;
            computersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            computersGrid.Columns["Id"].HeaderText = "Номер ПК";
            computersGrid.Columns["HallName"].HeaderText = "Имя зала";
            computersGrid.Columns["PricePerHour"].HeaderText = "Стоимость за час";
            computersGrid.Columns["IsBusy"].HeaderText = "Занят ли сейчас";
        }

        private void FillComputerBox()
        {
            computerIdBox.Items.Clear();
            foreach (var computer in _computerService.GetAll())
            {
                computerIdBox.Items.Add(computer.Id);
            }
        }

        private void FillHallBox()
        {
           hallNameBox.Items.Clear();
           foreach(var hall in _hallService.GetAll())
           {
                hallNameBox.Items.Add(hall.Name);
           }
        }

        private void AddComputer_Click(object sender, EventArgs e)
        {
            int hallId = _hallService.FindHallIdByName(hallNameBox.Text);
            _computerService.Create(new Computer(hallId, false));
            ShowComputerOnDataGrid();
            FillComputerBox();
        }

        private void UpdateComputer_Click(object sender, EventArgs e)
        {
            int hallId = _hallService.FindHallIdByName(hallNameBox.Text);
            _computerService.Update(Convert.ToInt32(computerIdBox.Text), 
                new Computer(hallId, false)
            );
            ShowComputerOnDataGrid(); 
            FillComputerBox();
        }

        private void DeleteComputer_Click(object sender, EventArgs e)
        {
            _computerService.Delete(Convert.ToInt32(computerIdBox.Text));
            ShowComputerOnDataGrid();
            FillComputerBox();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            List<ComputerDisplay> computerDisplays = _computerService.FindComputerByBusyAndRoom(searchBox.Text);
            computersGrid.DataSource = computerDisplays;
            ApplySettingsToDataGrid();
        }

        private void ComputerIdBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Computer currentComputer = _computerService.GetById(Convert.ToInt32(computerIdBox.Text));
            string name = _hallService.GetById(currentComputer.Id).Name;
            hallNameBox.Text = name;
        }
    }
}
