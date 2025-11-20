using Microsoft.VisualBasic;

namespace _1_PracticaFinal_POO
{
    public partial class Form1 : Form
    {

        Gestionar_Agenda GA = new();

        public Form1()
        {
            InitializeComponent();
            // 1. Columnas enlazadas (si las necesitas explícitas)
            Grilla_Empleado.Columns.Add("Telefono", "Telefono");
            Grilla_Empleado.Columns["Telefono"].DataPropertyName = "Telefono";

            Grilla_Empleado.Columns.Add("Nombre", "Nombre");
            Grilla_Empleado.Columns["Nombre"].DataPropertyName = "Nombre";

            Grilla_Empleado.Columns.Add("Apellido", "Apellido");
            Grilla_Empleado.Columns["Apellido"].DataPropertyName = "Apellido";

            // 2. Columnas Calculadas (sin DataPropertyName, solo con Name)
            // El nombre de la propiedad 'Name' debe coincidir con el código
            Grilla_Empleado.Columns.Add("Sueldo", "Sueldo Calculado");
            Grilla_Empleado.Columns["Sueldo"].Name = "Sueldo"; // <--- ESTO ES CLAVE

            Grilla_Empleado.Columns.Add("AñosTrabajados", "Años Trabajados");
            Grilla_Empleado.Columns["AñosTrabajados"].DataPropertyName = "AñosTrabajados";
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
                if (CB_OP.Checked && CB_ADM.Checked)
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
                GA.MaestroDetalle(Grilla_Empleado);
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
    }
}
