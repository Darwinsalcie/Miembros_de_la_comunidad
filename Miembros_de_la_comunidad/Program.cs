using Miembros_de_la_comunidad;


namespace Program {



    class Programa { 
    
        static void Main(string[] args)
        {
            MiebrosDeLaComunidad communitymembers = new();
            Estudiante estudiante = new Estudiante();
            Exalumno exalumno = new Exalumno();
            Empleado empleado = new Empleado();
            Docente docente = new Docente();
            Administrativo administrativo = new Administrativo();
            Admnistrador admnistrador = new Admnistrador();
            Maestro maestro = new Maestro();

            //Si es es un día de la semana todos estarán en sus actividades, si es domingo todos estarán en una actividad comunitaria.

            Console.WriteLine("Todos los Domingos hay eventos en la comunidad y todos los miembros esta misma participan; el resto de la semana están en sus actividades\n");



            for (int i =0; i<2; i++ ) {


                Console.WriteLine("\nIngrese que día es para saber que hacen los miebros de la comunidad: ");

                communitymembers.EstablecerDiaDeHoy();
                estudiante.RealizarActividad();
                exalumno.RealizarActividad();
                empleado.RealizarActividad();
                docente.RealizarActividad();
                administrativo.RealizarActividad();
                admnistrador.RealizarActividad();
                maestro.RealizarActividad();

            }






        }


    }

}

