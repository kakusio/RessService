using System.Collections.Generic;

namespace mvc4.Models.EntitiesView
{
	public class DiagnosticoViewModel{
		public List<AlergiaViewModel> AlergiasDiagnostico { get; set; }
		public List<DescripcionComentViewModel> EnfermedadesDiagnostico { get; set; }
	}
}