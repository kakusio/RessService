using mvc4.Models.EntitiesView;

namespace mvc4.Models.Entities
{
	public partial class AlergiasDiagnostico {
		public AlergiaViewModel ToObject(){
			return new AlergiaViewModel{
			    Comentarios = Comentarios,
				ElemmentoAlergico = Alergias.ElemmentoAlergico,
				TipoDeAlergia = Alergias.TipoDeAlergia,
				Fecha = Fecha
			};
		}
	}
}