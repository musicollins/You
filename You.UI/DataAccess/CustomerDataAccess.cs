using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using You.DataSource;
using You.DTOs;

namespace You.UI.DataAccess
{
    public class CustomerDataAccess : IDataAccess
    {
        private readonly Datasource _dataSource;

        public CustomerDataAccess(Datasource dataSource)
        {
            _dataSource = dataSource;
        }
        public IEnumerable<CustomerDTO> GetAll()
        {
            string jsonRes = _dataSource.Data();
            return JsonConvert.DeserializeObject<IEnumerable<CustomerDTO>>(jsonRes);
        }
        public void SaveCustomer(CustomerDTO cust)
        {
            string jsonRes = _dataSource.Data();
            var customers = JsonConvert.DeserializeObject<IEnumerable<CustomerDTO>>(jsonRes);
            var newList = customers.ToList();
            newList.Add(cust);
            var updatedData = JsonConvert.SerializeObject(newList);
            _dataSource.UpdateData(updatedData);
        }
    }   
}
