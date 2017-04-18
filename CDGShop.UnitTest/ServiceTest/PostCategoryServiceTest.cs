using CDGShop.Data.Infrastructure;
using CDGShop.Data.Repositories;
using CDGShop.Model.Models;
using CDGShop.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace CDGShop.UnitTest.ServiceTest
{
    [TestClass]
    public class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRepository> _mockRepository;
        private Mock<IUnitOfWork> _mockUnitOfWorf;
        private IPostCategoryService _categoryService;
        private List<PostCategory> _listCategory;

        [TestInitialize]
        public void Initialize()
        {
            _mockRepository = new Mock<IPostCategoryRepository>();
            _mockUnitOfWorf = new Mock<IUnitOfWork>();
            _categoryService = new PostCategoryService(_mockRepository.Object, _mockUnitOfWorf.Object);
            _listCategory = new List<PostCategory>
            {
                new PostCategory() {ID = 1, Name = "DM1", Status = true },
                new PostCategory() {ID = 2, Name = "DM2", Status = true },
                new PostCategory() {ID = 3, Name = "DM3", Status = true },
            };
        }

        [TestMethod]
        public void PostCategory_Service_GetAll()
        {
            //setup method
        }

        [TestMethod]
        public void PostCategory_Service_Create()
        {
        }
    }
}