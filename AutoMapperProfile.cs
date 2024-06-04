using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using net_RPG.Models;

namespace net_RPG
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
           
        }
    }
}