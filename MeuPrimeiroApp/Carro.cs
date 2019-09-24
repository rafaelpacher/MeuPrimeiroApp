using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrimeiroApp
{
    class Carro
    {
        public string Modelo;
        public string Cor;
        public int QuantidadeDePortas;
        public bool PossuirArCondicionado;

        public Carro()
        {
            Modelo = "Fusca";
            Cor = "Azul";
            QuantidadeDePortas = 2;
            PossuirArCondicionado = false;

        }

        public string Ligar()
        {
            return "Motor Ligado.";
        }

        public string Desligar()
        {
            return "Motor Desligado.";
        }

        public string Detalhes()
        {
            return Modelo + " - " + Cor;
        }
    }
}
