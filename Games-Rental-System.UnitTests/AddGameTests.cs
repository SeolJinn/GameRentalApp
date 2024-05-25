using NUnit.Framework;
using Moq;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Games_Rental_System.Tests
{
    [TestFixture]
    public class AddGameTests
    {
        [Test]
        public void AddButton_Click_GameAlreadyExists_ShowGameExistsMessage()
        {
            // Arrange
            var mockConnection = new Mock<SqlConnection>();
            var mockCommand = new Mock<SqlCommand>();
            var mockDataReader = new Mock<SqlDataReader>();
            var mockInpGameName = new Mock<TextBox>();
            var mockInpVendorName = new Mock<TextBox>();
            var mockInpGameAmount = new Mock<TextBox>();
            var mockInpGamePrice = new Mock<TextBox>();
            var mockCategories = new Mock<ComboBox>();
            var mockPbPhoto = new Mock<PictureBox>();

            mockDataReader.Setup(m => m.Read()).Returns(true); // Simulate game exists
            mockCommand.Setup(m => m.ExecuteReader()).Returns(mockDataReader.Object);
            mockInpGameName.SetupGet(m => m.Text).Returns("testGameName");
            mockInpVendorName.SetupGet(m => m.Text).Returns("testVendorName");
            mockInpGameAmount.SetupGet(m => m.Text).Returns("10");
            mockInpGamePrice.SetupGet(m => m.Text).Returns("20.99");
            mockCategories.SetupGet(m => m.Text).Returns("Action");
            mockPbPhoto.SetupGet(m => m.Image).Returns(new Bitmap(10, 10)); // Simulate image loaded

            frmAddGame form = new frmAddGame();
            form.inpGameName = mockInpGameName.Object;
            form.inpVendorName = mockInpVendorName.Object;
            form.inpGameAmount = mockInpGameAmount.Object;
            form.inpGamePrice = mockInpGamePrice.Object;
            form.Categories = mockCategories.Object;
            form.pbPhoto = mockPbPhoto.Object;

            // Act
            form.addButton_Click(null, EventArgs.Empty);

            // Assert
            MessageBoxVerifier.VerifyMessageBoxShown("Game already exists");
        }

        [Test]
        public void AddButton_Click_GameAddedSuccessfully_ShowSuccessMessage()
        {
            // Arrange
            var mockConnection = new Mock<SqlConnection>();
            var mockCommand = new Mock<SqlCommand>();
            var mockDataReader = new Mock<SqlDataReader>();
            var mockInpGameName = new Mock<TextBox>();
            var mockInpVendorName = new Mock<TextBox>();
            var mockInpGameAmount = new Mock<TextBox>();
            var mockInpGamePrice = new Mock<TextBox>();
            var mockCategories = new Mock<ComboBox>();
            var mockPbPhoto = new Mock<PictureBox>();

            mockDataReader.Setup(m => m.Read()).Returns(false); // Simulate game doesn't exist
            mockCommand.SetupSequence(m => m.ExecuteReader())
                        .Returns(mockDataReader.Object)
                        .Returns(mockDataReader.Object); // First call checks if game exists, second call for insertion
            mockInpGameName.SetupGet(m => m.Text).Returns("testGameName");
            mockInpVendorName.SetupGet(m => m.Text).Returns("testVendorName");
            mockInpGameAmount.SetupGet(m => m.Text).Returns("10");
            mockInpGamePrice.SetupGet(m => m.Text).Returns("20.99");
            mockCategories.SetupGet(m => m.Text).Returns("Action");
            mockPbPhoto.SetupGet(m => m.Image).Returns(new Bitmap(10, 10)); // Simulate image loaded

            frmAddGame form = new frmAddGame();
            form.inpGameName = mockInpGameName.Object;
            form.inpVendorName = mockInpVendorName.Object;
            form.inpGameAmount = mockInpGameAmount.Object;
            form.inpGamePrice = mockInpGamePrice.Object;
            form.Categories = mockCategories.Object;
            form.pbPhoto = mockPbPhoto.Object;

            // Act
            form.addButton_Click(null, EventArgs.Empty);

            // Assert
            MessageBoxVerifier.VerifyMessageBoxShown("Game added successfully");
        }

        // Add more test cases as needed
    }
}
