using AirplaneProject.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace AirplaneProject.Domain.Bases
{
	public abstract class Entity : IEntity
    {
		[Key]
		public int Id { get; set; }

		public virtual int Key { get { return this.Id; } }

		public virtual int ParentKey { get { return 0; } }

		public virtual string Value { get { return this.ToString(); } }

		public override bool Equals(object obj)
		{
			var compareTo = obj as Entity;

			if (ReferenceEquals(this, compareTo)) return true;
			if (ReferenceEquals(null, compareTo)) return false;

			return Id.Equals(compareTo.Id);
		}

		public static bool operator ==(Entity a, Entity b)
		{
			if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
				return true;

			if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
				return false;

			return a.Equals(b);
		}

		public static bool operator !=(Entity a, Entity b)
		{
			return !(a == b);
		}

		public override int GetHashCode()
		{
			return (GetType().GetHashCode() * 907) + Id.GetHashCode();
		}

		public override string ToString()
		{
			return GetType().Name + " [Id=" + Id + "]";
		}
	}
}
