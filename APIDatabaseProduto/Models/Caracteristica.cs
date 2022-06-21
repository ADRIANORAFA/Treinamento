namespace APIDatabaseProduto.Models
{
    public class Caracteristica // Table
    {
        //Colums
        public Guid Id { get; set; } 

        public string Material { get; set; }

        //navegation property
        public Guid PersonID { get; set; }

        public Produto Produto { get; set; }



    }
}
