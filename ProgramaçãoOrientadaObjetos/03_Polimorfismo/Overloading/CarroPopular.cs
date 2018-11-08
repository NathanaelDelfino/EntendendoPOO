using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramaçãoOrientadaObjeto._01_Abstração;
namespace ProgramaçãoOrientadaObjeto._03_Polimorfismo
{
    public class CarroPopular : Veiculo
    {
        //Overloading - Conhecido como polimorfismo de sobrecarga, onde você possuí um metodo com diferentes parametros

        //Construtor
        public CarroPopular(int numeroRodas, string marca): base(numeroRodas,marca)
        {
            this.NumemeroRodas = numeroRodas;
            this.Marca = marca;
        }
        
        //Metodos que a classe pai obriga a classe filho a sobreescrever
        public override void Desligar()
        {
            //aqui vai a meneira, em que o carro popular Desliga   
        }
        public override void Ligar()
        {
            //aqui vai a meneira, em que o carro popular Liga;
        }
        public override void ChecarCombustivel()
        {
            //aqui vai a meneira, em que o carro popular Verifica se tem combustivel
        }

        //Uma das maneiras de utilizar o POLIMORFISMO, é através da sobrecarga de metodos
        //Nesse caso temos várias formas de ativar recursos que estão em carro
        public void AtivarRecurso(bool ligarMotor)
        {
            //Aqui vai a meneira que liga o motor
        }
        public void AtivarRecurso(bool ligarMotor, bool ligarFarol)
        {
            //Aqui vai a meneira que liga o motor
        }
        public void AtivarRecurso(string Pisca)
        {
            //Aqui vai a meneira que liga o motor
        }
    }
}
