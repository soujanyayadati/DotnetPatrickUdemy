using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetPatrickUdemy.Dtos.Fight;

namespace DotnetPatrickUdemy.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
        Task<ServiceResponse<AttackResultDto>> SkillAttack(SkillAttackDto request);
        Task<ServiceResponse<FightResultDto>> Fight(FightRequestDto request);
        Task<ServiceResponse<List<HighscoreDto>>> GetHighscore();

    }
}