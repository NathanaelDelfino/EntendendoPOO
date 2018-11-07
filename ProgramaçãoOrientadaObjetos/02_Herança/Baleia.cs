using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaçãoOrientadaObjeto._02_Herança
{
    class Baleia : Mamifero
    {

        public int TempoSemRespirar { get; set; }

        public Baleia()
        {
            this.ColocaOvos = false;
            this.NumeroPata = 0;
            this.Tamanho = 2400;
            this.Terrestre = false;
            
        }

        public void Nadar() { }
        

    }
}
