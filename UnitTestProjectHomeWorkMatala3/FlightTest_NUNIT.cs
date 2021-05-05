using HomeWorkMatala3;
using NUnit.Framework;
using System;

namespace UnitTestProjectHomeWorkMatala3
{
    [TestFixture]
    public class FlightTest_NUNIT
    {
        [Test]
        //[TheNameOfTheMethodWeWishToTest]_[Scenraio]_[ExpectedBehavior]
        public void CanBeCanceledBy_customerIsVIP_returnTrue()
        {
            //Arrange
            Flight flight = new Flight();
            Customer customer = new Customer { VIP = true };

            //Act
            bool result = flight.CanBeCanceledBy(customer);
            //Assert
            Assert.IsTrue(result, "customer that is not vip cant cancle flight");
        }
        [Test]
        //[TheNameOfTheMethodWeWishToTest]_[Scenraio]_[ExpectedBehavior]
        public void CanBeCanceledBy_customerIsVIP_returnFalse()
        {
            //Arrange
            Flight flight = new Flight();
            Customer customer = new Customer { VIP = true };

            //Act
            bool result = flight.CanBeCanceledBy(customer);
            //Assert
            Assert.IsFalse(!result, "customer that is not vip cant cancle flight");
        }
        [Test]
        //[TheNameOfTheMethodWeWishToTest]_[Scenraio]_[ExpectedBehavior]
        public void CanBeCanceledBy_customerIsOrderBy_returnTrue()
        {
            //Arrange
            Flight flight = new Flight();
            Customer customer = new Customer();
            flight.OrderedBy.VIP = false;
            customer = flight.OrderedBy;
            //Act
            bool result = flight.CanBeCanceledBy(customer);
            //Assert
            Assert.IsTrue(result, "customer that isnt OrderBy cant cancle flight");
        }
        [Test]
        public void CanBeCanceledBy_customerIsntVIPIsntOrderBy_returnFalse()
        {
            //Arrange
            Flight flight = new Flight();
            Customer customer = new Customer();
            flight.OrderedBy.VIP = false;
            //Act
            bool result = flight.CanBeCanceledBy(customer);
            //Assert
            Assert.IsFalse(result, "customer that isnt OrderBy and isnt VIP cant cancle flight");
        }

        //Matala 4
        [Test]
        public void CanBeOrderedBy_customerINST18DateTimeBeforeFlight_returnFalse()
        {
            //Arrange
            Flight flight = new Flight();
            // please enter your age and status
            Customer customer = new Customer{ age = 16 };
            //choose date of the flight
            flight.FlightDate = new System.DateTime(2021, 12, 01);

            //Act
            bool result = flight.CanBeOrderedBy(customer, DateTime.Now);
            //Assert
            Assert.IsFalse(result, "ERROR! WRONG! That's datetime of the flight isnt variable! Or your customer too young!");
        }

        [Test]
        public void CanBeOrderedBy_customerINST18orderDateOKFlight_returnFalse()
        {
            //Arrange
            Flight flight = new Flight();
            // please enter your age and status
            Customer customer = new Customer { age = 16 };
            //choose date of the flight
            flight.FlightDate = new System.DateTime(2023, 12, 01);

            //Act
            bool result = flight.CanBeOrderedBy(customer, DateTime.Now);
            //Assert
            Assert.IsFalse(result, "ERROR! WRONG! That's datetime of the flight isnt variable! Or your customer too young!");
        }
        [Test]
        public void CanBeOrderedBy_customerAdultDateTimeBeforeFlight_returnTrue()
        {
            //Arrange
            Flight flight = new Flight();
            // please enter your age and status
            Customer customer = new Customer { age = 19 };
            //choose date of the flight
            flight.FlightDate = new System.DateTime(2022, 12, 01);

            //Act
            bool result = flight.CanBeOrderedBy(customer, DateTime.Now);
            //Assert
            Assert.IsTrue(result, "ERROR! WRONG! That's datetime of the flight isnt variable!");
        }
        [Test]
        
        public void CanBeOrderedBy_customerAdultDateTimeAfterFlight_returnFalse()
        {
            //Arrange
            Flight flight = new Flight();
            // please enter your age and status
            Customer customer = new Customer { age = 19};
            //choose date of the flight
            flight.FlightDate = new System.DateTime(2011, 12, 01);
            //Act
            bool result = flight.CanBeOrderedBy(customer, DateTime.Now);
            //Assert
            Assert.IsFalse(result, "ERROR! WRONG! That's datetime of the flight is variable!");
        }
        [Test]
        
        public void CanBeOrderedBy_customerAdultDateTimeInTheDayOFFLIGHT_returnFalse()
        {
            //Arrange
            Flight flight = new Flight();
            // please enter your age and status
            Customer customer = new Customer { age = 19};
            //choose date of the flight
            //Date time sama day like day of the flight
            flight.FlightDate = System.DateTime.Now;
            //Act
            bool result = flight.CanBeOrderedBy(customer, DateTime.Now);
            //Assert
            Assert.IsFalse(result, "ERROR! WRONG! That's datetime of the flight is variable! THAT MUST BE THE DAY OF THE FLIGHT!");
        }

    }
}
