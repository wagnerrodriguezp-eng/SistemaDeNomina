using SisDeNomina;

EmpleadoAsalariado empleado1 = new EmpleadoAsalariado("Juan", "Pérez", "NSS-901973", 50000);

EmpleadoPorHoras empleado2 = new EmpleadoPorHoras("Rodriguez", "NSS-151003", 120, 45);

EmpleadoPorComision empleado3 = new EmpleadoPorComision("Maria", "Pilar", "NSS-512782", 100000, 0.06);

EmpleadoAsalariadoPorComision empleado4 = new EmpleadoAsalariadoPorComision("Carlos", "Ramirez", "NSS-654321", 50000, 0.04, 30000);



empleado1.getInfoEmpleado();
Console.WriteLine();

empleado2.getInfoEmpleado();
Console.WriteLine();

empleado3.getInfoEmpleado();
Console.WriteLine();

empleado4.getInfoEmpleado();
Console.WriteLine();