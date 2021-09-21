using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionAPOO
{
    class Paciente
    { // Miembros de la clase 
        //propiedades
        private string _PacienteId;
        private int _age;
        // propiedad autoimplementada {get; set;}
        public string _addres { get; set; }

        // metodos de propiedad 
        // obtiene el nombre del paciente
        public string getPacienteId()
        {
            return _PacienteId;

        }
        public void  setPacienteId(string pacienteid)
        {
            _PacienteId = pacienteid;
        }
        
        public int getAge()
        {
            return _age;
        }
        public void setAge(int age )
        {
            _age = age;
        }

       /* public string getAddress ()
        {
            return _addres;

        }
        
        public void setAddres(string address)
        {
            _addres = address; 
        } */
    }
}
