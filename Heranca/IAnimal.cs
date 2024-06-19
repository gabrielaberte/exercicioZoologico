namespace Heranca
{
    internal interface IAnimal
    {
       public string NomeAnimal { get; }
        public string TipoAnimal { get; }

        public string ConsultarAnimal(string nomeAnimal, string tipoAnimal);
    }
}
