namespace Biblioteca
{
    public class Cuenta
    {
        private string _titular;
        private decimal _cantidad;

        /// <summary>
        /// Clase que maneja el egreso e ingreso de dinero de clientes
        /// </summary>
        /// <param name="titular"></param>
        /// <param name="cantidad"></param>
        public Cuenta(string titular, decimal cantidad)
        {
            _titular = titular;
            _cantidad = cantidad;
        }

        public string Titular
        {
            get
            {
                return _titular;
            }
            set
            {
                _titular = value;
            }
        }

        public decimal Cantidad
        {
            get
            {
                return _cantidad;
            }
            set
            {
                _cantidad = value;
            }
        }

        /// <summary>
        /// Muestra el estado de cuenta del cliente
        /// </summary>
        /// <param name="titular"></param>
        /// <param name="cantidad"></param>
        /// <returns>Muestra información con el saldo actual de la cuenta</returns>
        public void Mostrar()
        {
            Console.WriteLine("\nSaldo actual:");
            Console.WriteLine($"Titular: {Titular} - Cantidad: {Cantidad:C2}");
            Console.WriteLine("-----------------------------------------------------------");
        }

        /// <summary>
        /// Metodo para agregar dinero a la cuenta
        /// </summary>
        /// <param name="monto"></param>
        public void Ingresar(decimal monto)
        {
            if (monto >= 0)
            {
                Cantidad += monto;
            }
        }

        /// <summary>
        /// Metodo para extraer dinero de la cuenta
        /// </summary>
        /// <param name="monto"></param>
        public void Retirar(decimal monto)
        {
            if (monto <= 0)
            {
                Cantidad += monto;
            }
        }

    }
}