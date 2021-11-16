using System.IO;

namespace You.DataSource
{
    public class Datasource
    {
        public string Data()
        {
            var path = @"C:\Users\rafae\source\repos\You\You.DataSource\customers.json";
            return File.ReadAllText(path);
        }

        public void UpdateData(string updatedData)
        {
            var path = @"C:\Users\rafae\source\repos\You\You.DataSource\customers.json";
            File.WriteAllText(path, updatedData);
        }
    }
}
