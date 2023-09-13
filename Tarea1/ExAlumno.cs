using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    public class ExAlumno : Miembros_de_la_Comunidad, Interface1
    {
        public string Codigo { get; set; }
        public override void Get()
        {
            throw new NotImplementedException();
        }
        public override void Update()
        {
            //actualizar docente.//
        }
        public override Miembros_de_la_Comunidad GetPersona()
        {
            return base.GetPersona();
        }
    }
}
