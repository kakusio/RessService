namespace mvc4.Models.Entities
{
	public partial class Paises
	{
		public Paises GetDefaultPais(int user_number)
		{
			return new Paises
			       	{
			       		Nombre = "Fake Nombre" + user_number
			       	};
		}
	}
}