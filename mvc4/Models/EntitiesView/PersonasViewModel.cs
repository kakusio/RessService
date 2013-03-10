using System;

namespace mvc4.Models.EntitiesView
{
	public class PersonasViewModel
	{
		public Guid idPersona { get; set; }
		public string Nombres { get; set; }
		public string Apellidos { get; set; }
		public string Sexo { get; set; }
		public string Cedula { get; set; }
		public DateTime FechaDeNacimiento { get; set; }
		public string Email { get; set; }
		public string TelefonoResidencial { get; set; }
		public string TelefonoCelular { get; set; }
		public int idProvincia { get; set; }
		public string Direccion { get; set; }
		public string TipoDeSangre { get; set; }
		public DateTime FechaDeDefuncion { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
	}
}