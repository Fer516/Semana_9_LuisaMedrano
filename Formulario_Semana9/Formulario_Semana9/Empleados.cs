using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_Semana9
{
    class Empleados
    {
        private int id;
        private string nombre;
        private string dui;
        private double salario;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string DUI
        {
            get { return dui; }
            set { dui = value; }
        }
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }


        public double AFP(double Salario)

        {
            double CalcAFP = Salario * 0.0625;
            return CalcAFP;
        }

        public double ISS(double Salario)

        {
            double CalcISS = Salario * 0.3;
            return CalcISS;
        }

        public double SalarioNeto(double Salario)

        {
            double CalcSalarioNeto = Salario -(ISS(Salario) + AFP(Salario));
            return CalcSalarioNeto;
        }

    }
}
