using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Domain.Models.Externo;
using Domain.Models.Compartidos.Entity;

namespace Domain.Models.Personas
{
	public class Cuenta : EntityGuid
	{
		public string NroCuenta { get; set; }
		public string Cuit { get; set; }
		public string Nombre { get; set; }

		public virtual Cupo? Cupo { get; set; }

		public Cuenta()
		{

		}

		~Cuenta()
		{

		}

		public override bool Equals(object? obj)
		{
			if (obj == null) return false;
			Cuenta? other = obj as Cuenta;
			return this.Id == other.Id;
		}

	}//end Cuenta
}