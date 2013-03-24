using mvc4.Models.EntitiesView;

namespace mvc4.Models.Entities
{
	public partial class EnfermedadesDiagnostico{
		public DescripcionComentViewModel ToObject(){
			return new DescripcionComentViewModel{
			    Comentarios = Comentarios,
			    Descripcion = Enfermedades.Descripcion,
				Fecha = Fecha
			};
		}
	}
}