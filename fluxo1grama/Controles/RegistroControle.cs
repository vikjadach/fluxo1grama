
using Modelos;

namespace Controles;

public class RegistroControle : BaseControle
{
  //----------------------------------------------------------------------------

  public Registrocontrole() : base()
  {
    NomeDaTabela = "Registro";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idRegistro)
  {
    var collection = liteDB.GetCollection<Registro>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idRegistro);
  }

  //----------------------------------------------------------------------------

  public virtual List<Registro>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Registro>(NomeDaTabela);
    return new List<Registro>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idRegistro)
  {
    var collection = liteDB.GetCollection<Registro>(NomeDaTabela);
    collection.Delete(idRegistro);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Registro registro)
  {
    var collection = liteDB.GetCollection<Registro>(NomeDaTabela);
    collection.Upsert(Registro);
  }

  //----------------------------------------------------------------------------
}