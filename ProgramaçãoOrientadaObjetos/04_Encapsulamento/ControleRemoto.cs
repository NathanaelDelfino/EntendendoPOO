using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaçãoOrientadaObjeto._04_Encapsulamento
{
    class ControleRemoto
    {
        //Encapsulamento - É uma forma de ocultar os membros de uma classe, onde você permite visibilidade 
        //somente do que você deseja, para a classe ou objeto que esteja utilizando.
        public int CanalTV { get; private set; }
        public int Volume { get; private set; }

        //Para aumentar ou diminuir o canal da TV, só é possivel através do metodo AlterarCanal, pois o aributo CanalTV é privado para setar valor
        public void AlterarCanal(bool aumentar)
        {
            if (aumentar)
            {
                this.CanalTV += 1;
            }
            else
            {
                this.CanalTV -= 1;
            }
            
        }
        //Para aumentar ou diminuir o volume da TV, só é possivel através do metodo AlterarVolume, pois o aributo Volume é privado para setar valor
        public void AlterarVolume(bool aumentar)
        {
            if (aumentar)
            {
                this.Volume += 1;
            }
            else
            {
                this.Volume -= 1;
            }
        }
    }
}
