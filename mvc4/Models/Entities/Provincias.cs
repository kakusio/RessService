namespace mvc4.Models.Entities
{
	public partial class Provincias
	{
		public Provincias GetDefaultProvincia(int user_number, int IdPais, int IdProvincia)
		{
			return new Provincias
			       	{
			       		Nombre = "Fake Nombre" + user_number,
			       		idPais = IdPais,
			       		idProvincia = IdProvincia
			       	};
		}
	}
}