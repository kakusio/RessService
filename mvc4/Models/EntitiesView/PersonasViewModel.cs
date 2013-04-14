using System;
using mvc4.Account;

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
		public int Edad {get { return Tools.CalculateAgeCorrect(FechaDeNacimiento); }}

		public string Religion { get; set; }
		public string Ocupacion { get; set; }
		public string EstadoCivil { get; set; }
		public int LugarNacimmiento { get; set; }
		public string NivelEducacion { get; set; }
		public string Raza { get; set; }
		public float Peso { get; set; }
		public float Altura { get; set; }
		public string UrlPath { get; set; }
	}
}