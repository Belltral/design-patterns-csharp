
using System.Text.Json;

namespace DesignPatterns.Behaviour.TemplateMethod
{
    public class CustomerDataParserJson : CustomerDataParser
    {
        public CustomerDataParserJson(string filePath) : base(filePath)
        {
            
        }

        protected override List<CustomerData> ParseData()
        {
            string rawData = File.ReadAllText(FilePath);

            List<CustomerData>? customerData = JsonSerializer.Deserialize<List<CustomerData>>(rawData);

            return customerData;
        }
    }
}
