using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace BLL
{
    public class ClientsBLL
    {
        public int InsertClient(string name, string firstName, string secondName)
        {
            int rowsAffected;
            Client client = new Client(name, firstName, secondName);

            ClientsDAL clientDAL = new ClientsDAL();

            rowsAffected= clientDAL.InsertClient(client);

            return rowsAffected;
        }

        public int DeleteClientById(int idCliente)
        {
            int rowsAffected;

            ClientsDAL clientDAL = new ClientsDAL();

            rowsAffected = clientDAL.DeleteClientById(idCliente);

            return rowsAffected;
        }

        public List<string> ValidateClient(string name, string fSurname, string sSurname)
        {

            List<string> errorList = new List<string>();
            Client client = new Client(name, fSurname, sSurname);
            ValidationContext context = new ValidationContext(client);
            List<ValidationResult> errors = new List<ValidationResult>();

            if (!Validator.TryValidateObject(client, context, errors, true))
            {
                foreach (ValidationResult error in errors)
                {
                    errorList.Add(error.ErrorMessage);
                }
            }

            return errorList;
        }
        public DataTable SearchClientsByName(string name)
        {
            ClientsDAL clientsDAL = new ClientsDAL();

            return clientsDAL.SearchClientsByName(name);

        }
        public DataTable SearchClientsById(int id)
        {
            ClientsDAL clientsDAL = new ClientsDAL();

            return clientsDAL.SearchClientsById(id);

        }
        public DataTable SearchAllClients()
        {
            ClientsDAL clientsDAL = new ClientsDAL();

            return clientsDAL.SearchAllClients();
        }

        public DataTable UpdateUser(string id, string name, string fSurname, string sSurname)
        {
            ClientsDAL clientsDAL = new ClientsDAL();

            return clientsDAL.UpdateUser(id, name, fSurname, sSurname);
        }
    }
}
