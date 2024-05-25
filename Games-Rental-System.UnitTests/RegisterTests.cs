using NUnit.Framework;
using Moq;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Win32;

[TestFixture]
public class RegisterTests
{
    private Mock<SqlConnection> mockConnection;
    private Mock<SqlCommand> mockCommand;
    private Mock<SqlDataReader> mockDataReader;
    private Mock<TextBox> mockInpUserName;
    private Mock<TextBox> mockInpPassword;
    private Mock<TextBox> mockInpPasswordConfirm;

    [SetUp]
    public void SetUp()
    {
        mockConnection = new Mock<SqlConnection>();
        mockCommand = new Mock<SqlCommand>();
        mockDataReader = new Mock<SqlDataReader>();
        mockInpUserName = new Mock<TextBox>();
        mockInpPassword = new Mock<TextBox>();
        mockInpPasswordConfirm = new Mock<TextBox>();

        // Setup mock objects as needed for your tests
    }

    [Test]
    public void RegisterButton_Click_UserAlreadyExists_ShowUserExistsMessage()
    {
        // Arrange
        mockDataReader.Setup(m => m.Read()).Returns(true); // Simulate user exists
        mockCommand.Setup(m => m.ExecuteReader()).Returns(mockDataReader.Object);
        mockInpUserName.SetupGet(m => m.Text).Returns("testUser");

        // Act
        // Call registerButton_Click method with mocked objects
        var form = new Form(); // Create a new Form to attach the controls
        form.Controls.Add(mockInpUserName.Object);
        Register registerForm = new Register(); // Instantiate the Register form
        registerForm.registerButton_Click(null, EventArgs.Empty);

        // Assert
        // Verify that the MessageBox with "User already exists" message is shown
        MessageBoxVerifier.VerifyMessageBoxShown("User already exists");
    }

    [Test]
    public void RegisterButton_Click_PasswordsDoNotMatch_ShowPasswordsNotMatchMessage()
    {
        // Arrange
        mockDataReader.Setup(m => m.Read()).Returns(false); // Simulate user doesn't exist
        mockCommand.Setup(m => m.ExecuteReader()).Returns(mockDataReader.Object);
        mockInpUserName.SetupGet(m => m.Text).Returns("testUser");
        mockInpPassword.SetupGet(m => m.Text).Returns("password");
        mockInpPasswordConfirm.SetupGet(m => m.Text).Returns("differentPassword");

        // Act
        // Call registerButton_Click method with mocked objects
        var form = new Form(); // Create a new Form to attach the controls
        form.Controls.Add(mockInpUserName.Object);
        form.Controls.Add(mockInpPassword.Object);
        form.Controls.Add(mockInpPasswordConfirm.Object);
        Register registerForm = new Register(); // Instantiate the Register form
        registerForm.registerButton_Click(null, EventArgs.Empty);

        // Assert
        // Verify that the MessageBox with "The two passwords are not the same" message is shown
        MessageBoxVerifier.VerifyMessageBoxShown("The two passwords are not the same");
    }

    // Similarly, write tests for when the registration is successful
}
