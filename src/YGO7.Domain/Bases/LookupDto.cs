using YGO7.Domain.Interfaces;

namespace YGO7.Domain.Bases
{
	public class LookupDto : ILookupDto
	{
		public int Key { get; set; }
		public int ParentKey { get; set; }
		public string Value { get; set; }
	}
}
