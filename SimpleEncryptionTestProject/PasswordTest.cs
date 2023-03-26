using SimpleEncrytion;

namespace SimpleEncryptionTestProject
{
    [TestClass]
    public class PasswordTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            //SalaryCalculator sc = new SalaryCalculator();
            PasswordEncryptor passwordEncryptor = new PasswordEncryptor();

            //Act
            string encryptedPass = passwordEncryptor.encryptPass("!Abc!");

            //Assert
            Assert.AreEqual("!Bca!ay", encryptedPass);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            //SalaryCalculator sc = new SalaryCalculator();
            PasswordEncryptor passwordEncryptor = new PasswordEncryptor();

            //Act
            string encryptedPass = passwordEncryptor.encryptPass("Ab!");

            //Assert
            Assert.AreEqual("Ba!ay", encryptedPass);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            //SalaryCalculator sc = new SalaryCalculator();
            PasswordEncryptor passwordEncryptor = new PasswordEncryptor();

            //Act
            string encryptedPass = passwordEncryptor.encryptPass("A!b");

            //Assert
            Assert.AreEqual("B!aay", encryptedPass);
        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            //SalaryCalculator sc = new SalaryCalculator();
            PasswordEncryptor passwordEncryptor = new PasswordEncryptor();

            //Act
            string encryptedPass = passwordEncryptor.encryptPass("!Ab");

            //Assert
            Assert.AreEqual("!Baay", encryptedPass);
        }

        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            //SalaryCalculator sc = new SalaryCalculator();
            PasswordEncryptor passwordEncryptor = new PasswordEncryptor();

            //Act
            string encryptedPass = passwordEncryptor.encryptPass("!a a!");

            //Assert
            Assert.AreEqual("!aay a!ay", encryptedPass);
        }

        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            //SalaryCalculator sc = new SalaryCalculator();
            PasswordEncryptor passwordEncryptor = new PasswordEncryptor();

            //Act
            string encryptedPass = passwordEncryptor.encryptPass("a!");

            //Assert
            Assert.AreEqual("a!ay", encryptedPass);
        }

        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            //SalaryCalculator sc = new SalaryCalculator();
            PasswordEncryptor passwordEncryptor = new PasswordEncryptor();

            //Act
            string encryptedPass = passwordEncryptor.encryptPass("Ab! A!b !Ab !a a!");

            //Assert
            Assert.AreEqual("Ba!ay B!aay !Baay !aay a!ay", encryptedPass);
        }
    }
}