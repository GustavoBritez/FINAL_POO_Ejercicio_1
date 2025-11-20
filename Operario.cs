using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PracticaFinal_POO
{
    public class Operario : Empleado
    {
        private int añosTrabajados;
        private decimal sueldo = 600;
        public decimal Sueldo
        {
            get => this.sueldo;
            set
            {
                this.sueldo = value;
                OnProperty();
            }
        }
        public int AñosTrabajados
        {
            get => this.añosTrabajados;
            set
            {
                this.añosTrabajados = value;
                OnProperty();
            }
        }
        public Operario(string nombre, string apellido, string telefono, DateTime anios) : base(nombre, apellido, telefono)
        {
            this.añosTrabajados = DateTime.Now.Year - anios.Year;
            this.sueldo = CalcularSueldo();
        }

        public override decimal CalcularSueldo()
        {
            return ((this.sueldo*0.02m)*this.añosTrabajados) + this.sueldo;
        }
    }
}
