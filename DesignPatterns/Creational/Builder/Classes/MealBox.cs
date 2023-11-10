using DesignPatterns.Creational.Builder.interfaces;

namespace DesignPatterns.Creational.Builder.Classes
{
    internal class MealBox : IMealComposite
    {
        private readonly List<IMealComposite> _children = new List<IMealComposite>();

        public double GetPrice()
        {
            if (_children.Count() != 0)
            {
                double soma = 0;
                foreach (var item in _children)
                {
                    soma += item.GetPrice();
                }
                return soma;
            }

            return 0;
        }

        public void Add(IMealComposite meal)
        {
            _children.Add(meal);
        }
    }
}
