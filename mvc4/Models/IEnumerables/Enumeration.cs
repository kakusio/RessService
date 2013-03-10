using System;

namespace mvc4.Models.IEnumerables
{
	public class Enumeration : IEquatable<Enumeration>
	{
		protected string value;

		public virtual string Value
		{
			get { return value; }
			set { this.value = value; }
		}

		public bool Equals(Enumeration other)
		{
			if (ReferenceEquals(null, other))
				return false;
			return ReferenceEquals(this, other) || Equals(other.Value.ToUpper(), Value.ToUpper());
		}

	}
}