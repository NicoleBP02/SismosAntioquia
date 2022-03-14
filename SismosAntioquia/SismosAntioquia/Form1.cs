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
            comboRegionesAgregarSismo.DataSource = null;
            comboRegionesAgregarSismo.DataSource = AccesoDatos.ObtenerRegiones();
            comboRegionesAgregarSismo.DisplayMember = "region";
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
            int idRegion = 0;
            
            if (comboRegionesAgregarSismo.Text != "")
                idRegion = AccesoDatos.ObtieneIdRegion(comboRegionesAgregarSismo.Text);

            
            //Validamos que los campos de Magnitud, Profundidad y Región no sean nulos
            if (ValidaCamposMinimos() && idRegion!=0)
            {
                try
                {
                    Sismo unSismo = new Sismo(
                        idRegion,                                               //Region
                        dtpFecha.Value.ToString("dd/MM/yyyy"),                  //Fecha
                        dtpHora.Value.ToString("HH:mm:ss"),                     //Hora
                        Math.Round(double.Parse(txtMagnitud.Text), 2),          //Magnitud
                        Math.Round(double.Parse(txtProfundidad.Text), 2),       //Profundidad
                        Math.Round(double.Parse(txtLatitud.Text), 3),           //Latitud
                        Math.Round(double.Parse(txtLongitud.Text), 3)           //Longitud
                    ); 

                    //Sismo unSismo = new Sismo();
                    //unSismo.Region = idRegion;
                    //unSismo.Magnitud = Math.Round(double.Parse(txtMagnitud.Text), 2);
                    //unSismo.Profundidad = Math.Round(double.Parse(txtProfundidad.Text), 2);
                    //unSismo.Latitud = Math.Round(double.Parse(txtLatitud.Text), 2);
                    //unSismo.Longitud = Math.Round(double.Parse(txtLongitud.Text), 2);
                    //unSismo.Fecha = dtpFecha.Value.ToString("dd/MM/yyyy");
                    //unSismo.Hora = dtpHora.Value.ToString("HH:mm:ss");

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
                if (idRegion == 0)
                {
                    MessageBox.Show("La región indicada no se encuentra registrada.",
                        "Error en región indicada",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Los campos de latitud, longitud, magnitud o profundidad no pueden ser nulos",
                        "Error en datos - nulos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //Reiniciamos los controles para registrar un nuevo valor
            comboRegionesAgregarSismo.SelectedIndex = 0;
            dtpFecha.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;

            txtLatitud.Text = "";
            txtLongitud.Text = "";
            txtProfundidad.Text = "";
            txtMagnitud.Text = "";
        }

        private void comboRegionesAgregarSismo_SelectedIndexChanged(object sender, EventArgs e)
        {
            double latitud, longitud;
            string nombreRegion = comboRegionesAgregarSismo.Text;

            //Aqui obtenemos los valores de latitud y longitud para la region
            AccesoDatos.ObtieneCoordenadasRegion(nombreRegion, out latitud, out longitud);

            if (latitud != 0 && longitud != 0)
            {
                txtLatitud.Text = latitud.ToString();
                txtLongitud.Text = longitud.ToString();
            }

        }

        private void btnBorrarSismo_Click(object sender, EventArgs e)
        {
            if (txtIdSismoBorrar.Text != "")
            {
                try
                {
                    int idSismo = int.Parse(txtIdSismoBorrar.Text);
                    bool respuesta = AccesoDatos.EliminarSismo(idSismo);

                    if (respuesta)
                    {
                        //Despues de agregado a la lista, se actualiza las visualizaciones de datos
                        InicializaVisualizacionDatos();

                        //Y se borra el valor ingresado
                        txtIdSismoBorrar.Text = "";


                        MessageBox.Show("Sismo eliminado exitosamente.",
                            "Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un sismo asociado al id suministrado.",
                            "Registro no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (FormatException error)
                {
                    MessageBox.Show("El Id del sismo debe ser un valor numérico entero \n" +
                        error.Message,
                        "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese el ID del sismo a eliminar",
                    "Id de Sismo no suministrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
