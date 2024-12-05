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
using WebApi.Profiles;

namespace GestionBangalow.Tests.WebApi.Tests
{
    public class DonneesDeReferencesControllerTest
    {
        private readonly Mock<IRoleService> _moqRoleService;
        private readonly Mock<ICommoditeService> _moqCommoditeService;
        public DonneesDeReferencesControllerTest()
        {

            _moqRoleService = new Mock<IRoleService>();
            _moqCommoditeService = new Mock<ICommoditeService>();
        }


        #region test methodes

        [Fact]
        public void GetAllRoles_shouldReturnNotNullOrEmptyList()
        {

            //Arrange
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new RoleProfile());
            });

            var mapper = mapperConfig.CreateMapper();

            _moqRoleService.Setup(x => x.GetAll()).Returns(getListOfRoles());

            var controller = new DonneesDeReferencesController(_moqRoleService.Object, _moqCommoditeService.Object, mapper);

            // Act
            var actualResult = controller.GetAllRoles();
            var expectedResult = getListOfRolesReadDto();

            // Assert
            Assert.True(actualResult.Any());
            Assert.Equal(expectedResult.Count(), actualResult.Count());

        }

        [Fact]
        void GetAllCommodite_shouldReturnNullOrEmptyList()
        {
            // Arrange
            var moqConfig = new MapperConfiguration(cfg => { cfg.AddProfile(new CommoditeProfile()); });
            var mapper = moqConfig.CreateMapper();

            _moqCommoditeService.Setup(x => x.GetAll()).Returns(getListOfCommodite());

            var controller = new DonneesDeReferencesController(_moqRoleService.Object, _moqCommoditeService.Object, mapper);
            
            // Act
            var actualResult = controller.GetAllCommodites();
            var expectedResult = getListOfCommoditeReadDto();
            
            // Assert
            Assert.NotNull(actualResult);
            Assert.NotEmpty(actualResult);
            Assert.Equal(actualResult.Count(), actualResult.Count());

        }

        #endregion

        #region Usefull private methode for mocking data

        private List<RoleReadDto> getListOfRolesReadDto()
        {
            return new List<RoleReadDto> {
                new RoleReadDto {Id = 1, Libelle = "Admin" } ,
                new RoleReadDto {Id = 2, Libelle = "Client" },
                new RoleReadDto { Id = 3, Libelle = "Commercial"},
                new RoleReadDto {Id = 4, Libelle = "Proprietaire" }
            };
        }

        private List<Role> getListOfRoles()
        {
            return new List<Role> {
                new Role {Id = 1, Libelle = "Admin" } ,
                new Role {Id = 2, Libelle = "Client" },
                new Role { Id = 3, Libelle = "Commercial"},
                new Role {Id = 4, Libelle = "Proprietaire" }
            };
        }


        private List<Comodite> getListOfCommodite()
        {
            return new List<Comodite> {
                new Comodite { Id = 1, Libelle = "Jardin" },
                new Comodite { Id = 2, Libelle = "Place parcking" },
                new Comodite { Id = 3, Libelle = "Vue en Mer" }
            };
        }

        private List<CommoditeReadDto> getListOfCommoditeReadDto()
        {
            return new List<CommoditeReadDto> {
                new CommoditeReadDto { Id = 1, Libelle = "Jardin" },
                new CommoditeReadDto { Id = 2, Libelle = "Place parcking" },
                new CommoditeReadDto { Id = 3, Libelle = "Vue en Mer" }
            };
        }

        #endregion
    }
}
