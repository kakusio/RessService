using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using mvc4.Models.EntitiesView;

namespace mvc4.Models.Entities{
	public partial class Consultas {
		public IEnumerable<AnalisisConsultaViewModel> AnalisisPendientes(){
			var resultado = new List<AnalisisConsultaViewModel>();
			AnalisisConsulta.Select(x => x.AnalisisPendientes()).ToList().Each(model =>	{
			        if (model != null) resultado.Add(model);
			    });
			return resultado;
		}
	}
}