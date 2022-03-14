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
        /// Evento a ejecutar cuando se carga la forma
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizaComboBoxRegiones();
            InicializaVisualizacionDatos();
        }

        /// <summary>
        /// Actualiza las regiones para visualizar en el ComboBoxRegiones
        /// </summary>
        private void ActualizaComboBoxRegiones()
        {
            ComboBoxRegiones.DataSource = null;
            ComboBoxRegiones.DataSource = AccesoDatos.ObtenerRegiones();
            ComboBoxRegiones.DisplayMember = "region";

            comboRegionesAgregarSismo.DataSource = null;
            comboRegionesAgregarSismo.DataSource = AccesoDatos.ObtenerRegiones();
            comboRegionesAgregarSismo.DisplayMember = "region";

            // Se selecciona el primer item del ComboBox
            ComboBoxRegiones.SelectedIndex = 0;
        }

        /// <summary>
        /// Consolida el llamado a todos los metodos que visualizan datos desde la DB
        /// </summary>
        private void InicializaVisualizacionDatos()
        {
            InicializaDataGridViewDetalleSismos();
            InicializaDataGridViewConsolidadoRegiones();
        }

        private void InicializaDataGridViewDetalleSismos()
        {
            dataGridViewDetalleSismo.DataSource = null;
            dataGridViewDetalleSismo.DataSource = AccesoDatos.ObtenerDetalleSismos();
        }

        private void InicializaDataGridViewConsolidadoRegiones()
        {
            dataGridViewConsolidadoRegion.DataSource = null;
            dataGridViewConsolidadoRegion.DataSource = AccesoDatos.ObtenerConsolidadoRegion();
        }

        private bool ValidaCamposMinimos()
        {
            bool resultado = false;

            if (txtProfundidad.Text != "" ||
                txtMagnitud.Text != "" ||
                txtLatitud.Text != "" ||
                txtLongitud.Text != "" ||
                comboRegionesAgregarSismo.Text != "")
                resultado = true;

            return resultado;
        }

        private void botonAgregarSismo_Click(object sender, EventArgs e)
        {
            //Validamos que los campos de Magnitud, Profundidad y Región no sean nulos
            if (ValidaCamposMinimos())
            {
                try
                {
                    Sismo unSismo = new Sismo();
                    unSismo.Region = comboRegionesAgregarSismo.Text;
                    unSismo.Magnitud = (float)Math.Round(double.Parse(txtMagnitud.Text), 2);
                    unSismo.Profundidad = (float)Math.Round(double.Parse(txtProfundidad.Text), 2);
                    unSismo.Latitud = (float)Math.Round(double.Parse(txtLatitud.Text), 2);
                    unSismo.Longitud = (float)Math.Round(double.Parse(txtLongitud.Text), 2);
                    unSismo.Fecha = dtpFecha.Value.ToString("dd/MM/yyyy");
                    unSismo.Hora = dtpHora.Value.ToString("HH:mm:ss");

                    AccesoDatos.GuardarSismo(unSismo);

                    //Despues de agregado a la lista, se actualiza las visualizaciones de datos
                    InicializaVisualizacionDatos();

                    MessageBox.Show("Sismo registrado exitosamente.",
                        "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FormatException error)
                {
                    MessageBox.Show("Los campos de magnitud, profundidad, latitud y longitud deben ser numéricos \n" +
                        error.Message,
                        "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (NullReferenceException errorNulo)
                {
                    MessageBox.Show("El valor de la región no debe ser nulo y debe ser seleccionado de las opciones disponibles \n" +
                        errorNulo.Message,
                        "Error en datos - Región", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Los campos de región, magnitud o profundidad no pueden ser nulos",
                    "Error en datos - nulos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Reiniciamos los controles para registrar un nuevo valor
            ComboBoxRegiones.SelectedIndex = 0;
            dtpFecha.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;

            txtLatitud.Text = "";
            txtLongitud.Text = "";
            txtProfundidad.Text = "";
            txtMagnitud.Text = "";
        }
    }
}
