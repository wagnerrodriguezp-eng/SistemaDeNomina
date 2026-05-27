using SisDeNomina.SisDeNomina;
using System.Net.Security;

namespace SisDeNomina
{
    public class EmpleadoPorHoras : Empleado 
    {
        public double SueldoPorHora;
        public double HorasTrabajadas;

        public EmpleadoPorHoras(string apellidoPaterno,
            string numeroSeguroSocial, double sueldoPorHora, double horasTrabajadas)
            : base("", apellidoPaterno, numeroSeguroSocial) 
        {
            SueldoPorHora = sueldoPorHora;
            HorasTrabajadas = horasTrabajadas;
        }

        public override double CalcularPago()
        {
            if (HorasTrabajadas <= 40)
                return SueldoPorHora * HorasTrabajadas;
            else
            {
                double horaRegular = SueldoPorHora * 40;
                double horaExtra = SueldoPorHora * 1.5 * (HorasTrabajadas - 40);
                return horaRegular + horaExtra;
            }
        }

        public override void getInfoEmpleado()
        {
            base.getInfoEmpleado(); 
            Console.WriteLine($"Sueldo por hora: {SueldoPorHora}\nHoras trabajadas: {HorasTrabajadas}");
        }
    }
}
