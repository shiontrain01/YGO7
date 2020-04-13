using YGO7.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace YGO7.Domain.Bases
{
	public abstract class Entity : IEntity
    {
		[Key]
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; }

		public virtual string Key { get { return this.Id; } }

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
