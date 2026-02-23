using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_23
{
    class Produto2
    {

        public Produto2(string nome, double preco, int estoque_minimo)
        {
            Nome = nome;
            Preco = preco;
            // O desconto por ser só get (e não ter set) não pode ter valor atribuido.
            // O mesmo vale pro preco final
            Estoque_Minimo = estoque_minimo;
        }

        public void Exibir()
        {
            Console.WriteLine($"{Nome}\n{Preco.ToString("c")}\n{Preco_Final.ToString("c")}\n {minimo}");
        }

        private string? nome;
        private double preco;

        public string? Nome {
            get { return nome.ToUpper(); } 
            set { nome = value; } 
        }
        public double Preco { 
            get { return preco; }
            set {
                if (preco > 5.00) { preco = 5.00; }
                else { preco = value; }
            }
        }
        private double desconto = 0.05;
        public double Desconto {  
            get { return desconto; } 
        }
        public double Preco_Final {
            get { return Preco - (Preco * Desconto);}
        }

        private int minimo;
        public int Estoque_Minimo { 
            set { minimo = value; }
        }

    }
}
