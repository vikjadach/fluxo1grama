using LiteDB;

namespace LiteDBExample.Modelos;

public class Materiaprima : Registro
{
  [BsonId]
  public int Id { get; set; }
  public string Unidade {get; set ;}
  public string valor { get; set; }
 