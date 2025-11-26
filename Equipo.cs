using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PracticaFinal_POO
{
    public class Equipo : Notificar_Cambios
    {
        private string codigo;
        private DateTime fechaEntrada;
        private bool bit;
        private DateTime fechaSalida;
        private DateTime fechaCompra;
        private decimal valorCompra;
        private decimal valorFinal;

        public Equipo(string codigo, DateTime fechaEntrada, bool bit, DateTime fechaSalida, DateTime fechaCompra, decimal valorCompra, decimal valorFinal)
        {
            this.codigo = codigo;
            this.fechaEntrada = fechaEntrada;
            this.bit = bit;
            this.fechaSalida = fechaSalida;
            this.fechaCompra = fechaCompra;
            this.valorCompra = valorCompra;
            this.valorFinal = valorFinal;
        }

        public string Codigo
        {
            get => this.codigo;
            set
            {
                this.codigo = value;
                OnProperty();
            }
        }
        public DateTime FechaEntrada
        {
            get => this.fechaEntrada;
            set
            {
                this.fechaEntrada = value;
                OnProperty();
            }
        }
        public bool Bit
        {
            get => this.bit;
            set
            {
                this.bit = value;
                OnProperty();
            }
        }
        public DateTime FechaSalida
        {
            get => this.fechaSalida;
            set
            {
                this.fechaSalida = value;
                OnProperty();
            }
        }
        public DateTime FechaCompra
        {
            get => this.fechaCompra;
            set
            {
                this.fechaCompra = value;
                OnProperty();
            }
        }   
        public decimal ValorCompra
        {
            get => this.valorCompra;
            set
            {
                this.valorCompra = value;
                OnProperty();
            }
        }   
        public decimal ValorFinal
        {
            get => this.valorFinal;
            set
            {
                this.valorFinal = value;
                OnProperty();
            }
        }
    }
}
