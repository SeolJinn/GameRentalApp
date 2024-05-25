using NUnit.Framework;
using Moq;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

[TestFixture]
public class LoginTests
{
    private Mock<SqlConnection> mockConnection;
    private Mock<SqlCommand> mockCommand;
    private Mock<SqlDataReader> mockDataReader;
    private Mock<TextBox> mockInpUserName;
    private Mock<TextBox> mockInpPassword;

    [SetUp]
    public void SetUp()
    {
        mockConnection = new Mock<SqlConnection>();
        mockCommand = new Mock<SqlCommand>();
        mockDataReader = new Mock<SqlDataReader>();
        mockInpUserName = new Mock<TextBox>();
        mockInpPassword = new Mock<TextBox>();

        // Setup mock objects as needed for your tests
    }

    [Test]
    public void LoginButton_Click_CorrectCredentials_ClientLogin_Success()
    {
        // Arrange
        mockDataReader.Setup(m => m.Read()).Returns(true); // Simulate user exists
        mockDataReader.Setup(m => m["C_USERNAME"]).Returns("testUser");
        mockDataReader.Setup(m => m["C_PASSWORD"]).Returns("password");
        mockCommand.Setup(m => m.ExecuteReader()).Returns(mockDataReader.Object);
        mockInpUserName.SetupGet(m => m.Text).Returns("testUser");
        mockInpPassword.SetupGet(m => m.Text).Returns("password");

        // Act
        // Call loginButton_Click method with mocked objects
        var form = new Form(); // Create a new Form to attach the controls
        form.Controls.Add(mockInpUserName.Object);
        form.Controls.Add(mockInpPassword.Object);
        Login loginForm = new Login(); // Instantiate the Login form
        loginForm.loginButton_Click(null, EventArgs.Empty);

        // Assert
        // Verify that the User.User_Name is set correctly
        Assert.AreEqual("testUser", User.User_Name);
        // Add more assertions as needed
    }

    [Test]
    public void LoginButton_Click_IncorrectCredentials_ShowWrongPasswordMessage()
    {
        // Arrange
        mockDataReader.Setup(m => m.Read()).Returns(true); // Simulate user exists
        mockDataReader.Setup(m => m["C_USERNAME"]).Returns("testUser");
        mockDataReader.Setup(m => m["C_PASSWORD"]).Returns("password");
        mockCommand.Setup(m => m.ExecuteReader()).Returns(mockDataReader.Object);
        mockInpUserName.SetupGet(m => m.Text).Returns("testUser");
        mockInpPassword.SetupGet(m => m.Text).Returns("wrongPassword");

        // Act
        // Call loginButton_Click method with mocked objects
        var form = new Form(); // Create a new Form to attach the controls
        form.Controls.Add(mockInpUserName.Object);
        form.Controls.Add(mockInpPassword.Object);
        Login loginForm = new Login(); // Instantiate the Login form
        loginForm.loginButton_Click(null, EventArgs.Empty);

        // Assert
        // Verify that the MessageBox with "Wrong Password" message is shown
        MessageBoxVerifier.VerifyMessageBoxShown("Wrong Password");
    }

    // Similarly, write tests for loginAdminButton_Click method
}
