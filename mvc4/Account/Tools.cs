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
	}
}