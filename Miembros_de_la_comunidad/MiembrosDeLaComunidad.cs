namespace Miembros_de_la_comunidad
{
    public class MiebrosDeLaComunidad
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        protected static string DiaDelEvento { get; set; } = "domingo"; //solo lo puede cambiar alguien dentro de la comunidad
        public string communitymember = string.Empty;
        public string doing = string.Empty;
        public static string DiaDeHoy = string.Empty;

        public void EstablecerDiaDeHoy()
        
        {
            Console.Write("Ingrese el día del evento:");
            DiaDeHoy = Console.ReadLine().Trim().ToLower(); // Leer el día y convertir a minúsculas
        }

        public virtual void  RealizarActividad()
        {
            if (DiaDeHoy == DiaDelEvento) {

                Console.WriteLine($"\nEl {communitymember} está en la actividad comunitaria");
            }

            else {

                Console.WriteLine($"\nEl {communitymember} está {doing}");
            }
            
        }
  
    }
}