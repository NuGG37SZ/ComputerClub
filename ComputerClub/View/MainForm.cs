using System;
using System.Windows.Forms;
using ComputerClub.Utils;

namespace ComputerClub
{
    public partial class MainForm : Form
    {
        private OpenForm openForm;

        public MainForm()
        {
            InitializeComponent();
            openForm = new OpenForm();
            openForm.OpenFormInPanel(new SessionsForm(), swapPanelForm);
        }

        private void SessionsButton_Click(object sender, EventArgs e)
        {
            openForm.OpenFormInPanel(new SessionsForm(), swapPanelForm);
        }

        private void ComputersButton_Click(object sender, EventArgs e)
        {
            openForm.OpenFormInPanel(new ComputersForm(), swapPanelForm);
        }

        private void HallsButton_Click(object sender, EventArgs e)
        {
            openForm.OpenFormInPanel(new HallsForm(), swapPanelForm);
        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            openForm.OpenFormInPanel(new ClientsForm(), swapPanelForm);
        }
    }
}
