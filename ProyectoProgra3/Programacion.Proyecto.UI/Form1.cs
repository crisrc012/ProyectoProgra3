using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programacion.Proyecto.Biz;

namespace Programacion.Proyecto.UI
{
    public partial class Form1 : Form
    {
        private readonly ActivosService _activosService;

        public Form1()
        {
            InitializeComponent();
            _activosService = new ActivosService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _activosService.GetActivos();
        }
    }
}
