using System.Security.Claims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetPatrickUdemy.Dtos.Character;
using DotnetPatrickUdemy.Dtos.Weapon;

namespace DotnetPatrickUdemy.Services.WeaponService
{
    public class WeaponService : IWeaponService
    {
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;

        public WeaponService(DataContext context, IHttpContextAccessor httpContextAccessor,
        IMapper mapper)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<GetCharacterResponseDto>> AddWeapon(AddWeaponDto newweapon)
        {
           var response = new ServiceResponse<GetCharacterResponseDto>();
           try
           {
                var character = await _context.Characters
                .FirstOrDefaultAsync(c => c.Id == newweapon.CharacterId &&
                c.User!.Id == int.Parse(_httpContextAccessor.HttpContext!.User
                .FindFirstValue(ClaimTypes.NameIdentifier)!));
                if( character is null)
                {
                    response.Success = false;
                    response.Message = "Character not found.";
                    return response;
                }

                var weapon = new Weapon
                {
                    Name = newweapon.Name,
                    Damage = newweapon.Damage,
                    Character = character
                };

                _context.Weapons.Add(weapon);
                await _context.SaveChangesAsync();
                
                response.Data = _mapper.Map<GetCharacterResponseDto>(character);


           }
           catch(Exception ex)
           {
                response.Success = false;
                response.Message = ex.Message;
           }

           return response;
        }
    }
}