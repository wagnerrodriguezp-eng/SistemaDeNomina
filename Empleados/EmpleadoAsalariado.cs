namespace SisDeNomina
{
    class EmpleadoAsalariado
    {
        public string PrimerNombre;
        public string ApellidoPaterno;
        public string NumeroSeguroSocial;
        public double SalarioSemanal;


        public EmpleadoAsalariado(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, double salarioSemanal)
        {
            PrimerNombre = primerNombre;
            ApellidoPaterno = apellidoPaterno;
            NumeroSeguroSocial = numeroSeguroSocial;
            SalarioSemanal = salarioSemanal;
        }

        public double CalculoPago()
        {
            return SalarioSemanal;
        }

        public void getInfoEmpleado()
        {
            Console.WriteLine("Empleado Asalariado:\n" + "Nombre: " + PrimerNombre + "\nApellido: " + ApellidoPaterno + "\nNSS: " + NumeroSeguroSocial + "\nSalario Semanal: " + SalarioSemanal);
        }
    }
}
