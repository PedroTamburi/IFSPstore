using IFSPStore.App.Infra;
using IFSPStore.App.Register;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

namespace IFSPStore.App
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<CategoryForm>();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<UserForm>();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<CityForm>();
        }


        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<CustomerForm>();
        }

        private void ShowForm<TFormulario>() where TFormulario : Form
        {
            var cad = ConfigureDI.serviceProvider.GetService<TFormulario>();

            if (cad is not null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }


    }
}
