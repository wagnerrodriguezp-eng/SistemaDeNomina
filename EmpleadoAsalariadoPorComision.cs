namespace SisDeNomina
{
    public class EmpleadoAsalariadoPorComision : EmpleadoAsalariado
    {
        public double VentasBrutas;
        public double TarifaComision;

        public EmpleadoAsalariadoPorComision(string primerNombre, string apellidoPaterno,
            string numeroSeguroSocial, double salarioBase, double tarifaComision, double ventasBrutas)
            : base(primerNombre, apellidoPaterno, numeroSeguroSocial, salarioBase)
        {
            VentasBrutas = ventasBrutas;
            TarifaComision = tarifaComision;
        }

        public override double CalcularPago()
        {
            double pagoComision = VentasBrutas * TarifaComision;
            double pagoSalario = SalarioSemanal + (SalarioSemanal * 0.10);
            return pagoSalario + pagoComision;
        }
    }
}
