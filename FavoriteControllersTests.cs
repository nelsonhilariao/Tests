using System;
using System.Collections.Generic;
using Xunit;
using gitkria.Controllers;
using gitkria.Models;
using Microsoft.AspNetCore.Mvc;

namespace Tests
{
    public class FavoriteControllersTest
    {
        [Fact]
        public void TestGetFavorites()
        {
            var controller = new FavoriteControllers();

            var result = controller.GetFiles();

            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void TestCreateFavorites()
        {
            var controller = new FavoriteControllers();
            var favorite = new Favorites
            {
                Id = 1,
                Id_User_Git = 123456,
                Id_Repo_Git = 654321,
                login = "test",
                name = "Test User",
                favorite = true,
                avatar_url = "https://avatars0.githubusercontent.com/u/123456?v=4",
                description = "This is a test description",
                html_url = "https://github.com/nelsonhilariao/gitkria",
                updated_at = DateTime.Now
            };

            var result = controller.CreateFavorite(favorite);

            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void TestDeleteFavorites()
        {
            var controller = new FavoriteControllers();
            var login = "test";

            var result = controller.DeleteFile(login);

            Assert.IsType<OkResult>(result);
        }
    }
}