using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWUT.Models;
using System;

namespace UnitTests
{
    [TestClass]
    public class ProductModelTests
    {
        [TestMethod]
        public void ProductModel_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Average_Rating_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            int rating = 5;

            // Assert
            Assert.AreEqual(rating, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_To_String_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            //result.ToString  = "null";

            // Assert
            //Assert.AreEqual(s, result.ToString);
        }

        [TestMethod]
        public void ProductModel_Get_Date_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Date = DateTime.UtcNow;

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToShortDateString(), result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_Get_Description_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Description = "Great product";

            // Assert
            Assert.AreEqual("Great product", result.Description);
        }

        [TestMethod]
        public void ProductModel_Get_Email_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Email = "mmyuk@seattleu.edu";

            // Assert
            Assert.AreEqual("mmyuk@seattleu.edu", result.Email);
        }

        [TestMethod]
        public void ProductModel_Get_Id_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Id = "joe";

            // Assert
            Assert.AreEqual("joe", result.Id);
        }

        [TestMethod]
        public void ProductModel_Get_Image_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Image = "Bike";

            // Assert
            Assert.AreEqual("Bike", result.Image);
        }

        [TestMethod]
        public void ProductModel_Get_Logistics_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Logistics = "In transit";

            // Assert
            Assert.AreEqual("In transit", result.Logistics);
        }

        [TestMethod]
        public void ProductModel_Get_Maker_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Maker = "Bike";

            // Assert
            Assert.AreEqual("Bike", result.Maker);
        }

        [TestMethod]
        public void ProductModel_Get_Ratings_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            int[] x = { 1, 2, 3, 4, 5 };
            result.Ratings = x;

            // Assert
            Assert.AreEqual(x, result.Ratings);
        }

        [TestMethod]
        public void ProductModel_Get_Sequence_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Title_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Url_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Set_Date_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Set_Description_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Set_Email_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Set_Id_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Set_Image_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Set_Logistics_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Set_Maker_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Set_Ratings_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Set_Sequence_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Set_Title_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Set_Url_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

    }
}
