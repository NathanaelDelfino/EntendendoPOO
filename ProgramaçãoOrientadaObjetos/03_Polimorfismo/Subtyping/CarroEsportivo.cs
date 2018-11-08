using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramaçãoOrientadaObjeto._01_Abstração;

namespace ProgramaçãoOrientadaObjeto._03_Polimorfismo.Subtyping
{
    class CarroEsportivo : Carro
    {
        //SubTyping - Nesse tipo de polimorfismo é comum uma subclasse execute ou retorne de forma diferente da classe pai.
        public CarroEsportivo(int numeroRodas, string marca, string numeroSerie, int velocidade, int anoFabricacao) : base(numeroRodas, marca, numeroSerie, velocidade, anoFabricacao)
        {
            this.NumemeroRodas = numeroRodas;
            this.NumeroSerie = numeroSerie;
            this.Velocidade = velocidade;
            this.AnoFabricacao = AnoFabricacao;
        }
    
        public override void ChecarCombustivel()
        {
            base.ChecarCombustivel();
        }
        public override void Desligar()
        {
            base.Desligar();
        }
        public override void Ligar()
        {
            base.Ligar();
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
         
   return base.GetHashCode();
        }

        //Dessa forma estou sobreescrevendo o metodo Carro_Estado que existe na classe pai
        public new string Carro_Estado()
        {
            return "Seu veiculo encontrasse ligado!";
        }

    }
}
