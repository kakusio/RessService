using System;

namespace mvc4.Models.EntitiesView
{
	public class ResultadoAnalisisConsultaViewModel{
		public string urlPath { get; set; }
		public int idInstitucion { get; set; }
		public DateTime FechaRealizado { get; set; }
		public Guid idAnalisisConsulta { get; set; }
	}
}