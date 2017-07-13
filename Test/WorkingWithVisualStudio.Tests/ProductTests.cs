using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using WorkingWithVisualStudio.Models;

namespace WorkingWithVisualStudio.Tests
{
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void CanChangeProductName()
        {
            // Arrange
            var p = new Product {Name = "Test", Price = 100M};
            // Act
            p.Name = "New Name";
            //Assert
            Assert.That(p.Name, Is.EqualTo("New Name"));
        }

        [Test]
        public void CanChangeProductPrice()
        {
            // Arrange
            var p = new Product {Name = "Test", Price = 100M};
            // Act
            p.Price = 200M;
            //Assert
            Assert.That( p.Price,Is.EqualTo(100M));
        }
    }
}
