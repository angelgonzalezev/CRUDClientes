using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace CROUDClientes
{
    public partial class ModifyClientDataForm : Form
    {
        public DataTable Table { get; set; }
        public int Row { get; set; }

        public ModifyClientDataForm(DataTable table, int row)
        {
            InitializeComponent();
            Table = table;
            Row = row;
        }

        private void ModifyClientDataForm_Load(object sender, EventArgs e)
        {
            ClientsBLL clientsBLL = new ClientsBLL();

            txtIdUsuario.Text = Table.Rows[Row]["id"].ToString();
            txtNombreUsuario.Text = Table.Rows[Row]["Nombre"].ToString();
            txtPrimerApellidoUsuario.Text = Table.Rows[Row]["PrimerApellido"].ToString();
            txtSegundoApellidoUsuario.Text = Table.Rows[Row]["SegundoApellido"].ToString();
            txtFechaAfiliacion.Text = Table.Rows[Row]["FechaAfiliacion"].ToString();

        }

        private void txtFechaAfiliacion_TextChanged(object sender, EventArgs e)
        {
            txtFechaAfiliacion.Enabled = false;
        }

        private void txtIdUsuario_TextChanged(object sender, EventArgs e)
        {
            txtIdUsuario.Enabled = false;
        }

        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            ClientsBLL clientsBLL = new ClientsBLL();

            clientsBLL.UpdateUser(txtIdUsuario.Text, txtNombreUsuario.Text, txtPrimerApellidoUsuario.Text, txtSegundoApellidoUsuario.Text);

            var result=MessageBox.Show("Se ha modificado el usuario correctamente","Actualizacion de Usuario", MessageBoxButtons.OK);

            if (false)
            {
                this.Close();
            }
            Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
