using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetPatrickUdemy.Dtos;
using DotnetPatrickUdemy.Dtos.Fight;
using DotnetPatrickUdemy.Dtos.Character;
using DotnetPatrickUdemy.Dtos.Skill;
using DotnetPatrickUdemy.Dtos.Weapon;

namespace DotnetPatrickUdemy
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterResponseDto>();
            CreateMap<AddCharacterRequestDto, Character>();
            CreateMap<UpdateCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
            CreateMap<Character, HighscoreDto>();


        }
    }
}