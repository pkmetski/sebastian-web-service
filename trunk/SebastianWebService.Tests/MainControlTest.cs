using SebastianWebService.Controller;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using SebastianWebService.DTO;

namespace SebastianWebService.Tests
{


    /// <summary>
    ///This is a test class for MainControlTest and is intended
    ///to contain all MainControlTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MainControlTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for BookFlight
        ///</summary>
        [TestMethod()]
        public void TestBookFlightSeatsAvailable()
        {
            IDataProvider dataProvider = new MockDataProvider();
            MainControl target = new MainControl(dataProvider);
            Flight flight = new Flight() { AvailableSeats = 1 };
            bool expected = true;
            bool actual;
            actual = target.BookFlight(flight);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for BookFlight with no available seats
        ///</summary>
        [TestMethod()]
        public void TestBookFlightNoSeatsAvailable()
        {
            IDataProvider dataProvider = new MockDataProvider();
            MainControl target = new MainControl(dataProvider);
            Flight flight = new Flight() { AvailableSeats = 0 };
            bool expected = false;
            bool actual;
            actual = target.BookFlight(flight);
            Assert.AreEqual(expected, actual);
        }
    }
}
