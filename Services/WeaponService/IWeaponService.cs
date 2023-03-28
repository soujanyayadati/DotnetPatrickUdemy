using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetPatrickUdemy.Dtos.Character;
using DotnetPatrickUdemy.Dtos.Weapon;

namespace DotnetPatrickUdemy.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterResponseDto>> AddWeapon(AddWeaponDto newweapon);
    }
}