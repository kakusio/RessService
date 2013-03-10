namespace mvc4.Models.Entities
{
	public partial class Especialidades {
		public Especialidades GetDefaultEspecialidad(int user_number)
		{
			return new Especialidades{
			    Descripcion= "Fake descripcion" + user_number
			    };
		}
	}
}