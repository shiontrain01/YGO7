namespace YGO7.Domain.Interfaces
{
	public interface ILookupDto
	{
		int Key { get; set; }
		int ParentKey { get; set; }
		string Value { get; set; }
	}
}
