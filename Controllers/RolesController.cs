using BanThietBiDiDong.API.Applications.Roles.Dtos;
using BanThietBiDiDong.API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BanThietBiDiDong.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        RoleManager<IdentityRole<Guid>> _roleManager;
        private readonly BanThietBiDiDongDBContext _context;
        public RolesController(RoleManager<IdentityRole<Guid>> roleManager)
        {
            _roleManager = roleManager;
        }

        [HttpGet()]
        public async Task<IActionResult> GetAll(string id)
        {

            var listRole = await _roleManager.Roles.Select(x => new RoleViewModel()
            {
                Id = x.Id.ToString(),
                RoleName = x.Name
            }).ToListAsync();

            return Ok(listRole);
        }

        [HttpPost]
        public async Task<IActionResult> PostRole(RoleViewModel request)
        {
            var role = new IdentityRole<Guid>()
            {
                Id = Guid.NewGuid(),
                Name = request.RoleName,
                NormalizedName = request.RoleName.ToUpper(),
            };
            var result = await _roleManager.CreateAsync(role);
            if (result.Succeeded)
            {

                return CreatedAtAction(nameof(GetById), new { id = role.Id }, request);
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {

            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }
            var roleVM = new IdentityRole<Guid>()
            {
                Id = role.Id,
                Name = role.Name
            };
            return Ok(roleVM);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRole(string id, [FromBody] RoleViewModel roleViewModel)
        {
            if (id != roleViewModel.Id)
                return BadRequest();
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }
            role.Name = roleViewModel.RoleName;
            role.NormalizedName = roleViewModel.RoleName.ToUpper();
            var result = await _roleManager.UpdateAsync(role);
            if (result.Succeeded)
            {
                return NoContent();
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRole(string id)
        {

            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }

            var result = await _roleManager.DeleteAsync(role);
            if (result.Succeeded)
            {
                var roleVm = new RoleViewModel()
                {
                    Id = role.Id.ToString(),
                    RoleName = role.Name,
                };
                return Ok(roleVm);
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }
    }
}
