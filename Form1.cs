using Microsoft.VisualBasic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace _1_PracticaFinal_POO
{
    public partial class BTN_ADD_EQ : Form
    {

        Gestionar_Agenda GA = new();

        public BTN_ADD_EQ()
        {
            InitializeComponent();

            Grilla_Empleado.AllowUserToAddRows = false;

            Grilla_Empleado.Columns.Add("Telefono", "Telefono");
            Grilla_Empleado.Columns["Telefono"].DataPropertyName = "Telefono";

            Grilla_Empleado.Columns.Add("Nombre", "Nombre");
            Grilla_Empleado.Columns["Nombre"].DataPropertyName = "Nombre";

            Grilla_Empleado.Columns.Add("Apellido", "Apellido");
            Grilla_Empleado.Columns["Apellido"].DataPropertyName = "Apellido";


            Grilla_Empleado.Columns.Add("Sueldo", "Sueldo Calculado");
            Grilla_Empleado.Columns["Sueldo"].Name = "Sueldo"; 

            Grilla_Empleado.Columns.Add("AñosTrabajados", "Años Trabajados");
            Grilla_Empleado.Columns["AñosTrabajados"].DataPropertyName = "AñosTrabajados";


            Grilla_Equipos.AllowUserToAddRows = false;
            Grilla_Equipos.Columns.Add("Codigo", "Codigo");
            Grilla_Equipos.Columns["Codigo"].DataPropertyName = "Codigo";

            Grilla_Equipos.Columns.Add("FechaEntrada", "Fecha Entrada");
            Grilla_Equipos.Columns["FechaEntrada"].DataPropertyName = "FechaEntrada";

            Grilla_Equipos.Columns.Add("Bit", "Bit");
            Grilla_Equipos.Columns["Bit"].DataPropertyName = "Bit";

            Grilla_Equipos.Columns.Add("FechaSalida", "Fecha Salida");
            Grilla_Equipos.Columns["FechaSalida"].DataPropertyName = "FechaSalida";    

            Grilla_Equipos.Columns.Add("FechaCompra", "Fecha Compra");
            Grilla_Equipos.Columns["FechaCompra"].DataPropertyName = "FechaCompra";    
            
            Grilla_Equipos.Columns.Add("ValorCompra", "Valor Compra");
            Grilla_Equipos.Columns["ValorCompra"].DataPropertyName = "ValorCompra";    

            Grilla_Equipos.Columns.Add("ValorFinal", "Valor Final");
            Grilla_Equipos.Columns["ValorFinal"].DataPropertyName = "ValorFinal";

        }

        private void BTN_AGREGAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (CB_ADM.Checked && !CB_OP.Checked)
                {
                    Administrativo newADM = new
                    (
                     Interaction.InputBox("Ingrese Nombre"),
                     Interaction.InputBox("Ingrese Apellido"),
                     Interaction.InputBox("Ingrese Telefono"),
                     PICKER.Value
                    );
                    GA.Agregar(newADM);
                }
                if (CB_OP.Checked && !CB_ADM.Checked)
                {
                    Operario newOP = new
                    (
                     Interaction.InputBox("Ingrese Nombre"),
                     Interaction.InputBox("Ingrese Apellido"),
                     Interaction.InputBox("Ingrese Telefono"),
                     PICKER.Value
                    );
                    GA.Agregar(newOP);
                }
                if (CB_OP.Checked == false && CB_ADM.Checked == false)
                {
                    MessageBox.Show("Porfavor realiza una unica seleccion");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                GA.MaestroDetalle(Grilla_Empleado, Grilla_Equipos);
            }
        }

        private void Grilla_Empleado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == Grilla_Empleado.NewRowIndex || e.ColumnIndex < 0)
                return;

            Empleado emp = Grilla_Empleado.Rows[e.RowIndex].DataBoundItem as Empleado;

            if (emp == null)
                return;

            string columnName = Grilla_Empleado.Columns[e.ColumnIndex].Name;

            if (columnName == "Sueldo")
            {
                // El Sueldo se calcula polimiorficamente, es decir, el metodo correcto de la subclase se llama automaticamente.
                e.Value = emp.CalcularSueldo().ToString("C");
                e.FormattingApplied = true;
            }
            else if (columnName == "AñosTrabajados")
            {
                switch (emp)
                {
                    case Administrativo adm:
                        e.Value = adm.AñosTrabajados.ToString();
                        break;
                    case Operario op:
                        e.Value = op.AñosTrabajados.ToString();
                        break;
                    default:
                        e.Value = "N/A";
                        break;
                }
                e.FormattingApplied = true;
            }
        }

        private void TXT_BUSQUEDA_TextChanged(object sender, EventArgs e)
        {
            Grilla_Empleado.DataSource = null;
            var lista = GA.Lista_Empleados;

            var busqueda = (from dato in lista
                            where dato.Nombre.Contains(TXT_BUSQUEDA.Text)
                            select dato).ToList();

            Grilla_Empleado.DataSource = busqueda;
        }

        private void checkBox2_MouseClick(object sender, MouseEventArgs e)
        {
            List<Empleado> Ascendente = GA.Lista_Empleados.ToList();

            Grilla_Empleado.DataSource = null;
            Grilla_Empleado.DataSource = Ascendente.OrderBy(e => e.Nombre).ToList();

            Grilla_Empleado.Refresh();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            List<Empleado> Ascendente = GA.Lista_Empleados.ToList();

            Grilla_Empleado.DataSource = null;
            Grilla_Empleado.DataSource = Ascendente.OrderByDescending(e => e.Nombre).ToList();
            Grilla_Empleado.Refresh();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            List<Empleado> Ascendente = GA.Lista_Empleados.ToList();

            Grilla_Empleado.DataSource = null;
            Grilla_Empleado.DataSource = Ascendente.OrderByDescending(e => e.CalcularSueldo()).ToList();
            Grilla_Empleado.Refresh();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            List<Empleado> Ascendente = GA.Lista_Empleados.ToList();

            Grilla_Empleado.DataSource = null;
            Grilla_Empleado.DataSource = Ascendente.OrderBy(e => e.CalcularSueldo()).ToList();
            Grilla_Empleado.Refresh();
        }

        private void BTN_ELIMINAR_Click(object sender, EventArgs e)
        {
            if (Grilla_Empleado.SelectedRows.Count == 0) throw new ArgumentException("Debes seleccionar una fila para continuar ");


            int telefono = Convert.ToInt32(Grilla_Empleado.SelectedRows[0].Cells["Telefono"].Value);

            GA.Eliminar(telefono);

            Grilla_Empleado.Refresh();
        }

        private void BTN_MODIFICAR_Click(object sender, EventArgs e)
        {
            GA.Modificar(
                Convert.ToInt32(Grilla_Empleado.SelectedRows[0].Cells["Telefono"].Value),
                Interaction.InputBox("Ingrese nuevo nombre"),
                Interaction.InputBox("Ingrese nuevo nombre")
                );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigo = "XXX";
            DateTime fechaEntrada = DateTime.Now;
            bool bit = false;
            DateTime fechaSalida;
            if (bit)
            {
                fechaSalida = DateTime.Now.AddDays(10);
            }
            else
            {
                fechaSalida = DateTime.ParseExact("01/12/2999", "d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }
            DateTime fechaCompra = DateTime.Now.AddMonths(-34);
            decimal valorCompra = 10000m;
            decimal valorFinal = valorCompra - ((valorCompra * 0.15m) * (DateTime.Now.Year - fechaCompra.Year));

            GA.Add(
                new Equipo(
                    codigo,
                    fechaEntrada,
                    bit,
                    fechaSalida,
                    fechaCompra,
                    valorCompra,
                    valorFinal
                    )
                );
            GA.MaestroDetalle(Grilla_Empleado, Grilla_Equipos);

        }

        private void BTN_ELIMINEQ_Click(object sender, EventArgs e)
        {

        }

        private void Grilla_Equipos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == Grilla_Equipos.NewRowIndex || e.ColumnIndex < 0)
                return;

            Equipo eq = Grilla_Equipos.Rows[e.RowIndex].DataBoundItem as Equipo;    

            if ( eq is null )
            {
                return;
            }

            string columname = Grilla_Equipos.Columns[e.ColumnIndex].Name;

            if ( columname == "Codigo")
            {
                e.Value = eq.Codigo;
                e.FormattingApplied = true;
            }


        }
    }
}
