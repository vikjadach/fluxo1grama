
using Modelos;

namespace Controles;

public class SetoresControle : BaseControle
{
  //----------------------------------------------------------------------------

  public SetoresControle() : base()
  {
    NomeDaTabela = "Setores";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idSetores)
  {
    var collection = liteDB.GetCollection<Setores>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idSetores);
  }

  //----------------------------------------------------------------------------

  public virtual List<Setores>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Setores>(NomeDaTabela);
    return new List<Setores>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idSetores)
  {
    var collection = liteDB.GetCollection<Setores>(NomeDaTabela);
    collection.Delete(idSetores);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Setores setores)
  {
    var collection = liteDB.GetCollection<Setores>(NomeDaTabela);
    collection.Upsert(setores);
  }

  //----------------------------------------------------------------------------
}