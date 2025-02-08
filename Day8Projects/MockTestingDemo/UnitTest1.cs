
using Moq;


namespace MockTestingDemo
{

    public class CheckEmployee
    {
        public virtual Boolean checkemp()
        {
            throw new NotImplementedException();
        }

       

    }
    public class ProcessEmployee
    {
        public int insertEmployee(CheckEmployee emp)// depending upon check emp class

        {
            emp.checkemp();
            // logic for implemting inseting employee using ado.net 
            return 1;

        }
    }
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           Mock<CheckEmployee> checkobj = new Mock<CheckEmployee>();
            checkobj.Setup(x => x.checkemp()).Returns(true);// forfully made true which will create one object 
            Assert.AreEqual(true, checkobj.Object.checkemp());// 
            ProcessEmployee proobj=new ProcessEmployee();
            Assert.AreEqual(1, proobj.insertEmployee(checkobj.Object));


        }
    }
}