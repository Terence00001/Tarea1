using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    public class Maestro : Docente, Interface1
    {
        public string Id_Maestro { get; set; }
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
