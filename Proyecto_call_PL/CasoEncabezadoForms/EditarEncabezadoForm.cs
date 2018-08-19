using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Proyecto_call_BLL.Interfaces;
using Uam.Programacion.Proyecto.Models;

namespace Proyecto_call_PL.CasoEncabezadoForms
{
    public partial class EditarEncabezadoForm : Form
    {
        private readonly IRepository<Encabezado, int> _encabezadoRepository;
        private readonly IRepository<Uam.Programacion.Proyecto.Models.Operadores, string> _operadoresRepository;
        private readonly IRepository<EstadosSemaforo, string> _semaforoRepository;
        private readonly IRepository<Uam.Programacion.Proyecto.Models.Estados, string> _estadosRepository;
        private Encabezado _encabezado;

        public EditarEncabezadoForm(IRepository<Encabezado, int> encabezadoRepository, IRepository<Uam.Programacion.Proyecto.Models.Estados, string> estadosRepository, 
                                    IRepository<Uam.Programacion.Proyecto.Models.Operadores, string> operadoresRepository, IRepository<EstadosSemaforo, string> semaforoRepository, Encabezado encabezado)
        {
            InitializeComponent();
            _encabezadoRepository = encabezadoRepository;
            _estadosRepository = estadosRepository;
            _operadoresRepository = operadoresRepository;
            _semaforoRepository = semaforoRepository;
            _encabezado = encabezado;
        }

        #region Private Methods
        private void Crear()
        {
            DateTime date;
            var culture = CultureInfo.CreateSpecificCulture("es-CR");

            if (string.IsNullOrEmpty(txtDescripcion.Text) || cmbEstado.SelectedIndex < 0 || cmbOperador.SelectedIndex < 0 || cmbEstadoSemaforo.SelectedIndex < 0)
            {
                MessageBox.Show(@"Debe llenar todos los campos.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!mskFecha.MaskFull || !DateTime.TryParse(mskFecha.Text, culture, DateTimeStyles.None, out date))
            {
                MessageBox.Show(@"La fecha ingresada no es válida.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var encabezado= new Encabezado
            {
                Comentarios= txtDescripcion.Text,
                FechaCaso = date,
                FechaCreacion = DateTime.Now,
                Estado = cmbEstado.SelectedValue.ToString(),
                EstadoSemaforo = cmbEstadoSemaforo.SelectedValue.ToString(),
                Operador = cmbOperador.SelectedValue.ToString()
            };

            _encabezadoRepository.Add(encabezado);
            _encabezado = _encabezadoRepository.List(encabezado).FirstOrDefault();

            if (_encabezado == null)
            {
                MessageBox.Show(@"Se produjo un error al guardar el nuevo encabezado.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(@"Se ha guardado el nuevo encabezado.", @"Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtId.Text = _encabezado.Id.ToString();
            txtUsuarioCreacion.Text = _encabezado.CreadoUsuario;

            if (_encabezado.FechaCreacion != null)
                txtFechaCreacion.Text = _encabezado.FechaCreacion.Value.ToString("hh:mm dd/MM/yyyy");
        }

        private void Actualizar()
        {
            DateTime date;
            var culture = CultureInfo.CreateSpecificCulture("es-CR");

            if (string.IsNullOrEmpty(txtDescripcion.Text) || cmbEstado.SelectedIndex < 0 || cmbOperador.SelectedIndex < 0 || cmbEstadoSemaforo.SelectedIndex < 0)
            {
                MessageBox.Show(@"Debe llenar todos los campos.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!mskFecha.MaskFull || !DateTime.TryParse(mskFecha.Text, culture, DateTimeStyles.None, out date))
            {
                MessageBox.Show(@"La fecha ingresada no es válida.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var encabezado = new Encabezado
            {
                Id = _encabezado.Id,
                Comentarios = txtDescripcion.Text,
                FechaModificacion = DateTime.Now,
                Estado = cmbEstado.SelectedValue.ToString(),
                FechaCaso = date,
                EstadoSemaforo = cmbEstadoSemaforo.SelectedValue.ToString(),
                Operador = cmbOperador.SelectedValue.ToString()
            };

            _encabezadoRepository.Update(encabezado);
            _encabezado = _encabezadoRepository.List(encabezado).FirstOrDefault();

            if (_encabezado == null)
            {
                MessageBox.Show(@"Se produjo un error al guardar el encabezado.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            MessageBox.Show(@"Se ha guardado el encabezado.", @"Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtId.Text = _encabezado.Id.ToString();
            txtUsuarioModificacion.Text = _encabezado.ModificadoUsuario;

            if (_encabezado.FechaModificacion != null)
                txtFechaModificacion.Text = _encabezado.FechaModificacion.Value.ToString("hh:mm dd/MM/yyyy");
        }
        #endregion

        #region Events
        private void EditarDepartamentoForm_Load(object sender, EventArgs e)
        {
            cmbEstado.DisplayMember = "Descripcion";
            cmbEstado.ValueMember = "Id";
            cmbEstado.DataSource = _estadosRepository.List(null);

            cmbEstadoSemaforo.DisplayMember = "Descripcion";
            cmbEstadoSemaforo.ValueMember = "Id";
            cmbEstadoSemaforo.DataSource = _semaforoRepository.List(null);

            cmbOperador.DisplayMember = "Operador";
            cmbOperador.ValueMember = "Id";
            cmbOperador.DataSource = _operadoresRepository.List(null);

            if (cmbEstado.Items.Count > 0)
                cmbEstado.SelectedIndex = 0;

            mskFecha.ValidatingType = typeof(DateTime);
            txtUsuarioModificacion.ReadOnly = true;
            txtUsuarioCreacion.ReadOnly = true;

            if (_encabezado == null)
                return;

            cmbEstado.SelectedValue = _encabezado.Estado;
            cmbOperador.SelectedValue = _encabezado.Operador;
            cmbEstadoSemaforo.SelectedValue = _encabezado.EstadoSemaforo;
            txtDescripcion.Text = _encabezado.Comentarios;
            txtId.Text = _encabezado.Id.ToString();
            txtUsuarioCreacion.Text = _encabezado.CreadoUsuario;
            txtUsuarioModificacion.Text = _encabezado.ModificadoUsuario;

            if (_encabezado.FechaCaso != null)
                mskFecha.Text = _encabezado.FechaCaso.Value.ToString("dd/MM/yyyy hh:mm");

            if (_encabezado.FechaModificacion != null)
                txtFechaModificacion.Text = _encabezado.FechaModificacion.Value.ToString("hh:mm dd/MM/yyyy");

            if (_encabezado.FechaCreacion != null)
                txtFechaCreacion.Text = _encabezado.FechaCreacion.Value.ToString("hh:mm dd/MM/yyyy");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_encabezado == null)
                Crear();
            else
                Actualizar();
        }
        #endregion
    }
}
