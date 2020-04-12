using System;

namespace YGO7.Domain.Interfaces
{
	public interface IEntity
	{
		int Id { get; }
		int Key { get; }
		string Value { get; }
		int ParentKey { get; }
	}
}
