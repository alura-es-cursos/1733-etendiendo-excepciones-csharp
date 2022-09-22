using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.DatosCliente;

namespace ByteBank
{
    public class CuentaBancaria
    {
        //Atributos de la clase
        public static int _cantidad_cuentas = 0;

        //Atributos de instancia
        public string _numero_cuenta;
        public string _numero_agencia;
        private double _saldo;

        public CuentaBancaria(string _numero_cuenta, string _numero_agencia)
        {
            if (_numero_agencia == "")
            {
                throw new ArgumentException("Es necesario indicar el número de agencia",nameof(_numero_agencia));
            }
            if (_numero_cuenta == "")
            {
                throw new ArgumentException("Es necesario indicar el número de cuenta", nameof(_numero_cuenta));
            }
            this._numero_cuenta = _numero_cuenta;
            this._numero_agencia = _numero_agencia;

            ValorComision = 30 / _cantidad_cuentas;
            _cantidad_cuentas++;
        }
        

        //Propiedades
 

        public Cliente Cliente
        {
            get;set;
        }

        public string NumeroCuenta
        {
            get { return _numero_cuenta; }
            /*
            private set
            {
                if (value != null && value != "")
                    _numero_cuenta = value;
            }
            */
        }

        public string NumeroAgencia
        {
            get { return _numero_agencia; }
            /*
            private set
            {
                if (value != null && value != "")
                    _numero_agencia = value;
            }
            */
        }


        public double Saldo
        {
            get { return _saldo; }
            set {
                if (value >= 0)
                {
                    _saldo = value;
                }
                else
                {
                    _saldo = 0;
                }
            }
        }

        public double TasaInteres
        {
            get;set;
        }

        public double LimiteSobregiro
        {
            get; set;
        }

        public bool CuentaActiva
        {
            get; set;
        }

        public double ValorComision { get; private set; }



        //Métodos

        //Método RetirarDinero
        public bool RetirarDinero(double valorARetirar)
        {

            if (Saldo < valorARetirar)
            {
                Console.WriteLine("No hay saldo suficiente para el retiro");
                return false;
            } else if (valorARetirar <= 0)
            {
                Console.WriteLine("El valor a retirar debe ser mayor a 0");
                return false;
            }

            //saldo = saldo - valorARetirar;
            Saldo-= valorARetirar;

            return true;
        }

        //Método DepositarDinero
        public void DepositarDinero(double valorADepositar)
        {
            if (valorADepositar < 0)
            {
                Console.WriteLine("No es posible depositar valores negativos");
                return;
            }
            Saldo += valorADepositar;
            return;
        }

        //Método TransferirSaldo
        public double TransferirSaldo(double valorATransferir, CuentaBancaria cuentaReceptora)
        {
            //Retiramos el saldo de la cuenta origen
            RetirarDinero(valorATransferir);

            cuentaReceptora.DepositarDinero(valorATransferir);

            return Saldo;

        }

        /*
        public void DefinirSaldo(double saldoInicial)
        {
            if (saldoInicial >= 0)
            {
                saldo = saldoInicial;
            }
            else
            {
                Console.WriteLine("Saldo Inicial debe ser mayor o igual que 0");
            }
        }

        public double ObtenerSaldo()
        {
            return saldo;
        }
        */
    }
}
