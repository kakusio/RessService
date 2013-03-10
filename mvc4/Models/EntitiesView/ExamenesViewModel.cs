using System;

namespace mvc4.Models.EntitiesView
{
	public class ExamenesViewModel
	{
		public int IdAnalisis { get; set; }
		public string IdPersona { get; set; }
		public DateTime Fecha { get; set; }
		public float ValorMedido { get; set; }
	}
}