using System;

namespace mvc4.Models.EntitiesView
{
	public class AlergiaViewModel{
		public DateTime Fecha { get; set; }
		public string ElemmentoAlergico { get; set; }
		public string TipoDeAlergia { get; set; }
		public string Comentarios { get; set; }
	}
}