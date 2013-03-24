using AutoMapper;
using mvc4.Models.EntitiesView;

namespace mvc4.Models.Entities
{
	public partial class DetallesProcedimientos {
		public DescripcionComentViewModel ToObject()
		{
			return new DescripcionComentViewModel{
			       		Comentarios = Detalles,
			       		Descripcion = Procedimientos.Descripcion,
						Fecha = FechaProcedimiento
			       	};
		}
	}
}