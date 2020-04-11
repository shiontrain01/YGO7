using AirplaneProject.Core.Interfaces;
using System.Collections.Generic;

namespace AirplaneProject.Application.Interfaces
{
	public interface IResultDto : IResult		
	{
        string Campo { get; set; }
        IList<string> Mensagens { get; set; }
	}
}
