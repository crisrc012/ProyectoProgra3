using System;
using System.Linq;
using System.Windows.Forms;
using Proyecto_call_BLL.Interfaces;
using Uam.Programacion.Proyecto.Models;

namespace Proyecto_call_PL.DepartamentoForms
{
    public partial class EditarDepartamentoForm : Form
    {
        private readonly IRepository<Departamentos, int> _departamentosRepository;
        private readonly IRepository<Uam.Programacion.Proyecto.Models.Estados, string> _estadosRepository;
        private Departamentos _departamento;

        public EditarDepartamentoForm(IRepository<Departamentos, int> departamentosRepository, IRepository<Uam.Programacion.Proyecto.Models.Estados, string> estadosRepository, Departamentos departamento)
        {
            InitializeComponent();
            _departamentosRepository = departamentosRepository;
            _estadosRepository = estadosRepository;
            _departamento = departamento;
        }

        #region Private Methods
        private void Crear()
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text) || cmbEstado.SelectedIndex < 0)
            {
                MessageBox.Show(@"Debe llenar todos los campos.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var departamento = new Departamentos
            {
                Descripcion = txtDescripcion.Text,
                FechaCreacion = DateTime.Now,
                Estado = cmbEstado.SelectedValue.ToString()
            };

            _departamentosRepository.Add(departamento);
            _departamento = _departamentosRepository.List(departamento).FirstOrDefault();

            if (_departamento == null)
            {
                MessageBox.Show(@"Se produjo un error al guardar el nuevo departamento.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(@"Se ha guardado el nuevo departamento.", @"Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtId.Text = _departamento.Id.ToString();
            txtUsuarioCreacion.Text = _departamento.CreadoUsuario;

            if (_departamento.FechaCreacion != null)
                txtFechaCreacion.Text = _departamento.FechaCreacion.Value.ToString("hh:mm dd/MM/yyyy");
        }

        private void Actualizar()
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text) || cmbEstado.SelectedIndex < 0)
            {
                MessageBox.Show(@"Debe llenar todos los campos.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var departamento = new Departamentos
            {
                Id = _departamento.Id,
                Descripcion = txtDescripcion.Text,
                FechaModificacion = DateTime.Now,
                Estado = cmbEstado.SelectedValue.ToString()
            };

            _departamentosRepository.Update(departamento);
            _departamento = _departamentosRepository.List(departamento).FirstOrDefault();

            if (_departamento == null)
            {
                MessageBox.Show(@"Se produjo un error al guardar el departamento.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            MessageBox.Show(@"Se ha guardado el departamento.", @"Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtId.Text = _departamento.Id.ToString();
            txtUsuarioModificacion.Text = _departamento.ModificadoUsuario;

            if (_departamento.FechaModificacion != null)
                txtFechaModificacion.Text = _departamento.FechaModificacion.Value.ToString("hh:mm dd/MM/yyyy");
        }
        #endregion

        #region Events
        private void EditarDepartamentoForm_Load(object sender, EventArgs e)
        {
            cmbEstado.DisplayMember = "Descripcion";
            cmbEstado.ValueMember = "Id";
            cmbEstado.DataSource = _estadosRepository.List(null);

            if (cmbEstado.Items.Count > 0)
                cmbEstado.SelectedIndex = 0;

            txtUsuarioModificacion.ReadOnly = true;
            txtUsuarioCreacion.ReadOnly = true;

            if (_departamento == null)
                return;

            cmbEstado.SelectedValue = _departamento.Estado;
            txtDescripcion.Text = _departamento.Descripcion;
            txtId.Text = _departamento.Id.ToString();
            txtUsuarioCreacion.Text = _departamento.CreadoUsuario;
            txtUsuarioModificacion.Text = _departamento.ModificadoUsuario;

            if (_departamento.FechaModificacion != null)
                txtFechaModificacion.Text = _departamento.FechaModificacion.Value.ToString("hh:mm dd/MM/yyyy");

            if (_departamento.FechaCreacion != null)
                txtFechaCreacion.Text = _departamento.FechaCreacion.Value.ToString("hh:mm dd/MM/yyyy");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_departamento == null)
                Crear();
            else
                Actualizar();
        }
        #endregion
    }
}
