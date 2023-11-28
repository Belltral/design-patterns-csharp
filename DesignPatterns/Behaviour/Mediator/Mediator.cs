
namespace DesignPatterns.Behaviour.Mediator
{
    public class Mediator
    {
        private List<Seller> sellers = new List<Seller>();

        public void AddSeller(params Seller[] sellers)
        {
            foreach (var seller in sellers)
            {
                this.sellers.Add(seller);
            }
        }

        public SellerProduct? Buy(string id)
        {
            SellerProduct? product = new SellerProduct();

            for (int i = 0; i < sellers.Count(); i++)
            {
                product = sellers[i].Sell(id);

                if (product != null)
                {
                    break;
                }
            }

            if (product == null)
            {
                Console.WriteLine($"Produto com id {id} não encontrado.");
                return null;
            }

            Console.WriteLine($"Produto: {product}");
            return product;
        }

        public void ShowProducts()
        {
            for (int i = 0; i < sellers.Count(); i++)
            {
                Console.WriteLine($"Seller {i+1}:");
                sellers[i].ShowProduct();
                Console.WriteLine("===================================");
                Console.WriteLine();
            }
        }
    }
}
