using IntentoNomina;

DateTime now = DateTime.Now;
Deducciones deduc = new("felix", now.ToString("YYYY-MM-dd"), now.ToString("YYYY-MM-DD"), "bgfiud", "masculino",  "081-110805-1009E", "soltero", "de la somoto ptero", "activo",03050509, 10000, 4, 2, 5, 8, 3000, 2, 25000);

Console.WriteLine(deduc.ToString());
Console.WriteLine($"IR: {deduc.CalculoiR()}:C" + $" laboral: {deduc.CalculoInssLaboral():C}\n + " +
    $"Total deducciones: {deduc.TotalDeducionesEmpleado():C}\n" +
    $"Remuneracion neta: {deduc.remuneracionbruta()-deduc.TotalDeducionesEmpleado():C}\\n\"" +
    $"Inss patronal: {deduc.CalculoInssPatronal:C}" + $"Inatec: {deduc.CalculoInatec():C}\n + " +
    $"Total deduciones a empresa:{deduc.TotalDeducionesEmpleado():C}");

