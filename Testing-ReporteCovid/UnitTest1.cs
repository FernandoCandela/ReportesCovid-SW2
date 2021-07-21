using NUnit.Framework;
using CTR;
using DTO;

namespace Testing_ReporteCovid
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DtoUsuario dto = new DtoUsuario
            {
                Usuario = "cbonilla",
                Contrasena = "123456"
            };
            DtoUsuario dtoR = new CtrUsuario().Usp_Usuario_Login(dto);


            Assert.AreEqual("El usuario est� deshabilitado", dtoR.ErrorMsj);
        }
        [Test]
        public void Test2()
        {
            DtoUsuario dto = new DtoUsuario
            {
                Usuario = "asdasd",
                Contrasena = "asdad1321"
            };
            DtoUsuario dtoR = new CtrUsuario().Usp_Usuario_Login(dto);


            Assert.AreEqual("El usuario es inv�lido", dtoR.ErrorMsj);
        }
        [Test]
        public void Test3()
        {
            DtoUsuario dto = new DtoUsuario
            {
                Usuario = "fd.candelam",
                Contrasena = "asdasda"
            };
            DtoUsuario dtoR = new CtrUsuario().Usp_Usuario_Login(dto);


            Assert.AreEqual("La contrase�a es inv�lida", dtoR.ErrorMsj);
        }
    }
}