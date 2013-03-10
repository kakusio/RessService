namespace mvc4.Models.IEnumerables
{
	public class TipoSangre : Enumeration
	{
		public static TipoSangre APositivo = new TipoSangre {Value = "A+"};
		public static TipoSangre BPositivo = new TipoSangre {Value = "B+"};
		public static TipoSangre OPositivo = new TipoSangre {Value = "O+"};
		public static TipoSangre ABPositivo = new TipoSangre {Value = "AB+"};
		public static TipoSangre ANegativo = new TipoSangre {Value = "A-"};
		public static TipoSangre BNegativo = new TipoSangre {Value = "B-"};
		public static TipoSangre ONegativo = new TipoSangre {Value = "O-"};
		public static TipoSangre ABNegativo = new TipoSangre {Value = "AB-"};
	}
}