namespace Heranca
{
    internal class Animal : IAnimal
    {
        public string NomeAnimal{ get; set; }

        public string TipoAnimal { get; set; }

        public string ConsultarAnimal(string nomeAnimal, string tipoAnimal)
        {
            if (tipoAnimal == "ave") return "sou uma ave.";
            if (tipoAnimal == "peixe") return "sou um peixe.";
            return "Não sei o que sou :(";
        }

    }
}
