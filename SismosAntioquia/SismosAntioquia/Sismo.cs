namespace SismosAntioquia
{
    public class Sismo
    {
        //Propiedades
        public int Id { get; set; }       
        public double Magnitud { get; set; }
        public double Profundidad { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public int Region { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }

        //Constructores de la clase
        public Sismo(int region, string fecha, string hora, double magnitud, double profundidad, double latitud, double longitud)
        {
            this.Id = 0;
            this.Region = region;
            this.Fecha = fecha;
            this.Hora = hora;
            this.Magnitud = magnitud;
            this.Profundidad = profundidad;
            this.Latitud = latitud;
            this.Longitud = longitud;
        }

        public Sismo()
        {
            Id = 0;
            Region = 0;
            Fecha = "";
            Hora = "";
            Magnitud = 0f;
            Profundidad = 0f;
            Latitud = 0f;
            Longitud = 0f;
        }
    }
}
