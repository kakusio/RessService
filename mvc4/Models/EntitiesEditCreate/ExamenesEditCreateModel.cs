using System;

namespace mvc4.Models.EntitiesEditCreate
{
	public class ExamenesEditCreateModel
	{
		public Guid idAnalisis { get; set; }
		public string IdPersona { get; set; }
		public DateTime Fecha { get; set; }
		public float ValorMedido { get; set; }
	}
}