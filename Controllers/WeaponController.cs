using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetPatrickUdemy.Dtos.Character;
using DotnetPatrickUdemy.Dtos.Weapon;
using DotnetPatrickUdemy.Services.WeaponService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DotnetPatrickUdemy.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class WeaponController : ControllerBase
    {
        private readonly IWeaponService _weaponService;
        public WeaponController(IWeaponService weaponService)
        {
            _weaponService = weaponService;
            
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<GetCharacterResponseDto>>> AddWeapon(AddWeaponDto newWeapon)
        {
            return Ok(await _weaponService.AddWeapon(newWeapon));
        }
        
    }
}