using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaçãoOrientadaObjeto._02_Herança
{
    class Baleia : Mamifero
    {
        //Aqui temos um exemplo da classe Baleia que assim como a classe Elefante também herda a classe Mamifero
        //A classe Elefante herda tudo que a classe mamifero possuí, porém também possuí atributos e metodos próprios;
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
