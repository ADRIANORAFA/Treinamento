namespace APIDatabaseProduto.Models
{
    public class Produto // Table
    {
        //Colums
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Marca { get; set; }

        public string Quantidade { get; set; }

        public List<Caracteristica> Caracteristica { get; set; }

    }
}
