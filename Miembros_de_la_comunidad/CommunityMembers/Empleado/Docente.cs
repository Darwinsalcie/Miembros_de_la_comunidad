

namespace Miembros_de_la_comunidad
{
    public class Docente : Empleado
    {
        public Docente()
        {
            communitymember = "Docente";
            doing = "Trabajando en un Centro educativo";
        }

        public override void RealizarActividad()
        {

            base.RealizarActividad();


        }
    }
}