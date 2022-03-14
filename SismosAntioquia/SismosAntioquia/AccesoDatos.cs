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
                SQLiteDataAdapter daSismos = new SQLiteDataAdapter("select distinct id, region, fecha, hora, latitud, longitud, round(magnitud,2) magnitud, round(profundidad,2) profundidad from temblores", cxnDB);
                daSismos.Fill(tablaResultado);
                return tablaResultado;
            }
        }

        public static DataTable ObtenerConsolidadoRegion()
        {
            DataTable tablaResultado = new DataTable();
            string cadenaConexion = ObtenerCadenaConexion("SismosDB");

            using (SQLiteConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                string sentenciaSQL = "select distinct region, count(id) total_sismos, round(avg(profundidad), 2) prom_profundidad, round(avg(magnitud), 2) prom_magnitud from temblores group by region";
                
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
                cxnDB.Execute("insert into temblores (fecha,hora,magnitud,profundidad, latitud, longitud, region) " +
                    "values (@Fecha, @Hora, @Magnitud, @Profundidad, @Latitud, @Longitud, @Region)", unSismo);
            }
        }
    }
}
