using System.Net.Security;

namespace SisDeNomina
{
    class EmpleadoPorHoras
    {
        public string ApellidoPaterno;
        public string NumeroSeguroSocial;
        public double SueldoPorHora;
        public double HorasTrabajadas;

        
        public EmpleadoPorHoras(string apellidoPaterno, string numeroSeguroSocial, double sueldoPorHora, double horasTrabajadas)
        {
            ApellidoPaterno = apellidoPaterno;
            NumeroSeguroSocial = numeroSeguroSocial;
            SueldoPorHora = sueldoPorHora;
            HorasTrabajadas = horasTrabajadas;
        }

        public double CalcularHoras()
        {
            if (HorasTrabajadas <= 40)
            {
                return SueldoPorHora * HorasTrabajadas;
            }
            else
            {
                double horaRegular = SueldoPorHora * 40;
                double horaExtra = SueldoPorHora * 1.5 * (HorasTrabajadas - 40);
                return horaRegular + horaExtra;
            }
        }

        public void getInfoEmpleado() 
        {
            Console.WriteLine("Empleado Por Horas\n" + "Apellido paterno: " + ApellidoPaterno + "\nNSS: " + NumeroSeguroSocial + "\nSueldo por hora: " + SueldoPorHora + "\nHoras trabajadas: " + HorasTrabajadas + "\n > Pago Semanal: " + CalcularHoras());
        }

    }
}
