using System;
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
        public void Eliminar( Empleado emp )
        {
            Lista_Empleados.Remove( emp );
        }
        // En este ejercicio en particular lo unico que no se puede cambiar es le Numero de Telefono
        public void Modificar( Empleado emp )
        {
            Empleado obtenerEmpleado = (from dato in Lista_Empleados
                                       where dato.Telefono.Equals(emp.Telefono)
                                       select dato).FirstOrDefault();
            if (obtenerEmpleado is null)
                return;
            obtenerEmpleado.Nombre = emp.Nombre;
            obtenerEmpleado.Apellido = emp.Apellido;
        }

        // Vamos a usar una estructura Maestro Detalle para actualizar las grillas automaticamente

        public void MaestroDetalle( DataGridView Grilla_Empleados  )
        {
            Grilla_Empleados.DataSource = this.Lista_Empleados;

        }

    }
}
