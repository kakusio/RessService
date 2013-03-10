namespace mvc4.Models.EntitiesView
{
	public class MedicosViewModel : PersonasViewModel
	{
		public MedicosViewModel(PersonasViewModel personas, bool isMedico = true)
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
			IsMedico = isMedico;
		}

		public bool IsMedico { get; set; }
	}
}