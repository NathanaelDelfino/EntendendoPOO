using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaçãoOrientadaObjeto._02_Herança
{
    //Se dermos uma olhada no dicionario encontraremos a seguinte definição para herança : "ação de herdar, de adquirir por sucessão.",
    //Quanto uma classe herda outra por padrão ela herda também todas suas carcteristicas.

    //OBS: Se uma super classe não for do tipo abstrata ele pode ser instanciada por um objeto.

    public class Mamifero
    {
        public int NumeroPata { get; set; }
        public string TipoAlimentacao { get; set; }
        public bool Terrestre { get; set; }
        public bool ColocaOvos { get; set; }
        public int Tamanho { get; set; }
        public bool PossuiPelos { get; set; }

        public void Respirar() { }
        public void Dormir() { }
        public void Acordar() { }
    }
}
