using LiteDB;

namespace LiteDBExample.Modelos;

public class Pedido : Registro
{
  [BsonId]
  public int Id { get; set; }
  public string Quantidade {get; set ;}
  public string Valor { get; set; }
  public string Tempo estimado { get; set; }


}