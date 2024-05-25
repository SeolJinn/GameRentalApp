using NUnit.Framework;
using Moq;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Games_Rental_System.Tests
{
    [TestFixture]
    public class AddClientTests
    {
        [Test]
        public void AddButton_Click_ClientAlreadyExists_ShowExistsMessage()
        {
            // Arrange
            var mockConnection = new Mock<SqlConnection>();
            var mockCommand = new Mock<SqlCommand>();
            var mockDataReader = new Mock<SqlDataReader>();
            var mockInpClientUsername = new Mock<TextBox>();
            var mockInpClientPassword = new Mock<TextBox>();
            var mockInpClientPasswordConfirm = new Mock<TextBox>();
            var mockInpClientPhone = new Mock<TextBox>();
            var mockInpClientFirstName = new Mock<TextBox>();
            var mockInpClientSecondName = new Mock<TextBox>();

            mockDataReader.Setup(m => m.Read()).Returns(true); // Simulate client exists
            mockCommand.Setup(m => m.ExecuteReader()).Returns(mockDataReader.Object);
            mockInpClientUsername.SetupGet(m => m.Text).Returns("testUsername");

            frmAddClient form = new frmAddClient();
            form.inpClientUsername = mockInpClientUsername.Object;
            form.inpCLientPassword = mockInpClientPassword.Object;
            form.inpCLientPasswordConfirm = mockInpClientPasswordConfirm.Object;
            form.inpClientPhone = mockInpClientPhone.Object;
            form.inpClientFirstName = mockInpClientFirstName.Object;
            form.inpClientSecondName = mockInpClientSecondName.Object;

            // Act
            form.addButton_Click(null, EventArgs.Empty);

            // Assert
            MessageBoxVerifier.VerifyMessageBoxShown("Client already exists");
        }

        [Test]
        public void AddButton_Click_PasswordsDoNotMatch_ShowPasswordsNotMatchMessage()
        {
            // Arrange
            var mockConnection = new Mock<SqlConnection>();
            var mockCommand = new Mock<SqlCommand>();
            var mockDataReader = new Mock<SqlDataReader>();
            var mockInpClientUsername = new Mock<TextBox>();
            var mockInpClientPassword = new Mock<TextBox>();
            var mockInpClientPasswordConfirm = new Mock<TextBox>();
            var mockInpClientPhone = new Mock<TextBox>();
            var mockInpClientFirstName = new Mock<TextBox>();
            var mockInpClientSecondName = new Mock<TextBox>();

            mockDataReader.Setup(m => m.Read()).Returns(false); // Simulate client doesn't exist
            mockCommand.SetupSequence(m => m.ExecuteReader())
                        .Returns(mockDataReader.Object)
                        .Returns(mockDataReader.Object); // First call checks if client exists, second call for insertion
            mockInpClientUsername.SetupGet(m => m.Text).Returns("testUsername");
            mockInpClientPassword.SetupGet(m => m.Text).Returns("password");
            mockInpClientPasswordConfirm.SetupGet(m => m.Text).Returns("differentPassword");

            frmAddClient form = new frmAddClient();
            form.inpClientUsername = mockInpClientUsername.Object;
            form.inpCLientPassword = mockInpClientPassword.Object;
            form.inpCLientPasswordConfirm = mockInpClientPasswordConfirm.Object;
            form.inpClientPhone = mockInpClientPhone.Object;
            form.inpClientFirstName = mockInpClientFirstName.Object;
            form.inpClientSecondName = mockInpClientSecondName.Object;

            // Act
            form.addButton_Click(null, EventArgs.Empty);

            // Assert
            MessageBoxVerifier.VerifyMessageBoxShown("The two passwords are not the same");
        }

        // Add more test cases as needed
    }
}
