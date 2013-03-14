using System.Text.RegularExpressions;

namespace mvc4.Account
{
	public class ValidateGuid
	{
		public static bool IsGuid(string candidate){
			var isGuid = new Regex(@"^(\{){0,1}[0-9a-fA-F]{8}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{12}(\}){0,1}$", RegexOptions.Compiled);
			return candidate != null && isGuid.IsMatch(candidate);
		}
	}
}