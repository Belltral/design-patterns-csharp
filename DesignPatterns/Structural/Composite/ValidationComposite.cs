namespace DesignPatterns.Structural.Composite
{
    //Component
    public abstract class ValidationComponent
    {
        public abstract bool Validate(Object value);
    }

    //Leaf
    public class ValidateEmail : ValidationComponent
    {
        public override bool Validate(Object value)
        {
            if (value is not string)
            {
                return false;
            }

            string v = (string)value;

            return v.Contains('@');
        }
    }

    //Leaf
    public class ValidateString : ValidationComponent
    {
        public override bool Validate(object value)
        {
            return value is string;
        }
    }

    //Leaf
    public class ValidateNumber : ValidationComponent
    {
        public override bool Validate(object value)
        {
            return value is float;
        }
    }

    //Composite
    public class ValidationComposite : ValidationComponent
    {
        private readonly List<ValidationComponent> children = new List<ValidationComponent>();

        public override bool Validate(object value)
        {
            foreach (var child in children)
            {
                var validation = child.Validate(value);
                if (!validation)
                {
                    return false;
                }
            }

            return true;
        }

        public void Add(params ValidationComponent[] validations)
        {
            foreach (var item in validations)
            {
                children.Add(item);
            }
        }
    }
}
