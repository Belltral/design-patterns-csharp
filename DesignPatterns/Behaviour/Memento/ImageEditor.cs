
using System.Xml.Linq;

namespace DesignPatterns.Behaviour.Memento
{
    //Originator
    public class ImageEditor
    {
        private string FilePath { get;set; }
        private string FileFormat { get; set; }

        public ImageEditor(string filePath, string fileFormat)
        {
            FilePath = filePath;
            FileFormat = fileFormat;
        }

        public void ConvertFormatTo(string format)
        {
            FileFormat = format;

            var splitFormat = FilePath.Split(".");

            FilePath = splitFormat[0] + "." + format;
        }

        public IMemento Save()
        {
            var date = DateTime.Now;

            return new ConcreteMemento(date.ToString("dd-MM-yyyy-HH:mm:ss"), date, FilePath, FileFormat);
        }

        public void Restore(IMemento memento)
        {
            ConcreteMemento concreteMemento = new ConcreteMemento();

            if (memento is not ConcreteMemento)
            {
                return;
            }

            concreteMemento = (ConcreteMemento)memento;

            FilePath = concreteMemento.GetFilePath();
            FileFormat = concreteMemento.GetFileFormat();
        }

        public override string ToString()
        {
            return $"FilePath: {FilePath}, FileFormat: {FileFormat}";
        }
    }
}
