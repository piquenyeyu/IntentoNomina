using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntentoNomina
{
    public abstract class ConstructorAbstracto
    {
        public string Name { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaContracion { get; set; }
        public string NInss { get; set; }
        public string Sexo { get; set; }
        public string Cedula { get; set; }
        public string EstadoCivil { get; set; }
        public string Direccion { get; set; }
        public string Estado { get; set; }
        public decimal Telefono { get; set; }
        public decimal Salario { get; set; }
        public decimal HoraExtra { get; set; }   
        public decimal Vacaciones { get; set; }
        public decimal Antiguedad { get; set; }
        public decimal TrabajoEstraordinario { get; set; }
        public decimal Bono { get; set; }
        public decimal PorcenComision { get; set; }
        public decimal VentasNetas { get; set; }

        public ConstructorAbstracto(string name, DateTime fechaNacimiento, DateTime fechaContracion, string nInss, string sexo, string cedula, string estadoCivil,
             string direccion, string estado, decimal telefono, decimal salario, decimal horaExtra, decimal vacaciones,
                decimal antiguedad, decimal trabajoEstraordinario, decimal bono,decimal porcenComision, decimal ventasNetas)
        {
            Name = name; FechaNacimiento = fechaNacimiento; FechaContracion = fechaContracion; NInss = nInss; Sexo = sexo; Cedula = cedula; Estado = estado;
            EstadoCivil = estadoCivil; Direccion = direccion; Telefono = telefono; Salario = salario; HoraExtra = horaExtra;
            Vacaciones = vacaciones; Antiguedad = antiguedad; TrabajoEstraordinario = trabajoEstraordinario; Bono = bono;
            PorcenComision = porcenComision; VentasNetas = ventasNetas;
        }

        public override string ToString() => $"Datos Personales:\n Nombre {Name} + cedula: {Cedula} ";
        public abstract decimal RemuneracionBruta();
    }
}
