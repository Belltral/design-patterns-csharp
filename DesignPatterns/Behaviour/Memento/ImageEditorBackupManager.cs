

namespace DesignPatterns.Behaviour.Memento
{
    public class ImageEditorBackupManager
    {
        private readonly ImageEditor _imageEditor;
        private List<IMemento> mementos = new List<IMemento>();

        public ImageEditorBackupManager(ImageEditor imageEditor)
        {
            _imageEditor = imageEditor;
        }

        public void Backup()
        {
            Console.WriteLine("Backup: Salvando o estado de ImageEditor");
            mementos.Add(_imageEditor.Save());
        }

        public void Undo()
        {
            var memento = mementos[mementos.Count() - 1];
            mementos.Remove(memento);

            if (memento == null)
            {
                Console.WriteLine("No mementos");
                return;
            }

            _imageEditor.Restore(memento);
            Console.WriteLine($"Backup: {memento.GetName()} foi restaurado com sucesso.");
        }

        public void ShowMementos()
        {
            foreach (var memento in mementos)
            {
                Console.WriteLine(memento);
            }
        }
    }
}
