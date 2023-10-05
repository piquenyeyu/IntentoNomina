using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntentoNomina;

namespace IntentoNomina
{
    public class Deducciones : Ingresos
    { 
       
        public Deducciones(string name, DateTime fechaNacimiento, DateTime fechaContracion, string nInss, string sexo, string cedula,
            string estadoCivil, string direccion, string estado, decimal telefono, decimal salario, decimal horaExtra, decimal vacaciones,
            decimal antiguedad, decimal trabajoEstraordinario, decimal bono, decimal porcenComision, decimal ventasNetas)
            : base(name, fechaNacimiento, fechaContracion, nInss, sexo, cedula, estadoCivil, direccion, estado, telefono,
                  salario, horaExtra, vacaciones, antiguedad, trabajoEstraordinario, bono, porcenComision, ventasNetas)
        {
        }

        public decimal CalculoiR()
        {
            decimal ir = remuneracionbruta() * 12;
            if (ir > 100000 && ir <= 200000)
            {
                decimal IR = ((ir - 100000) * 15) / 1200;
                return IR;
            }
            else if (ir <= 350000 && ir > 200000)
            {
                decimal IR = ((((ir - 200000) * 20)/100) + 15000) / 12;
                return IR;
            }
            else if (ir <= 500000 && ir > 350000)
            {
                decimal IR = ((((ir - 350000) * 25)/100) + 45000) / 12;
                return IR;
            }
            else if (ir > 500000)
            {
                decimal IR = ((((ir - 500000) * 30)/100) + 82500) / 12;
                return IR;
            }
            else return 0;
        }

        public decimal CalculoInssLaboral()
        { 
          decimal Inss = (remuneracionbruta()*7)/100;
            return Inss;
        }

        public decimal CalculoInssPatronal()
        {
            decimal Inss = (remuneracionbruta() * 225) / 1000;
            return Inss;
        }

        public decimal CalculoInatec()
        {
            decimal Inatec = (remuneracionbruta() * 2) / 100;
            return Inatec;
        }

        public decimal TotalDeducionesEmpleado()
        {
            decimal TD = CalculoInssLaboral() + CalculoiR();
            return TD;
        }
        public decimal TotalDeducionesEmpresa()
        {
            decimal TD = CalculoInssPatronal() + CalculoInatec();
            return TD;
        }
    }
}
