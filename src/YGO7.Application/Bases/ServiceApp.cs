using YGO7.Application.Extensions;
using YGO7.Application.Interfaces;
using YGO7.Domain.Bases;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YGO7.Application.Bases
{
	public class AppService : IAppService
	{
		private readonly IMapper mapper;

		public IMapper Mapper 
		{ 
			get
			{
				return mapper;
			}
		}
		
		public AppService(IMapper mapper)
		{
			this.mapper = mapper;
		}
	}
}
