using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace _1_PracticaFinal_POO
    {
        public class Administrativo : Empleado
        {

            private int añosTrabajados;
            private decimal sueldo = 800;
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

            public Administrativo(string nombre, string apellido, string telefono, DateTime anios ) : base(nombre, apellido, telefono)
            {
                // Calculamos el año
                this.añosTrabajados = DateTime.Now.Year - anios.Year;
                this.sueldo = CalcularSueldo();
            }

            public override decimal CalcularSueldo()
            {
                // No colocamos try catch por que queremos el error salga por burbujeo al lugar desde donde se llamo
                return ((this.sueldo * 0.02m)* this.añosTrabajados ) + sueldo;
            }
        
        }
    }
