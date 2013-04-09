using System;

namespace mvc4.Models.EntitiesView
{
	public class AnalisisConsultaViewModel{
		public long idMedico { get; set; }
		public Guid idAnalisis { get; set; }
		public Guid idAnalisisConsulta { get; set; }
		public string AnalisisDescripcion { get; set; }
		public DateTime Fecha{ get; set; }
	}
}