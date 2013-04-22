using AutoMapper;
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

	public partial class AntecedentesTrasfusionales{
		public TransfusionalesViewModel ToObject(){
			Mapper.CreateMap<AntecedentesTrasfusionales, TransfusionalesViewModel>();
			return Mapper.Map<AntecedentesTrasfusionales, TransfusionalesViewModel>(this);
		}
	}

	public partial class AntecedentesTraumaticos{
		public TraumaticosViewModel ToObject(){
			Mapper.CreateMap<AntecedentesTraumaticos, TraumaticosViewModel>();
			return Mapper.Map<AntecedentesTraumaticos, TraumaticosViewModel>(this);
		}
	}
}