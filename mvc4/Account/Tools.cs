using System;
using System.Text.RegularExpressions;

namespace mvc4.Account
{
	public class Tools
	{
		public static bool IsGuid(string candidate){
			var isGuid = new Regex(@"^(\{){0,1}[0-9a-fA-F]{8}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{12}(\}){0,1}$", RegexOptions.Compiled);
			return candidate != null && isGuid.IsMatch(candidate);
		}

		

		public static int CalculateAgeCorrect(DateTime birthDate){
			var now = DateTime.Now;
			var age = now.Year - birthDate.Year;
			if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day)) age--;
			return age;
		}

		public static string getFamiliaRelacion(string relacion, string sexo)
		{
			var Resultado = "Pariente lejano";
			switch (relacion+sexo ){
				case "Padre"+"M":
					Resultado = "Hijo";
					break;
				case "Padre"+"F":
					Resultado = "Hija";
					break;
				case "Madre"+"M":
					Resultado = "Hijo";
					break;
				case "Madre"+"F":
					Resultado = "Hija";
					break;
				case "Hijo"+"M":
					Resultado = "Padre";
					break;
				case "Hijo"+"F":
					Resultado = "Madre";
					break;
				case "Hija"+"M":
					Resultado = "Padre";
					break;
				case "Hija"+"F":
					Resultado = "Madre";
					break;
				case "Abuelo"+"M":
					Resultado = "Nieto";
					break;
				case "Abuelo"+"F":
					Resultado = "Nieta";
					break;
				case "Abuela"+"M":
					Resultado = "Nieto";
					break;
				case "Abuela"+"F":
					Resultado = "Nieta";
					break;
				case "Nieto"+"M":
					Resultado = "Abuelo";
					break;
				case "Nieto"+"F":
					Resultado = "Abuela";
					break;
				case "Nieta"+"M":
					Resultado = "Abuelo";
					break;
				case "Nieta"+"F":
					Resultado = "Abuela";
					break;
				case "Primo"+"M":
					Resultado = "Primo";
					break;
				case "Primo"+"F":
					Resultado = "Prima";
					break;
				case "Prima"+"M":
					Resultado = "Primo";
					break;
				case "Prima"+"F":
					Resultado = "Prima";
					break;
				case "Tio"+"M":
					Resultado = "Sobrino";
					break;
				case "Tio"+"F":
					Resultado = "Sobrina";
					break;
				case "Tia"+"M":
					Resultado = "Sobrino";
					break;
				case "Tia"+"F":
					Resultado = "Sobrina";
					break;
				case "Hermano"+"M":
					Resultado = "Hermano";
					break;
				case "Hermano"+"F":
					Resultado = "Hermana";
					break;
				case "Hermana"+"M":
					Resultado = "Hermano";
					break;
				case "Hermana"+"F":
					Resultado = "Hermana";
					break;

			}
			return Resultado;
		}
	}
}