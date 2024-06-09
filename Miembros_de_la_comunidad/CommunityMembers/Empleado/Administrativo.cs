

namespace Miembros_de_la_comunidad
{
    public class Administrativo : Empleado
    {
        public Administrativo()
        {
            communitymember = "Administrativo";
            doing = "Adiministrado una Empresa";
        }

        public override void RealizarActividad()
        {

            base.RealizarActividad();

        }
    }
}