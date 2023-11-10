namespace DesignPatterns.Creational.Singleton
{
    internal class Singleton
    {
        private static Singleton Instance { get; set; }

        private string Nome { get; set; }

        private Singleton() { }

        public static Singleton GetInstance() //O método retorna um instância da classe que é única para toda a aplicação.
        {
            if(Singleton.Instance == null)
            {
                Singleton.Instance = new Singleton() { };
            }

            return Singleton.Instance;
        }

        public void SetNome(string nome)
        {
            GetInstance().Nome = nome;
        }

        public string GetNome()
        {
            return GetInstance().Nome;
        }
    }
}
