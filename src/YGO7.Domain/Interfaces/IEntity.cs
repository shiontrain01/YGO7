using System;

namespace YGO7.Domain.Interfaces
{
	public interface IEntity
	{
		string Id { get; }
		string Key { get; }
		string Value { get; }
		int ParentKey { get; }
	}
}
