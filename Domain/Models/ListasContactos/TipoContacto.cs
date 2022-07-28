using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Domain.Models.Compartidos.Entity;

namespace Domain.Models.ListasContactos
{
	public class TipoContacto: EntityGuid
	{
		public string Nombre { get; set; }
		public string Descripcion { get; set; }

		public TipoContacto()
		{

		}

    public override bool Equals(object? obj)
    {
			if (obj == null) return false;
			TipoContacto? other = obj as TipoContacto;
			return this.Id == other.Id;
    }

  }//end TipoContacto
}