namespace mvc4.Models.IEnumerables
{
	public class Notificaciones : Enumeration
	{
		public static Notificaciones ErrorUsuarioContrasena = new Notificaciones {Value = "Usuario o contraseña no válida."};
		public static Notificaciones ErrorUsuario= new Notificaciones {Value = "Usuario no válido."};
		public static Notificaciones EdicionCorrecta = new Notificaciones {Value = "Se ha editado correctamente."};
		public static Notificaciones EliminacionCorrecta = new Notificaciones {Value = "Se ha eliminado correctamente."};
		public static Notificaciones CreacionCorrecta = new Notificaciones {Value = "Se ha creado correctamente."};
		public static Notificaciones AgregacionCorrecta = new Notificaciones {Value = "Se ha agregado correctamente."};
		public static Notificaciones RemovidoCorrecta = new Notificaciones {Value = "Se ha removido correctamente."};
	}
}