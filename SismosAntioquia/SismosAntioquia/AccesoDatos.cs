using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace SismosAntioquia
{
    public class AccesoDatos
    {
        /// <summary>
        /// Obtiene la cadena de conexión a la DB a partir del archivo de configuración de la App
        /// </summary>
        private static string ObtenerCadenaConexion(string id)
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        /// <summary>
        /// Obtiene una lista con los nombres de las regiones - Utiliza Dapper
        /// </summary>
        public static List<string> ObtenerRegiones()
        {
            string cadenaConexion = ObtenerCadenaConexion("SismosDB");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                var salida = cxnDB.Query<string>("select distinct region from v_regiones order by region", new DynamicParameters());
                return salida.ToList();
            }
        }

        /// <summary>
        /// Obtiene una tabla con los sismos registrados en la DB
        /// </summary>
        public static DataTable ObtenerDetalleSismos()
        {
            DataTable tablaResultado = new DataTable();

            string cadenaConexion = ObtenerCadenaConexion("SismosDB");

            using (SQLiteConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                SQLiteDataAdapter daSismos = new SQLiteDataAdapter("select distinct id, region, fecha, hora, latitud, longitud, magnitud, profundidad from v_detalle_sismos", cxnDB);
                daSismos.Fill(tablaResultado);
                return tablaResultado;
            }
        }

        /// <summary>
        /// Obtiene un datatable con los sismos consolidados por mes
        /// </summary>
        /// <returns></returns>
        public static DataTable ObtenerSismosMes()
        {
            DataTable tablaResultado = new DataTable();

            string cadenaConexion = ObtenerCadenaConexion("SismosDB");

            using (SQLiteConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                SQLiteDataAdapter daSismos = new SQLiteDataAdapter("select anno año, mes, total from v_sismos_mes; ", cxnDB);
                daSismos.Fill(tablaResultado);
                return tablaResultado;
            }
        }

        /// <summary>
        /// Obtiene un datatable con los sismos consolidados por region
        /// </summary>
        /// <returns></returns>
        public static DataTable ObtenerConsolidadoRegion()
        {
            DataTable tablaResultado = new DataTable();
            string cadenaConexion = ObtenerCadenaConexion("SismosDB");

            using (SQLiteConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                string sentenciaSQL = "select distinct region, total_sismos, prom_profundidad, prom_magnitud from v_consolidado_region; ";
                SQLiteDataAdapter daSismos = new SQLiteDataAdapter(sentenciaSQL, cxnDB);
                daSismos.Fill(tablaResultado);
                return tablaResultado;
            }
        }

        /// <summary>
        /// Registra en la DB la información de un nuevo Sismo
        /// </summary>
        public static void GuardarSismo(Sismo unSismo)
        {
            string cadenaConexion = ObtenerCadenaConexion("SismosDB");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                cxnDB.Execute("insert into temblores (fecha,hora,magnitud,profundidad, latitud, longitud, id_region) " +
                    "values (@Fecha, @Hora, @Magnitud, @Profundidad, @Latitud, @Longitud, @Id_Region)", unSismo);
            }
        }

        /// <summary>
        /// Obtiene el Id de la región a partir de los nombres
        /// </summary>
        /// <param name="nombreRegion"></param>
        /// <returns></returns>
        public static int ObtieneIdRegion(string nombreRegion)
        {
            int resultado = 0;
            string cadenaConexion = ObtenerCadenaConexion("SismosDB");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                string sentenciaSQL = "select id from regiones where nombre = @nombre";

                //El Id se asigna como parametro de la sentencia, 
                DynamicParameters parametrosSentencia = new DynamicParameters();
                parametrosSentencia.Add("@nombre", nombreRegion, DbType.String, ParameterDirection.Input);

                var salida = cxnDB.Query<int>(sentenciaSQL, parametrosSentencia);

                //validamos cuantos registros devuelve la lista
                if (salida.ToArray().Length != 0)
                    resultado = salida.First();
            }

            return resultado;
        }

        /// <summary>
        /// Obtiene el nombre de la región a partir de su id
        /// </summary>
        /// <param name="idRegion">Id de la región</param>
        /// <returns></returns>
        public static string ObtieneNombreRegion(int idRegion)
        {
            string resultado = "";
            string cadenaConexion = ObtenerCadenaConexion("SismosDB");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                string sentenciaSQL = "select nombre from regiones where id = @id";

                //El Id se asigna como parametro de la sentencia, 
                DynamicParameters parametrosSentencia = new DynamicParameters();
                parametrosSentencia.Add("@id", idRegion, DbType.Int32, ParameterDirection.Input);

                var salida = cxnDB.Query<string>(sentenciaSQL, parametrosSentencia);

                //validamos cuantos registros devuelve la lista
                if (salida.ToArray().Length != 0)
                    resultado = salida.First();
            }

            return resultado;
        }

        /// <summary>
        /// Obtiene las coordenadas de la región
        /// </summary>
        /// <param name="nombreRegion">Nombre de la región</param>
        /// <param name="latitud">Componente de latitud de la coordenada</param>
        /// <param name="longitud">Componente de la longitud de la coordenada</param>
        public static void ObtieneCoordenadasRegion(string nombreRegion, out double latitud, out double longitud)
        { 
            latitud = 0;
            longitud = 0;

            string cadenaConexion = ObtenerCadenaConexion("SismosDB");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                //El Id se asigna como parametro de la sentencia, 
                DynamicParameters parametrosSentencia = new DynamicParameters();
                parametrosSentencia.Add("@nombre", nombreRegion, DbType.String, ParameterDirection.Input);

                string latitudSQL = "select latitud from regiones where nombre = @nombre";
                var salidaLatitud = cxnDB.Query<double>(latitudSQL, parametrosSentencia);

                //validamos cuantos registros devuelve la lista
                if (salidaLatitud.ToArray().Length != 0)
                    latitud = salidaLatitud.First();

                string longitudSQL = "select longitud from regiones where nombre = @nombre";
                var salidaLongitud = cxnDB.Query<double>(longitudSQL, parametrosSentencia);

                //validamos cuantos registros devuelve la lista
                if (salidaLongitud.ToArray().Length != 0)
                    longitud = salidaLongitud.First();

            }
        }

        /// <summary>
        /// Elimina un sismo
        /// </summary>
        /// <param name="idSismo">ID del sismo a eliminar</param>
        public static bool EliminarSismo(int idSismo)
        {
            bool resultado = false;
            int totalRegistros = 0;

            string cadenaConexion = ObtenerCadenaConexion("SismosDB");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {

                // se define la sentencia SQL a utilizar, pero sin concatenar el id
                string sentenciaSQL = "delete from temblores where id = @id";

                //El Id se asigna como parametro de la sentencia, 
                DynamicParameters parametrosSentencia = new DynamicParameters();
                parametrosSentencia.Add("@id", idSismo, DbType.Int32, ParameterDirection.Input);

                totalRegistros = cxnDB.Execute(sentenciaSQL, parametrosSentencia);

                // Si la cantidad de registros es diferente de 0, se encontró y eliminó registro
                if (totalRegistros != 0)
                    resultado = true;
            }

            return resultado;
        }

        /// <summary>
        /// Obtiene la información de un sismo
        /// </summary>
        /// <param name="idSismo">ID que identifica un Sismo</param>
        /// <returns></returns>
        public static Sismo ObtenerSismo(int idSismo)
        {
            Sismo sismoResultado = new Sismo();

            string cadenaConexion = ObtenerCadenaConexion("SismosDB");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {

                // se define la sentencia SQL a utilizar, pero sin concatenar el id
                string sentenciaSQL = "select id, fecha, hora, magnitud,profundidad,latitud,longitud,id_region from temblores where id = @id";

                //El Id se asigna como parametro de la sentencia, 
                DynamicParameters parametrosSentencia = new DynamicParameters();
                parametrosSentencia.Add("@id", idSismo, DbType.Int32, ParameterDirection.Input);

                var salida = cxnDB.Query<Sismo>(sentenciaSQL, parametrosSentencia);

                //validamos cuantos registros devuelve la lista
                if (salida.ToArray().Length != 0)
                    sismoResultado = salida.First();

                return sismoResultado;
            }
        }

        /// <summary>
        /// Actualiza un sismo
        /// </summary>
        /// <param name="unSismo">Objeto que representa un sismo</param>
        public static void ActualizarSismo(Sismo unSismo)
        {
            string cadenaConexion = ObtenerCadenaConexion("SismosDB");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                cxnDB.Execute("update temblores set " +
                    "fecha = @Fecha," +
                    "hora = @Hora," +
                    "magnitud = @Magnitud," +
                    "profundidad = @Profundidad," +
                    "latitud = @Latitud, " +
                    "longitud = @Longitud, " +
                    "id_region = @Id_Region " +
                    "where id = @Id", unSismo);
            }
        }
    }
}
