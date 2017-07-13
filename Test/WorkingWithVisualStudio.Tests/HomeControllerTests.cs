using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using WorkingWithVisualStudio.Controllers;
using WorkingWithVisualStudio.Models;

namespace WorkingWithVisualStudio.Tests
{
    [TestFixture]
    public class HomeControllerTests
    {
        [Test]
        public void IndexActionModelIsComplete()
        {
            // Arrange
            var controller = new HomeController();
            // Act
            var model = (controller.Index() as ViewResult)?.ViewData.Model
                as IEnumerable<Product>;
            // Assert
            
            Assert.That(SimpleRepository.SharedRepository.Products,Is.EquivalentTo(model));
            //Assert.AreEqual(SimpleRepository.SharedRepository.Products, model,
              //  Comparer.Get<Product>((p1, p2) => p1.Name == p2.Name
                //                                  && p1.Price == p2.Price));
        }
    }
}
