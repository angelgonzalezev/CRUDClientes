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
using System.Text.RegularExpressions;

namespace CROUDClientes
{
    public partial class ClientForm : Form
    {
        DataTable tableClients = new DataTable();
        public ClientForm()
        {
            InitializeComponent();
        }

        private void btnInsertClient_Click(object sender, EventArgs e)
        {
            int affectedRows;
            try
            {
                ClientsBLL clientBLL = new ClientsBLL();

                List<string> errors = clientBLL.ValidateClient(txtNombreCliente.Text, txtFirstSurname.Text, txtSecondSurname.Text);
                if (errors.Count > 0)
                {
                    ValidatorInterface.ShowErrorListMessageBox(errors);
                }
                else
                {
                    affectedRows = clientBLL.InsertClient(txtNombreCliente.Text, txtFirstSurname.Text, txtSecondSurname.Text);
                    MessageBox.Show("Se ha insertado " + affectedRows.ToString() + " fila.");
              
                }
                tableClients = clientBLL.SearchAllClients();
                dataGridView.DataSource = tableClients;

            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error: \r\n" + error.Message);
            }

        }

        private void btnDeleteClientById_Click(object sender, EventArgs e)
        {
            int affectedRows;
            try
            {
                ClientsBLL clientBLL = new ClientsBLL();
                if (txtIdClienteBorrar.Text == null)
                {
                    MessageBox.Show("Debes ingresar un id");
                }
                else
                {

                    affectedRows = clientBLL.DeleteClientById(Int32.Parse(txtIdClienteBorrar.Text));
                    MessageBox.Show("Se ha eliminado " + affectedRows.ToString() + " fila.");
                }
                tableClients = clientBLL.SearchAllClients();
                dataGridView.DataSource = tableClients;

            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error: \r\n" + error.Message);
            }

        }

        private void txtIdClienteBorrar_TextChanged(object sender, EventArgs e)
        {
            var result = Regex.Replace(txtIdClienteBorrar.Text, @"[^""0-9""]", "");
            txtIdClienteBorrar.Text = result;
            txtIdClienteBorrar.Select(txtIdClienteBorrar.Text.Length, 0);
        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {
            var result = Regex.Replace(txtNombreCliente.Text, @"[^a-zA-ZñÑ\s]", "");
            txtNombreCliente.Text = result;
            txtNombreCliente.Select(txtNombreCliente.Text.Length, 0);
        }

        private void txtFirstSurname_TextChanged(object sender, EventArgs e)
        {
            var result = Regex.Replace(txtFirstSurname.Text, @"[^a-zA-ZñÑ\s]", "");
            txtFirstSurname.Text = result;
            txtFirstSurname.Select(txtFirstSurname.Text.Length, 0);
        }

        private void txtSecondSurname_TextChanged(object sender, EventArgs e)
        {
            var result = Regex.Replace(txtSecondSurname.Text, @"[^a-zA-ZñÑ\s]", "");
            txtSecondSurname.Text = result;
            txtSecondSurname.Select(txtSecondSurname.Text.Length, 0);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchClients_Click(object sender, EventArgs e)
        {
            ClientsBLL clientsBLL = new ClientsBLL();

            if (rdName.Checked)
            {
                try
                {

                    tableClients = clientsBLL.SearchClientsByName(txtNombreClienteBuscar.Text);

                }
                catch
                {
                    MessageBox.Show("No exiten clientes con ese nombre");
                }

            }
            else if (rdId.Checked)
            {
                try
                {
                    tableClients = clientsBLL.SearchClientsById(Int32.Parse(txtIdClienteBuscar.Text));
                }
                catch
                {
                    MessageBox.Show("No exite cliente con esa id.");
                }
            }
            if (tableClients.Rows.Count > 0)
            {
            
                dataGridView.DataSource = tableClients;
            }
            else
            {
                if(txtNombreClienteBuscar.Text=="" && txtIdClienteBuscar.Text=="")
                {
                    tableClients = clientsBLL.SearchAllClients();

                    dataGridView.Columns.Clear();
                    dataGridView.DataSource = tableClients;

                }
                else
                {
                    MessageBox.Show("No se ha encontrado cliente.");
                }
            }


        }

        private void rdName_CheckedChanged(object sender, EventArgs e)
        {
            txtNombreClienteBuscar.Enabled = true;
            txtIdClienteBuscar.Enabled = false;
        }

        private void rdId_CheckedChanged(object sender, EventArgs e)
        {
            txtIdClienteBuscar.Enabled = true;
            txtNombreClienteBuscar.Enabled = false;
        }
       
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ModifyClientDataForm ModifyUser = new ModifyClientDataForm(tableClients, e.RowIndex);
            ClientsBLL clientsBLL = new ClientsBLL();

            ModifyUser.ShowDialog();

            tableClients = clientsBLL.SearchAllClients();
            dataGridView.DataSource = tableClients;

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            ClientsBLL clientsBLL = new ClientsBLL();
            tableClients = clientsBLL.SearchAllClients();

            dataGridView.Columns.Clear();
            dataGridView.DataSource = tableClients;
        }
    }
}
