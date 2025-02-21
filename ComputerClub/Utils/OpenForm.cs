using System.Threading;
using System.Windows.Forms;

namespace ComputerClub.Utils
{
    public class OpenForm
    {
        private Form _activeForm;

        public OpenForm()
        {
            _activeForm = null;
        }

        public void OpenFormInPanel(Form form, Panel panel)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }
            _activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            panel.Tag = form;
            form.BringToFront();
            form.Show();
        }

        public static void OpenFormNewDialog(Form parent, Form openForm)
        {
            parent.Hide();
            openForm.ShowDialog();
            if (openForm.DialogResult == DialogResult.OK)
            {
                Thread.Sleep(150);
                parent.Show();
            }
        }
    }
}
