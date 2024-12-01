using AutoMapper;
using BLL.IServices;
using Core.Dtos;
using Core.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Controllers;

namespace GestionBangalow.Tests.WebApi.Tests
{
    public class DonneesDeReferencesControllerTest
    {

        public DonneesDeReferencesControllerTest()   {  }




        [Fact]
        public void GetAllRoles_shouldReturnNotEmptyList()
        {
            var moqRoleService = new Mock<IRoleService>();
            var moqCommoditeService = new Mock<ICommoditeService>();
            var moqMapper = new Mock<IMapper>();

            moqRoleService.Setup(x => x.GetAll()).Returns(GetListOfRoles());
            moqMapper.Setup(x => x.Map<List<RoleReadDto>>(GetListOfRoles())).Returns(GetListOfRolesReadDto());

            var controller = new DonneesDeReferencesController(moqRoleService.Object, moqCommoditeService.Object, moqMapper.Object);

            var expectedNumberOfRoles = 4;
            var actual = controller.GetAllRoles();

            Assert.NotNull(actual);
            Assert.NotEmpty(actual);
            Assert.Equal(expectedNumberOfRoles, actual.Count());           

        }


        #region usefull private methode for mocking data

        private List<RoleReadDto> GetListOfRolesReadDto()
        {
            return new List<RoleReadDto> {
                new RoleReadDto {Id = 1, Libelle = "Admin" } ,
                new RoleReadDto {Id = 2, Libelle = "Client" },
                new RoleReadDto { Id = 3, Libelle = "Commercial"},
                new RoleReadDto {Id = 4, Libelle = "Proprietaire" }
            };
        }

        private List<Role> GetListOfRoles()
        {
            return new List<Role> {
                new Role {Id = 1, Libelle = "Admin" } ,
                new Role {Id = 2, Libelle = "Client" },
                new Role { Id = 3, Libelle = "Commercial"},
                new Role {Id = 4, Libelle = "Proprietaire" }
            };
        }

        #endregion
    }
}
