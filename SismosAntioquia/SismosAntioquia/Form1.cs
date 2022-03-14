using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SismosAntioquia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Actualiza las regiones para visualizar en el ComboBoxRegiones
        /// </summary>
        private void ActualizaComboBoxRegiones()
        {
            ComboBoxRegiones.DataSource = null;
            ComboBoxRegiones.DataSource = AccesoDatos.ObtenerRegiones();
            ComboBoxRegiones.DisplayMember = "region";

            // Se selecciona el primer item del ComboBox
            ComboBoxRegiones.SelectedIndex = 0;
        }

        /// <summary>
        /// Evento a ejecutar cuando se carga la forma
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizaComboBoxRegiones();
            InicializaVisualizacionDatos();
        }

        /// <summary>
        /// Consolida el llamado a todos los metodos que visualizan datos desde la DB
        /// </summary>
        private void InicializaVisualizacionDatos()
        {
            InicializaDataGridViewDetalleSismos();
        }

        private void InicializaDataGridViewDetalleSismos()
        {
            dataGridViewDetalleSismo.DataSource = null;
            dataGridViewDetalleSismo.DataSource = AccesoDatos.ObtenerDetalleSismos();
        }
    }
}
