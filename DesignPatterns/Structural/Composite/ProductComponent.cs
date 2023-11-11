using System.Text;

namespace DesignPatterns.Structural.Composite
{
    //Component
    public abstract class ProductComponent
    {
        public abstract float GetPrice();

        public void Add(ProductComponent product) { }

        public void Remove(ProductComponent product) { }

    }

    //Leaf
    public class ProductLeaf : ProductComponent
    {
        public string Name { get; set; }
        public float Price { get; set; }

        public ProductLeaf(string name, float price)
        {
            Name = name;
            Price = price;
        }

        public override float GetPrice()
        {
            return Price;
        }

        public override string ToString()
        {
            return $"Product {Name} - Price {Price}";
        }
    }

    //Composite
    public class ProductComposite : ProductComponent
    {
        private List<ProductComponent> Children = new List<ProductComponent>();


        public void Add(params ProductComponent[] products) 
        {
            if (products.Length > 0)
            {
                foreach (var product in products)
                {
                    Children.Add(product);
                }
            }
        }

        public void Remove(ProductComponent product)
        {
            if (Children.Contains(product))
            {
                Children.Remove(product);
            }
        }

        public override float GetPrice()
        {
            float total = 0;

            foreach (var item in Children)
            {
                total += item.GetPrice();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (var item in Children)
            {
                builder.AppendLine(item.ToString());
            }
            return builder.ToString();
        }
    }
}
