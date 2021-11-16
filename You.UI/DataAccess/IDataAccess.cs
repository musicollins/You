using System.Collections.Generic;
using You.DTOs;

namespace You.UI.DataAccess
{
    public interface IDataAccess
    {
        IEnumerable<CustomerDTO> GetAll();
        void SaveCustomer(CustomerDTO cust);
    }
}