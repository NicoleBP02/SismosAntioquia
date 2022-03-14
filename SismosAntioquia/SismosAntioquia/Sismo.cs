namespace SismosAntioquia
{
    public class Sismo
    {
        //Atributos
        private int id;
        private float magnitud, profundidad, latitud, longitud;
        private string region, fecha, hora;

        //Propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public float Magnitud
        {
            get
            {
                return magnitud;
            }
            set
            {
                magnitud = value;
            }
        }
        public float Profundidad
        {
            get
            {
                return profundidad;
            }
            set
            {
                profundidad = value;
            }
        }
        public float Latitud
        {
            get
            {
                return latitud;
            }
            set
            {
                latitud = value;
            }
        }
        public float Longitud
        {
            get
            {
                return longitud;
            }
            set
            {
                longitud = value;
            }
        }
        public string Region
        {
            get
            {
                return region;
            }
            set
            {
                region = value;
            }
        }
        public string Fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
            }
        }
        public string Hora
        {
            get
            {
                return hora;
            }
            set
            {
                hora = value;
            }
        }

        //Constructores de la clase
        public Sismo(int id, string region, string fecha, string hora, float magnitud, float profundidad, float latitud, float longitud)
        {
            this.id = id;
            this.region = region;
            this.fecha = fecha;
            this.hora = hora;
            this.magnitud = magnitud;
            this.profundidad = profundidad;
            this.latitud = latitud;
            this.longitud = longitud;
        }

        public Sismo()
        {
            id = 0;
            region = "";
            fecha = "";
            hora = "";
            magnitud = 0f;
            profundidad = 0f;
            latitud = 0f;
            longitud = 0f;
        }
    }
}
