using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaçãoOrientadaObjeto._02_Herança
{
    //Aqui temos um exemplo da classe Elefante herdando a classe Mamifero
    //A classe Elefante herda tudo que a classe mamifero possuí, porém também possuí atributos e metodos próprios;

    class Elefante : Mamifero
    {
        public int TamanhoTromba { get; set; }

        public Elefante(int tamanhoTromba)
        {
            this.ColocaOvos = false;
            this.NumeroPata = 4;
            this.Tamanho = 330;
            this.Terrestre = true;
            this.TamanhoTromba = tamanhoTromba;
        }

        public void SugarAguaComATromba() { }
        public void EsguicharAgua() { }
    }
}
