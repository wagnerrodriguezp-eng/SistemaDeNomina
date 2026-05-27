namespace SisDeNomina
{
    namespace SisDeNomina
    {
        public class Empleado
        {
            public string PrimerNombre;
            public string ApellidoPaterno;
            public string NumeroSeguroSocial;

            public Empleado(string primerNombre, string apellidoPaterno, string numeroSeguroSocial)
            {
                PrimerNombre = primerNombre;
                ApellidoPaterno = apellidoPaterno;
                NumeroSeguroSocial = numeroSeguroSocial;
            }

            public virtual double CalcularPago() { return 0; }

            public virtual void getInfoEmpleado()
            {
                Console.WriteLine($"Nombre: {PrimerNombre}\nApellido: {ApellidoPaterno}\nNSS: {NumeroSeguroSocial}");
            }
        }
    }
}
