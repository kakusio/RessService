namespace mvc4.Models.Entities
{
	public partial class Administradores
	{
		public Administradores GetDefaultAdministrador(int IdInstitucion, int user_number)
		{
			return new Administradores{
			    idInstitucion = IdInstitucion,
			    Username = "Fake User Name" + user_number,
			    Password = "FakePassword" + user_number,
				Email = "email@mymail.com" + user_number,
				Tipo = "tipo"
			};
		}
	}
}