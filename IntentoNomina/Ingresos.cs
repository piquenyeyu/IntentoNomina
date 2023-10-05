using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntentoNomina
{
    public class Ingresos : ConstructorAbstracto
    {
        public Ingresos(string name, DateTime fechaNacimiento, DateTime fechaContracion, string nInss, string sexo, string cedula, 
            string estadoCivil, string direccion, string estado, decimal telefono, decimal salario, decimal horaExtra, decimal vacaciones,
            decimal antiguedad, decimal trabajoEstraordinario, decimal bono, decimal porcenComision, decimal ventasNetas) 
            : base(name, fechaNacimiento, fechaContracion, nInss, sexo, cedula, estadoCivil, direccion, estado, telefono, 
                  salario, horaExtra, vacaciones, antiguedad, trabajoEstraordinario, bono, porcenComision, ventasNetas)
        {
        }

        public decimal CalcularHorasExtras()
        {
            decimal PrecioHora = Salario / 240;
            decimal HorasExtras = PrecioHora * HoraExtra * 2;
            return HorasExtras;

        }

        public decimal CalcularVacaciones()
        {
            decimal ValVacaciones = (Salario / 240) * Vacaciones;
            return ValVacaciones;
        }

        public decimal CalcularTrabajoExtraordinario()
        {
            decimal ValHoExtraordinaria = (Salario / 240) * TrabajoEstraordinario;
            return ValHoExtraordinaria;
        }

        public decimal CalcularComision()
        {
            decimal comision = (PorcenComision * VentasNetas) / 100;
            return comision;
        }

        public decimal remuneracionbruta()
        {
            decimal RB = Salario + CalcularHorasExtras() + CalcularVacaciones() +
            CalcularComision() + CalcularTrabajoExtraordinario() + Bono;
            return RB;
        }

        public override string ToString() => $"{base.ToString()}\n" +
            $"Salario {Salario:C}" + $"valor por horas extras:{CalcularHorasExtras():C}" + $"Vacaciones:{CalcularVacaciones():C}" + $"valor por trabajo Extraordinario:{CalcularTrabajoExtraordinario():C}" + $"Comison:{CalcularComision():C}\n" +
            $"Remuneracion Bruta: {remuneracionbruta():C}";
        public override decimal RemuneracionBruta() => remuneracionbruta();
    }
}
