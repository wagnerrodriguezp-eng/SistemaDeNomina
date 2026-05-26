namespace SisDeNomina
{
    class EmpleadoPorComision
    {
        public string PrimerNombre;
        public string ApellidoPaterno;
        public string NumeroSeguroSocial;
        public double VentasBrutas;
        public double TarifaComision;



        public EmpleadoPorComision(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, double ventasBrutas, double tarifaComision)
        {
            PrimerNombre = primerNombre;
            ApellidoPaterno = apellidoPaterno;
            NumeroSeguroSocial = numeroSeguroSocial;
            VentasBrutas = ventasBrutas;
            TarifaComision = tarifaComision;
        }

        public double CalcularPago()
        {
            return  VentasBrutas * TarifaComision;
        }

        public void getInfoEmpleado()
        {
            Console.WriteLine("Empleado Por Comisión:\n" + "Nombre: " + PrimerNombre + "\nApellido: " + ApellidoPaterno + "\nNSS: " + NumeroSeguroSocial + "\nVentas Brutas: " + VentasBrutas + "\nTarifa de Comisión: " + TarifaComision + "\n > Pago Semanal: " + CalcularPago());
        }

    }
}
