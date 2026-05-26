namespace SisDeNomina
{
    class EmpleadoAsalariadoPorComision
    {
        public string PrimerNombre;
        public string ApellidoPaterno;
        public string NumeroSeguroSocial;
        public double VentasBrutas;
        public double TarifaComision;
        public double SalarioBase;

        public EmpleadoAsalariadoPorComision(string primerNombre, string apellidoPaterno, string numeroSeguroSocial,
                                             double ventasBrutas, double tarifaComision, double salarioSamanal)
        {
            PrimerNombre = primerNombre;
            ApellidoPaterno = apellidoPaterno;
            NumeroSeguroSocial = numeroSeguroSocial;
            VentasBrutas = ventasBrutas;
            TarifaComision = tarifaComision;
            SalarioBase = salarioSamanal;

        }

        public double CalcularPago()
        {
            double pagoComision = VentasBrutas * TarifaComision;
            double pagoSalario = SalarioBase + (SalarioBase * 0.10);
            return pagoSalario + pagoComision;
        }

        public void getInfoEmpleado()
        {
            Console.WriteLine("Empleado Asalariado Por Comisión:\n" + "Nombre: " + PrimerNombre + "\nApellido: " + ApellidoPaterno + "\nNSS: " + NumeroSeguroSocial + "\nVentas Brutas: " + VentasBrutas + "\nTarifa de Comisión: " + TarifaComision + "\nSalario Base: " + SalarioBase + "\n > Pago Semanal: " + CalcularPago());
        }
    }
}
