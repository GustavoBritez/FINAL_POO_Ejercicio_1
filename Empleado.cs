using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PracticaFinal_POO
{
    public abstract class Empleado : Notificar_Cambios , ICloneable
    {
        private string nombre;
        private string apellido;
        private string telefono;

        protected Empleado(string nombre, string apellido, string telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;

        }

        public string Nombre
        {
            get => this.nombre;
            set
            {
                this.nombre = value;
                OnProperty();
            }
        }
        public string Apellido
        {
            get => this.apellido;
            set
            {
                this.Apellido = value; OnProperty();
            }
        }
        public string Telefono
        {
            get => this.telefono;
            set
            {
                this.telefono = value; OnProperty();
            }
        }

        public abstract decimal CalcularSueldo();

        public object Clone()
        {
            // MemberwiseClone() crea una copia de cada campo
            // Para tipos de valor (int, decimal, etc.) copia el valor
            // Para tipos de referencia (string, List, etc.) copia la REFERENCIA
            return this.MemberwiseClone();
        }

        // Metodos para evitar dos numeros de telefono duplicados
        // Estos dos metodos sobreescritos lo que hacen es que se comparen los numeros de telefono al iterar sobre el obj

        public override bool Equals(object? obj)
        {
            return obj is Empleado empleado &&
                   telefono == empleado.telefono;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(telefono);
        }
    }
}
