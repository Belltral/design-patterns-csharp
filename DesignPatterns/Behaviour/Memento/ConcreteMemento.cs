


namespace DesignPatterns.Behaviour.Memento
{
    public class ConcreteMemento : IMemento
    {
        private readonly string _name;
        private readonly DateTime _date;
        private readonly string _filePath;
        private readonly string _fileFormat;

        public ConcreteMemento() { }

        public ConcreteMemento(string name, DateTime date, string filePath, string fileFormat)
        {
            _name = name;
            _date = date;
            _filePath = filePath;
            _fileFormat = fileFormat;
        }

        public string GetName()
        {
            return _name;
        }

        public DateTime GetDate()
        {
            return _date;
        }

        public string GetFilePath()
        {
            return _filePath;
        }

        public string GetFileFormat()
        {
            return _fileFormat;
        }
    }
}
