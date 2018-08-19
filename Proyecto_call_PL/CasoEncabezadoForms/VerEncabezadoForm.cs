using System.Windows.Forms;
using Proyecto_call_BLL.Interfaces;
using Uam.Programacion.Proyecto.Models;

namespace Proyecto_call_PL.CasoEncabezadoForms
{
    public partial class VerEncabezadoForm : Form
    {
        private readonly IRepository<Encabezado, int> _repository;

        public VerEncabezadoForm(IRepository<Encabezado, int> repository)
        {
            InitializeComponent();
            _repository = repository;
        }

        #region Private Methods
        private void EditarEncabezadoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ListarEncabezado();
        }

        private void ListarEncabezado()
        {
            var mockObject = new Encabezado { Comentarios = txtFiltro.Text, Id = -1 };

            dtg_desplegar.DataSource = _repository.List(mockObject);
        }
        #endregion

        #region Events
        private void ListarEncabezado_Event(object sender, System.EventArgs e)
        {
            ListarEncabezado();
        }

        private void tsb_btn_agregar_Click(object sender, System.EventArgs e)
        {
            var editForm = new EditarEncabezadoForm(_repository,
                                                    Bootstrap.GetInstance<IRepository<Uam.Programacion.Proyecto.Models.Estados, string>>(),
                                                    Bootstrap.GetInstance<IRepository<Uam.Programacion.Proyecto.Models.Operadores, string>>(),
                                                    Bootstrap.GetInstance<IRepository<EstadosSemaforo, string>>(),
                                                    null);

            editForm.FormClosing += EditarEncabezadoForm_FormClosing;
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

            var encabezado = (Encabezado)dtg_desplegar.CurrentRow.DataBoundItem;
            var editForm = new EditarEncabezadoForm(_repository,
                                                    Bootstrap.GetInstance<IRepository<Uam.Programacion.Proyecto.Models.Estados, string>>(),
                                                    Bootstrap.GetInstance<IRepository<Uam.Programacion.Proyecto.Models.Operadores, string>>(),
                                                    Bootstrap.GetInstance<IRepository<EstadosSemaforo, string>>(),
                                                    encabezado);

            editForm.FormClosing += EditarEncabezadoForm_FormClosing;
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

            var encabezado = (Encabezado)dtg_desplegar.CurrentRow.DataBoundItem;
            var isSuccesful = _repository.Delete(encabezado);

            if (isSuccesful)
                MessageBox.Show(@"Se ha borrado el encabezado seleccionado.", @"Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(@"No se ha podido borrar el encabezado seleccionado.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            ListarEncabezado();
        }
    }
}
