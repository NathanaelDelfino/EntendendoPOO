using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaçãoOrientadaObjeto._01_Abstração
{
    class Carro : Veiculo
    {
        //A classe carro herda todos os atributos da superclasse veículo
        public Carro(int numeroRodas, string numeroSerie, int velocidade, int anoFabricacao)
        {
            this.NumemeroRodas = numeroRodas;
            this.NumeroSerie = numeroSerie;
            this.Velocidade = velocidade;
            this.AnoFabricacao = AnoFabricacao;
        }

        //Métodos que a superclasse, exige que a classe filho implemente.
        public override void Desligar()
        {
            throw new NotImplementedException();
        }
        public override void Ligar()
        {
            throw new NotImplementedException();
        }
    }
}
