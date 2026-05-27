using SisDeNomina.SisDeNomina;

namespace SisDeNomina
{
    public class EmpleadoAsalariado : Empleado
    {
        public double SalarioSemanal;

        public EmpleadoAsalariado(string primerNombre, string apellidoPaterno,
                                  string numeroSeguroSocial, double salarioSemanal)
            : base(primerNombre, apellidoPaterno, numeroSeguroSocial) // llama al constructor padre
        {
            SalarioSemanal = salarioSemanal;
        }

        public override double CalcularPago() => SalarioSemanal;

        public override void getInfoEmpleado()
        {
            base.getInfoEmpleado(); // reutiliza el método del padre
            Console.WriteLine($"Salario Semanal: {SalarioSemanal}");
        }
    }
}
