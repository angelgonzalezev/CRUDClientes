namespace CROUDClientes
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtFirstSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsertClient = new System.Windows.Forms.Button();
            this.txtSecondSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtIdClienteBorrar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDeleteClientById = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreClienteBuscar = new System.Windows.Forms.TextBox();
            this.txtIdClienteBuscar = new System.Windows.Forms.TextBox();
            this.btnSearchClients = new System.Windows.Forms.Button();
            this.rdName = new System.Windows.Forms.RadioButton();
            this.rdId = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(160, 63);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(115, 22);
            this.txtClientName.TabIndex = 0;
            // 
            // txtFirstSurname
            // 
            this.txtFirstSurname.Location = new System.Drawing.Point(160, 93);
            this.txtFirstSurname.Name = "txtFirstSurname";
            this.txtFirstSurname.Size = new System.Drawing.Size(115, 22);
            this.txtFirstSurname.TabIndex = 1;
            this.txtFirstSurname.TextChanged += new System.EventHandler(this.txtFirstSurname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primer Apellido:";
            // 
            // btnInsertClient
            // 
            this.btnInsertClient.Location = new System.Drawing.Point(158, 158);
            this.btnInsertClient.Name = "btnInsertClient";
            this.btnInsertClient.Size = new System.Drawing.Size(117, 48);
            this.btnInsertClient.TabIndex = 3;
            this.btnInsertClient.Text = "Insertar Cliente";
            this.btnInsertClient.UseVisualStyleBackColor = true;
            this.btnInsertClient.Click += new System.EventHandler(this.btnInsertClient_Click);
            // 
            // txtSecondSurname
            // 
            this.txtSecondSurname.Location = new System.Drawing.Point(160, 121);
            this.txtSecondSurname.Name = "txtSecondSurname";
            this.txtSecondSurname.Size = new System.Drawing.Size(115, 22);
            this.txtSecondSurname.TabIndex = 2;
            this.txtSecondSurname.TextChanged += new System.EventHandler(this.txtSecondSurname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Segundo Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Inserta un nuevo Cliente";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(160, 63);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(115, 22);
            this.txtNombreCliente.TabIndex = 0;
            this.txtNombreCliente.TextChanged += new System.EventHandler(this.txtNombreCliente_TextChanged);
            // 
            // txtIdClienteBorrar
            // 
            this.txtIdClienteBorrar.Location = new System.Drawing.Point(160, 266);
            this.txtIdClienteBorrar.Name = "txtIdClienteBorrar";
            this.txtIdClienteBorrar.Size = new System.Drawing.Size(115, 22);
            this.txtIdClienteBorrar.TabIndex = 3;
            this.txtIdClienteBorrar.TextChanged += new System.EventHandler(this.txtIdClienteBorrar_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Borra un cliente por ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "ID Cliente:";
            // 
            // btnDeleteClientById
            // 
            this.btnDeleteClientById.Location = new System.Drawing.Point(128, 297);
            this.btnDeleteClientById.Name = "btnDeleteClientById";
            this.btnDeleteClientById.Size = new System.Drawing.Size(147, 48);
            this.btnDeleteClientById.TabIndex = 3;
            this.btnDeleteClientById.Text = "Borrar cliente";
            this.btnDeleteClientById.UseVisualStyleBackColor = true;
            this.btnDeleteClientById.Click += new System.EventHandler(this.btnDeleteClientById_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(321, 93);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(724, 315);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Buscar un Cliente";
            // 
            // txtNombreClienteBuscar
            // 
            this.txtNombreClienteBuscar.Enabled = false;
            this.txtNombreClienteBuscar.Location = new System.Drawing.Point(597, 26);
            this.txtNombreClienteBuscar.Name = "txtNombreClienteBuscar";
            this.txtNombreClienteBuscar.Size = new System.Drawing.Size(134, 22);
            this.txtNombreClienteBuscar.TabIndex = 6;
            // 
            // txtIdClienteBuscar
            // 
            this.txtIdClienteBuscar.Enabled = false;
            this.txtIdClienteBuscar.Location = new System.Drawing.Point(597, 54);
            this.txtIdClienteBuscar.Name = "txtIdClienteBuscar";
            this.txtIdClienteBuscar.Size = new System.Drawing.Size(134, 22);
            this.txtIdClienteBuscar.TabIndex = 8;
            // 
            // btnSearchClients
            // 
            this.btnSearchClients.Location = new System.Drawing.Point(767, 28);
            this.btnSearchClients.Name = "btnSearchClients";
            this.btnSearchClients.Size = new System.Drawing.Size(103, 39);
            this.btnSearchClients.TabIndex = 9;
            this.btnSearchClients.Text = "Buscar";
            this.btnSearchClients.UseVisualStyleBackColor = true;
            this.btnSearchClients.Click += new System.EventHandler(this.btnSearchClients_Click);
            // 
            // rdName
            // 
            this.rdName.AutoSize = true;
            this.rdName.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdName.Location = new System.Drawing.Point(486, 26);
            this.rdName.Name = "rdName";
            this.rdName.Size = new System.Drawing.Size(105, 21);
            this.rdName.TabIndex = 5;
            this.rdName.TabStop = true;
            this.rdName.Text = "Por Nombre";
            this.rdName.UseVisualStyleBackColor = true;
            this.rdName.CheckedChanged += new System.EventHandler(this.rdName_CheckedChanged);
            // 
            // rdId
            // 
            this.rdId.AutoSize = true;
            this.rdId.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdId.Location = new System.Drawing.Point(523, 55);
            this.rdId.Name = "rdId";
            this.rdId.Size = new System.Drawing.Size(68, 21);
            this.rdId.TabIndex = 7;
            this.rdId.TabStop = true;
            this.rdId.Text = "Por ID";
            this.rdId.UseVisualStyleBackColor = true;
            this.rdId.CheckedChanged += new System.EventHandler(this.rdId_CheckedChanged);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1211, 530);
            this.Controls.Add(this.rdId);
            this.Controls.Add(this.rdName);
            this.Controls.Add(this.btnSearchClients);
            this.Controls.Add(this.txtIdClienteBuscar);
            this.Controls.Add(this.txtNombreClienteBuscar);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDeleteClientById);
            this.Controls.Add(this.btnInsertClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSecondSurname);
            this.Controls.Add(this.txtIdClienteBorrar);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtFirstSurname);
            this.Controls.Add(this.txtClientName);
            this.Name = "ClientForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtFirstSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsertClient;
        private System.Windows.Forms.TextBox txtSecondSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtIdClienteBorrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDeleteClientById;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreClienteBuscar;
        private System.Windows.Forms.TextBox txtIdClienteBuscar;
        private System.Windows.Forms.Button btnSearchClients;
        private System.Windows.Forms.RadioButton rdName;
        private System.Windows.Forms.RadioButton rdId;
    }
}

