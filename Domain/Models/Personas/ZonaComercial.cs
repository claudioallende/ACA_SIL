using Domain.Models.Compartidos.Entity;

namespace Domain.Models.Personas
{
  public class ZonaComercial : EntityGuid
  {
    public string Nombre { get; set; }
    public string Descripcion{ get; set; }

    public ZonaComercial()
    {

    }
    public override bool Equals(object? obj)
    {
      if (obj == null) return false;
      ZonaComercial? other = obj as ZonaComercial;
      return this.Id == other.Id;
    }
  }
}
