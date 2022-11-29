using System.Collections.ObjectModel;

namespace CatalogoMagic.Models;

public class Categoria
{
    public Categoria()
    {
        Cartas = new Collection<Carta>();
    }
    public int CategoriaID { get; set; }
    public string? Nome { get; set; }
    public string? ImagemUrl { get; set; }

    public ICollection<Carta>? Cartas { get; set; }   
}
