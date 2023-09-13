using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    public abstract class Miembros_de_la_Comunidad : Interface1
    {
        public string Empleado { get; set; }
        public string Estudiante { get; set; }
        public string ExAlumno { get; set;}

        public string Administrativo { get; set; }
        public string Docente { get; set; }

        public string Administrador { get; set; }

        public string Maestro { get; set; }

        void save() { }

        public virtual void Update ()
        { 
           //x comportamiento
        }

        public abstract void Get();

        private void Hola() { }

        public virtual Miembros_de_la_Comunidad GetPersona()
        {
            throw new NotImplementedException();
        }
    }
}
