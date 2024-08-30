using LiteDB;

namespace Modelos;

public class Setores : Registro
{
  [BsonId]
  public int Id { get; set; }
  public string Produto {get; set ;}
  public string Quantidade { get; set; }
  public string NumeroOP { get; set; }

 
}