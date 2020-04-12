using YGO7.Core.Interfaces;
using System.Collections.Generic;

namespace YGO7.Application.Interfaces
{
	public interface IResultDto : IResult		
	{
        string Campo { get; set; }
        IList<string> Mensagens { get; set; }
	}
}
