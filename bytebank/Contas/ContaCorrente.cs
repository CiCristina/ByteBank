using bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Contas
{
    public class ContaCorrente
    {

        private int numero_agencia;

        public int Numero_agencia //recomendado colocar primeira letra M na propriedade
        {
            get { return this.numero_agencia;} //propriedade publica p manipular campos
            set { 
                        if (value > 0)
                        {
                        this.numero_agencia = value;
                        }
            }
        } 

        //private string conta;
        public string Conta { get; set; } //como defini essa propriedade, n tenho mais campo conta q era privado

        private double saldo = 100; 

        public Cliente Titular { get; set; }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }
        
        public void SetSaldo(double valor) //Definir
        {
            if(valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor; //pode ser saldo = saldo+valor (conferir uso do this)
            }
        }

        public double GetSaldo() //Obter
        {
            return this.saldo;
        }
              


    }
}
