using mvc4.Models.EntitiesView;
using System.Linq;

namespace mvc4.Models.Entities
{
	public partial class Diagnostico{
		public DiagnosticoViewModel ToObject(){
			return new DiagnosticoViewModel{
			    AlergiasDiagnostico = AlergiasDiagnostico.Select( x => x.ToObject()).ToList(),
				EnfermedadesDiagnostico = EnfermedadesDiagnostico.Select( x => x.ToObject()).ToList()
			};
		}
	}
}