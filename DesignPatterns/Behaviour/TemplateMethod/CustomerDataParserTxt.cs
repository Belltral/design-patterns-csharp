


namespace DesignPatterns.Behaviour.TemplateMethod
{
    public class CustomerDataParserTxt : CustomerDataParser
    {
        public CustomerDataParserTxt(string filePath) : base(filePath)
        {
        }

        protected override List<CustomerData> ParseData()
        {
            StreamReader rawData = new StreamReader(FilePath);

            string? line = rawData.ReadLine();

            List<CustomerData> customerData = new List<CustomerData>();

            while (line != null)
            {
                var name = line.Split("\t")[0];
                var age = line.Split("\t")[1];
                var cpf = line.Split("\t")[2];

                customerData.Add(new CustomerData { Name = name, Age = age, Cpf = cpf });

                line = rawData.ReadLine();
            }

            return customerData;
        }
    }
}
