using System;
using System.Collections.Generic;

namespace mvc4.Models.EntitiesView
{
	public class HistorialMedicoViewModel{
		public PersonasViewModel DatosPersonales { get; set; }
		
		public List<SocioEconomicoViewModel> Socioeconomicos { get; set; }
		public List<ToxicoViewModel> Toxicos { get; set; }
		public List<AlergiaViewModel> Alergias { get; set; }
		public List<DescripcionComentViewModel> Procedimientos { get; set; }
		public List<DescripcionComentViewModel> Enfermedades { get; set; }
		public List<EnfermedadHereditariaViewModel> EnfermedadesHereditarias { get; set; }
		public List<TransfusionalesViewModel> Transfusionales{ get; set; }
		public List<TraumaticosViewModel> Traumaticos{ get; set; }
	}
}