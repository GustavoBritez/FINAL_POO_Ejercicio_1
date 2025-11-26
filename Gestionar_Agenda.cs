using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _1_PracticaFinal_POO
{
    public class Gestionar_Agenda
    {
        public BindingList<Empleado> Lista_Empleados = new();
        public BindingList<Equipo> Lista_Equipos = new();
        public Gestionar_Agenda()
        {

        }

        // No podemos agregar duplicados, si bien hay otra forma mas corta usaremos LINQ para aplicar
        // los contenidos de la materia
        public void Agregar( Empleado nuevoEmp )
        {
            bool existencia = (from dato in Lista_Empleados
                               where dato.Telefono.Equals(nuevoEmp.Telefono)
                               select dato).Any();
            if (existencia)
            {
                // Si el empleado ya existe
                throw new ArgumentException("Error, ya exite el num telefonnico");
            }
            else
            {
                // Si el empleado NO existe, lo agregamos.
                try
                {

                    Lista_Empleados.Add((Empleado)nuevoEmp.Clone());
                }

                catch (Exception ex)
                {
                    throw new InvalidOperationException("Error al intentar agregar o clonar el empleado: " + ex.Message);
                }
            }
        }
        public void Eliminar( int telefono)
        {

            foreach ( var emp in Lista_Empleados )
            {
                if ( emp.Telefono.Equals( telefono.ToString() ) )
                {
                    Lista_Empleados.Remove( emp );
                    break;
                }
            }
        }
        // En este ejercicio en particular lo unico que no se puede cambiar es le Numero de Telefono
        public void Modificar( int telefono , string nombre, string apellido)
        {

            foreach( var empleado in this.Lista_Empleados )
            {
                if (!empleado.Equals( telefono.ToString() ))
                {
                    empleado.Nombre = nombre;
                    empleado.Apellido = apellido;
                }
            }
        }

        // Vamos a usar una estructura Maestro Detalle para actualizar las grillas automaticamente

        public void Add(Equipo eq)
        {
            var existencia = (from entidad in Lista_Equipos
                              where entidad.Codigo.Equals(eq.Codigo)
                              select entidad).Any();
            if (existencia)
            {
                throw new ArgumentException("Error, ya exite el equipo");
            }
            else
            {
                try
                {
                    this.Lista_Equipos.Add(eq);
                }
                catch ( Exception ex )
                {
                    MessageBox.Show("Error al intentar agregar o clonar el equipo: " + ex.Message); 
                }
            }
        }

        public void EliminarEQ(string codigo)
        {
            var equipoEliminar = (from entidad in this.Lista_Equipos
                                  where entidad.Codigo.Equals(codigo)
                                  select entidad).Any();
            if (equipoEliminar)
            {
                try
                {
                    foreach( Equipo eq in Lista_Equipos)
                    {
                        if ( eq.Codigo.Equals(codigo))
                        {
                            this.Lista_Equipos.Remove(eq);return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar el equipo: " + ex.Message);
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public void ModificarEQ( int codigo , Equipo newEq )
        {
            foreach( Equipo eq in Lista_Equipos )
            {
                if (eq.Codigo.Equals(codigo))
                {
                    eq.FechaEntrada = newEq.FechaEntrada;
                    eq.Bit = newEq.Bit;
                    eq.FechaSalida = newEq.FechaSalida;
                    eq.FechaCompra = newEq.FechaCompra;
                    eq.ValorCompra = newEq.ValorCompra;
                    eq.ValorFinal = newEq.ValorFinal;
                    return;
                }

            }
        }   
        public void MaestroDetalle( DataGridView Grilla_Empleados , DataGridView Grilla_Equipo )
        {
            Grilla_Empleados.DataSource = this.Lista_Empleados;
            Grilla_Equipo.DataSource = this.Lista_Equipos;  
        }

    }
}
