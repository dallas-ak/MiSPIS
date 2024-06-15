using Xunit;
using Moq;
using System.Data;
using MySql.Data.MySqlClient;

namespace MiSPIS.Tests
{
    public class RegistrationServiceTests
    {
        [Fact]
        public void RegisterUser_WithInvalidUserName_ShowsErrorMessage()
        {
            // Arrange
            var dbMock = new Mock<IDatabase>();
            var service = new RegistrationService(dbMock.Object);

            var expectedMessage = "Введите имя пользователя";

            // Act
            var result = service.RegisterUser("", "password", "validName", "validSurname", out var message);

            // Assert
            Assert.False(result);
            Assert.Equal(expectedMessage, message);
        }
        [Fact]
        public void RegisterUser_WithValidData_CallsDatabase()
        {
            // Arrange
            var dbMock = new Mock<IDatabase>();
            var hasherMock = new Mock<md5hash>();
            var md5hash = new Mock<md5>();
            hasherMock.Setup(h => h.HashPassword(It.IsAny<string>())).Returns("hashedPassword");

            var service = new RegistrationService(dbMock.Object);

            dbMock.Setup(db => db.ExecuteQuery(It.IsAny<MySqlCommand>())).Returns(new DataTable());
            dbMock.Setup(db => db.ExecuteNonQuery(It.IsAny<MySqlCommand>())).Returns(1);

            var expectedMessage = "Успешная регистрация";

            // Act
            var result = service.RegisterUser("validLogin", "password", "validName", "validSurname", out var message);

            // Assert
            Assert.True(result);
            Assert.Equal(expectedMessage, message);
            dbMock.Verify(db => db.ExecuteNonQuery(It.IsAny<MySqlCommand>()), Times.Once);
        }
        [Fact]
        public void IsUserExists_WithExistingUser_ReturnsTrue()
        {
            // Arrange
            var dbMock = new Mock<IDatabase>();
            var service = new RegistrationService(dbMock.Object);

            var dataTable = new DataTable();
            dataTable.Rows.Add(dataTable.NewRow()); // Simulate existing user

            dbMock.Setup(db => db.ExecuteQuery(It.IsAny<MySqlCommand>())).Returns(dataTable);

            // Act
            var result = service.IsUserExists("existingUser");

            // Assert
            Assert.True(result);
        }
        [Fact]
        public void IsUserExists_WithNonExistingUser_ReturnsFalse()
        {
            // Arrange
            var dbMock = new Mock<IDatabase>();

            var service = new RegistrationService(dbMock.Object);

            dbMock.Setup(db => db.ExecuteQuery(It.IsAny<MySqlCommand>())).Returns(new DataTable());

            // Act
            var result = service.IsUserExists("newUser");

            // Assert
            Assert.False(result);
        }
    }
}