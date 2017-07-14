using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using WorkingWithVisualStudio.Controllers;
using WorkingWithVisualStudio.Models;
using Moq;

namespace WorkingWithVisualStudio.Tests
{
    [TestFixture]
    public class HomeControllerTests
    {
        [Test]
        public void IndexActionModelIsComplete()
        {
            // Arrange
            var mock= new Mock<IRepository>();

            mock.SetupGet(m => m.Products).Returns
                (new List<Product>()
            {
                new Product(){Name="a",Price = 10M},
                new Product(){Name="b",Price = 40M},
                new Product(){Name="c",Price = 20M}
            });
            var controller = new HomeController {Repository = mock.Object};
            // Act
            var model = (controller.Index() as ViewResult)?.ViewData.Model
                as IEnumerable<Product>;
            // Assert

            Assert.That(controller.Repository.Products,Is.EquivalentTo(model));
           
        }
    }
}
