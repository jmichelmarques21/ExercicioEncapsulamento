using System;
using System.Globalization;

namespace ExercicioEncapsulamento {
    internal class ContaBancaria {
        public int NumConta { get; private set; }
        public string NomeCliente { get; set; }
        public double SaldoConta {get; private set;}


        public ContaBancaria() {

        }

        public ContaBancaria(int numConta) {
            NumConta = numConta;
        }

        public ContaBancaria(int numConta, string nomeCliente) {
            NumConta = numConta;
            NomeCliente = nomeCliente;
        }

        public ContaBancaria(int numConta, string nomeCliente, double saldoConta) {
            NumConta = numConta;
            NomeCliente = nomeCliente;
            SaldoConta = saldoConta;
        }

        public double Deposito(double valor) {
            return SaldoConta += valor;
        }

        public double Saque(double valor) {
            return (SaldoConta = SaldoConta - valor - 5.00);

        }


        public override string ToString() {
            return "Conta "
                    + NumConta
                    + ", titular: "
                    + NomeCliente
                    + ", Saldo: R$"
                    + SaldoConta.ToString("F2", CultureInfo.InvariantCulture);

        }

    }

}


