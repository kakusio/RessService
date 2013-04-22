using System.Collections.Generic;

namespace mvc4.Models.EntitiesView
{
	public class MedicosViewModel : PersonasViewModel
	{
		public MedicosViewModel(PersonasViewModel personas,List<string>InstitucionesNombre,List<string> EspecialidadesDescripcion, bool isMedico = true)
		{
			idPersona = personas.idPersona;
			Nombres = personas.Nombres;
			Apellidos = personas.Apellidos;
			Sexo = personas.Sexo;
			Cedula = personas.Cedula;
			FechaDeNacimiento = personas.FechaDeNacimiento;
			Email = personas.Email;
			TelefonoResidencial = personas.TelefonoResidencial;
			TelefonoCelular = personas.TelefonoCelular;
			idProvincia = personas.idProvincia;
			Direccion = personas.Direccion;
			TipoDeSangre = personas.TipoDeSangre;
			FechaDeDefuncion = personas.FechaDeDefuncion;
			Username = personas.Username;
			Password = personas.Password;
			this.InstitucionesNombre = InstitucionesNombre;
			this.EspecialidadesDescripcion = EspecialidadesDescripcion;
		}

		public PersonasViewModel Personas { get; set; }
		public bool IsMedico { get { return true; } }
		public List<string>InstitucionesNombre { get; set; }
		public List<string> EspecialidadesDescripcion { get; set; }
	}
}