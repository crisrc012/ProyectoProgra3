using System.Windows.Forms;
using Proyecto_call_BLL.Interfaces;
using Uam.Programacion.Proyecto.Models;

namespace Proyecto_call_PL.DepartamentoForms
{
    public partial class VerDepartamentosForm : Form
    {
        private readonly IRepository<Departamentos, int> _repository;

        public VerDepartamentosForm(IRepository<Departamentos, int> repository)
        {
            InitializeComponent();
            _repository = repository;
        }

        #region Private Methods
        private void EditarDepartamentosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ListarDepartamentos();
        }

        private void ListarDepartamentos()
        {
            var mockObject = new Departamentos { Descripcion = txtFiltro.Text, Id = -1 };

            dtg_desplegar.DataSource = _repository.List(mockObject);
        }
        #endregion

        #region Events
        private void ListarDepartamentos_Event(object sender, System.EventArgs e)
        {
            ListarDepartamentos();
        }

        private void tsb_btn_agregar_Click(object sender, System.EventArgs e)
        {
            var editForm = new EditarDepartamentoForm(_repository, Bootstrap.GetInstance<IRepository<Uam.Programacion.Proyecto.Models.Estados, string>>(), null);

            editForm.FormClosing += EditarDepartamentosForm_FormClosing;
            editForm.ShowDialog();
            dtg_desplegar.ClearSelection();
        }

        #endregion

        private void tsb_btn_modificar_Click(object sender, System.EventArgs e)
        {
            if (dtg_desplegar.CurrentRow == null)
            {
                MessageBox.Show(@"Debe seleccionar una fila para modificar.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var departamento = (Departamentos) dtg_desplegar.CurrentRow.DataBoundItem;
            var editForm = new EditarDepartamentoForm(_repository, Bootstrap.GetInstance<IRepository<Uam.Programacion.Proyecto.Models.Estados, string>>(), departamento);

            editForm.FormClosing += EditarDepartamentosForm_FormClosing;
            editForm.ShowDialog();
            dtg_desplegar.ClearSelection();
        }

        private void tsb_btn_eliminar_Click(object sender, System.EventArgs e)
        {
            if (dtg_desplegar.CurrentRow == null)
            {
                MessageBox.Show(@"Debe seleccionar una fila para modificar.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var departamento = (Departamentos) dtg_desplegar.CurrentRow.DataBoundItem;
            var isSuccesful = _repository.Delete(departamento);

            if (isSuccesful)
                MessageBox.Show(@"Se ha borrado el departamento seleccionado.", @"Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(@"No se ha podido borrar el departamento seleccionado.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            ListarDepartamentos();
        }
    }
}
