using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

namespace Aula60 {
    class ContaBancaria {

        public int NrConta { get; private set; }
        private String _titular; // não pode ser implementaado auto properties por ter uma logica implementada
        public double Saldo { get; private set; } //auto properties
        public ContaBancaria(int conta, String nome) {
            NrConta = conta;
            _titular = nome;
        }
        public ContaBancaria(int conta, string nome, double valor) : this(conta, nome) { // reaproveita construtor de 2 arguntos acima
            depositar(valor);
        }
        public String Titular { // utilizando properties para eliminar os metodos get e set
            get { return _titular; }
            set {
                if ((value != null) && (value.Length >= 2))
                {
                    _titular = value;
                }
            }
        }
        public override string ToString() {
            return "Conta: " + NrConta +
                " Titular: " + Titular +
                " Saldo R$: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
        public void depositar(double valor) {
            Saldo += valor;
        }
        public void sacar(double valor) {
            int taxa = 5;
            Saldo = Saldo - valor - taxa;
        }

    }
}
