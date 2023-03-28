using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetPatrickUdemy.Dtos.Character;
using DotnetPatrickUdemy.Models;

namespace DotnetPatrickUdemy.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterResponseDto>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterResponseDto>> GetCharacterById(int id);
        Task<ServiceResponse<List<GetCharacterResponseDto>>> AddCharacter(AddCharacterRequestDto newCharacter);
        Task<ServiceResponse<GetCharacterResponseDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);
        Task<ServiceResponse<List<GetCharacterResponseDto>>> DeleteCharacter(int id);
        Task<ServiceResponse<GetCharacterResponseDto>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill);

    }
}