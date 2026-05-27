using SisDeNomina.SisDeNomina;

namespace SisDeNomina
{
    public class EmpleadoPorComision : Empleado 
    {
        
        public double VentasBrutas;
        public double TarifaComision;

        public EmpleadoPorComision(string primerNombre, string apellidoPaterno,
            string numeroSeguroSocial, double ventasBrutas, double tarifaComision)
            : base(primerNombre, apellidoPaterno, numeroSeguroSocial)
        {
            VentasBrutas = ventasBrutas;
            TarifaComision = tarifaComision;
        }

        public override double CalcularPago() => VentasBrutas * TarifaComision;

        public override void getInfoEmpleado()
        {
            base.getInfoEmpleado();
            Console.WriteLine($"Ventas Brutas: {VentasBrutas}\nTarifa Comisión: {TarifaComision}");
        }
    }
}
