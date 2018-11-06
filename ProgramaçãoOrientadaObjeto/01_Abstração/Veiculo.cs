using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaçãoOrientadaObjeto._01_Abstração
{
    //Se dermos uma olhada no dicionário encontraremos a seguinte definição de abstração 
    //"Operação intelectual em que um objeto de reflexão é isolado de fatores que comumente lhe estão relacionados na realidade."
    //Na POO quando criamos uma classe ABSTRATA, criamos uma classe de um Objeto na sua forma mais genérica da qual podemos chamar de 
    //superclasse ou classe pai.
    //OBS: Uma classe ABSTRATA só pode ser HERDADA por OUTRA CLASSE e nunca instaciada direto por um objeto.

    //Temos a classe abstrata veículo, na qual irá conter os dados base para criar qualquer veículo
    public abstract class Veiculo
    {

        //Propriedades que todos os veículos irão ter.
        public int NumemeroRodas { get; set; }
        public int Velocidade { get; set; }
        public string NumeroSerie { get; set; }
        public int AnoFabricacao { get; set; }
        public int Combustivel { get; set; }

        //Metodos abstratos terão que terão de ser implementados pela classes quer herdarem da classe veículo
        public abstract void Ligar();
        public abstract void Desligar();

        //Metodos que todos os veículos irão ter.
        public int TotalDeCombustive()
        {
            return this.Combustivel;
        }
    }
}
