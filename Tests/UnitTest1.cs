using Microsoft.Extensions.Options;
using Moq;
using Hielko.Encryption;

namespace EncryptionTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var optionsMock = new Mock<IOptions<EncryptionOptions>>();
            optionsMock.Setup(x => x.Value).Returns(new EncryptionOptions() { Key = "A546C4DF2A8CF5931469B24222322301" });
            //optionsMock.Setup(x => x.Equals(It.IsAny<string>())).Returns(true);

            var encryption = new Encryption(optionsMock.Object);

            string plainInput = "1234";

            var encryptedInput = encryption.Encrypt(plainInput);
            Assert.AreNotEqual(plainInput, encryptedInput);

            var decryptedInput = encryption.Decrypt(encryptedInput);
            Assert.AreEqual(plainInput, decryptedInput);

        }
    }
}