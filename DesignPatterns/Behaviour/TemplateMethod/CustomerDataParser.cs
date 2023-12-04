
using System.Text.RegularExpressions;

namespace DesignPatterns.Behaviour.TemplateMethod
{
    public abstract class CustomerDataParser
    {
        public List<List<CustomerData>> customerData = new List<List<CustomerData>>();
        protected string FilePath { get; set; }

        public CustomerDataParser(string filePath)
        {
            FilePath = filePath;
        }

        public void FixCustomerData()
        {
            customerData.Add(ParseData());
            customerData.Add(FixCpf());
        }

        private List<CustomerData> FixCpf()
        {
            List<CustomerData> onlyNumbers = new List<CustomerData>();

            foreach (var customer in customerData[0])
            {
                CustomerData removedNonNumber = new CustomerData
                {
                    Name = customer.Name,
                    Age = customer.Age,
                    Cpf = Regex.Replace(customer.Cpf, @"[^\d]", "")
                };

                onlyNumbers.Add(removedNonNumber);
            }

            return onlyNumbers;
        }

        protected abstract List<CustomerData> ParseData();


    }
}
