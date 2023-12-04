

using System.Text;

namespace DesignPatterns.Behaviour.TemplateMethod
{
    public class CustomerData
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Cpf { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nome: {Name}");
            sb.AppendLine($"Idade: {Age}");
            sb.AppendLine($"CPF: {Cpf}");
            sb.AppendLine("==========================================");
            return sb.ToString();
        }
    }
}
