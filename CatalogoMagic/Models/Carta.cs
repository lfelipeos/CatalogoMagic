using Microsoft.VisualBasic;
using System.Collections.ObjectModel;

namespace CatalogoMagic.Models;

public class Carta
{  
    public int CartaId { get; set; }
    public string? NomeCarta { get; set; }
    public string? Cor { get; set; }
    public int Custo { get; set; }
    public string? ImagemUrl { get; set; }
    public DateTime DataCadastro { get; set; }
    public int CategoriaId { get; set; }
    public Categoria? Categoria { get; set; }
}
