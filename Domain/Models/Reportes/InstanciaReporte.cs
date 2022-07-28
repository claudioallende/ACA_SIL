using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Domain.Models.ListasContactos;

namespace Domain.Models.Reportes
{
	/// <summary>
	/// Representa al reporte a ejecutar con ciertos par�metros espec�ficos
	/// </summary>
	public class InstanciaReporte {
		public Guid Id { get; set; }
		public virtual IList<Parametro> Parametros { get; set; }
		public virtual Reporte Reporte { get; set; }

		public InstanciaReporte() {

		}

		~InstanciaReporte() {

		}

		/// 
		/// <param name="params"></param>
		public IList<Dictionary<string, IList<IDestinatario>>> getDestinatarios(IList<string> parameters){
			return null;
		}

	}//end InstanciaReporte
}