
using Modelos;

namespace Controles;

public class MateriaprimaControle : BaseControle
{
  //----------------------------------------------------------------------------

  public MateriaprimaControle() : base()
  {
    NomeDaTabela = "Materiaprima";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idMateriaprima)
  {
    var collection = liteDB.GetCollection<Materiaprima>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idMateriaprima);
  }

  //----------------------------------------------------------------------------

  public virtual List<Materiaprima>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Materiaprima>(NomeDaTabela);
    return new List<Materiaprima>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idMateriaprima)
  {
    var collection = liteDB.GetCollection<Materiaprima>(NomeDaTabela);
    collection.Delete(idMateriaprima);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Materiaprima materiaprima )
  {
    var collection = liteDB.GetCollection<MAteriaprima>(NomeDaTabela);
    collection.Upsert(materiaprima);
  }

  //----------------------------------------------------------------------------
}