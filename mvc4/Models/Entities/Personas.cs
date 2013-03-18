using System;
using System.Linq;
using AutoMapper;
using mvc4.Models.EntitiesEditCreate;
using mvc4.Models.EntitiesView;
using mvc4.Models.IEnumerables;

namespace mvc4.Models.Entities
{
	public partial class Personas
	{

		public Personas()
		{
			idPersona = Guid.NewGuid();
		}

		public Personas GetDefaultPersona(int userNumber, int IdProvincia)
		{
			return new Personas
			       	{
			       		Nombres = "Primero segundo" + userNumber,
			       		Apellidos = "FakePrimerApellido",
			       		Cedula = 0434389214 + userNumber,
			       		FechaDeNacimiento = DateTime.Now.AddYears(-10 - userNumber),
			       		Email = "FakeEmail" + userNumber + "@IFake.com",
			       		TelefonoCelular = 1112223333 + userNumber,
			       		TelefonoResidencial = 3336669999 + userNumber,
			       		idProvincia = IdProvincia,
			       		Direccion = "Calle Rando #" + userNumber,
			       		TipoDeSangre = TipoSangre.APositivo.Value,
			       		Username = "UserName" + userNumber,
			       		Password = "UserPassword" + userNumber
			       	};

		}

		public void Update(PersonasEditModel newPersona)
		{
			Mapper.CreateMap<PersonasEditModel, Personas>();
			Mapper.Map(newPersona, this);
		}

		public PersonasViewModel ToObject()
		{
			Mapper.CreateMap<Personas, PersonasViewModel>();
			return Mapper.Map<Personas, PersonasViewModel>(this);
		}

		public HistorialMedicoViewModel HistorialMedico()
		{
			var diagnosticoViewModels = Diagnostico.Select(x => x.ToObject());
			return new HistorialMedicoViewModel{
			       		idPersona = idPersona,
			       		Nombres = Nombres,
			       		Apellidos = Apellidos,
			       		AntecedentesToxicos = Toxicos.Select(x => x.ToObject()).ToList(),
			       		AntecedentesAlergico = diagnosticoViewModels.SelectMany(x => x.AlergiasDiagnostico).ToList(),
			       		AntecedentesProcedimientos = DetallesProcedimientos.Select(x => x.ToObject()).ToList(),
			       		AntecedentesEnfermedades = diagnosticoViewModels.SelectMany(x => x.EnfermedadesDiagnostico).ToList(),
			       		EnfermedadesHereditarias = Enfermedades.Select(x => x.ToObject()).ToList()
			       	};
		}
	}
}