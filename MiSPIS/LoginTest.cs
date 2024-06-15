using Xunit;
using Moq;
using System.Data;
using MySql.Data.MySqlClient;

namespace MiSPIS.Tests
{
    public class AuthenticationTests
    {
        [Fact]
        public void AuthenticateUser_ValidCredentials_SuccessfulLogin()
        {
            // Arrange
            var dbMock = new Mock<IDatabase>();
            var authentication = new Authentication(dbMock.Object);

            string expectedLogin = "testLogin";
            string expectedPassword = "testPassword";
            string expectedHash = md5.hashPassword(expectedPassword);

            var dataTable = new DataTable();
            dataTable.Rows.Add(dataTable.NewRow()); // Add a row to simulate a valid user

            dbMock.Setup(db => db.GetConnection()).Returns(new MySqlConnection());
            dbMock.Setup(db => db.ExecuteQuery(It.IsAny<MySqlCommand>())).Returns(dataTable);

            // Act
            var result = authentication.AuthenticateUser(expectedLogin, expectedPassword);

            // Assert
            Assert.True(result);
        }
        [Fact]
        public void AuthenticateUser_InvalidCredentials_UnsuccessfulLogin()
        {
            // Arrange
            var dbMock = new Mock<IDatabase>();
            var authentication = new Authentication(dbMock.Object);

            string expectedLogin = "testLogin";
            string expectedPassword = "wrongPassword";
            string expectedHash = md5.hashPassword(expectedPassword);

            var dataTable = new DataTable(); // No rows to simulate an invalid user

            dbMock.Setup(db => db.GetConnection()).Returns(new MySqlConnection());
            dbMock.Setup(db => db.ExecuteQuery(It.IsAny<MySqlCommand>())).Returns(dataTable);

            // Act
            var result = authentication.AuthenticateUser(expectedLogin, expectedPassword);

            // Assert
            Assert.False(result);
        }
    }
}