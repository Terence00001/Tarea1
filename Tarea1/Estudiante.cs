using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    public class Estudiante : Miembros_de_la_Comunidad, Interface1
    {
        public string Matricula { get; set; }
        public override void Get()
        {
            throw new System.NotImplementedException();
        }
        public override void Update()
        {
            //actualizar estudiante.//
        }
        public override Miembros_de_la_Comunidad GetPersona()
        {
            return base.GetPersona();
        }
    }
}
