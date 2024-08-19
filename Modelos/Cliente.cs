using LiteDB;

namespace Modelos;

public class Cliente : Registro
{
  [BsonId]
  public int Id { get; set; }
  public string Nome {get; set ;}
  public string CPF { get; set; }
  public string RG { get; set; }
  public string Telefone { get; set; }
 public string Endereço { get; set; }
  public string Cidade e Estado { get; set; }
}