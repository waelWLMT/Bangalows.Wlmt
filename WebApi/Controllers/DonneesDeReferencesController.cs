using AutoMapper;
using BLL.IServices;
using BLL.Services;
using Core.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    /// <summary>
    /// The donnees de references controller.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DonneesDeReferencesController : ControllerBase
    {
        /// <summary>
        /// The role service.
        /// </summary>
        private readonly IRoleService _roleService;
        /// <summary>
        /// The commodite service.
        /// </summary>
        private readonly ICommoditeService _commoditeService;

        /// <summary>
        /// The mapper.
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="DonneesDeReferencesController"/> class.
        /// </summary>
        /// <param name="roleService">The role service.</param>
        /// <param name="mapper">The mapper.</param>
        public DonneesDeReferencesController(IRoleService roleService, ICommoditeService commoditeService, IMapper mapper)
        {
            _roleService = roleService;
            _commoditeService = commoditeService;
            _mapper = mapper;
        }

        /// <summary>
        /// Get all roles.
        /// </summary>
        /// <returns><![CDATA[List<RoleReadDto>]]></returns>
        [HttpGet("GetAllRoles")]
        public List<RoleReadDto> GetAllRoles()
        {
            var roles = _roleService.GetAll();
            var result = _mapper.Map<List<RoleReadDto>>(roles);

            return result;
        }

        /// <summary>
        /// Get all commodite.
        /// </summary>
        /// <returns><![CDATA[List<CommoditeReadDto>]]></returns>
        [HttpGet("GetAllCommodites")]
        public List<CommoditeReadDto> GetAllCommodites()
        {
            var commodites = _commoditeService.GetAll();
            var result = _mapper.Map<List<CommoditeReadDto>>(commodites);

            return result;
        }
    
    
    }
}
