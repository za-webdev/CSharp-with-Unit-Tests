using CalTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalTestingTests
{
    public class WigglyPiggly : IConsole
    {
        public string ReadLine()
        {
            return "Yay!";
        }
    }

    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void ConsoleTest_FirstInvalidSecondValid_LoopsTwice()
        {
            // Arrange...
            TwoAttemptUnitInput console = new TwoAttemptUnitInput()
            {
                SimulatedInput = "123"
            };
            var demo = new Demo(console);
            
            // Act...
            demo.ReadExample();

            // Assert...
            Assert.AreEqual(2, console.NumberOfTimesInvoked);
        }

        [Test]
        public void ConsoleTest_FirstValid_NumberIsSet()
        {
            // Arrange...
            TwoAttemptUnitInput console = new TwoAttemptUnitInput()
            {
                SimulatedInput = "123"
            };
            var demo = new Demo(console);


            // Act...
            demo.ReadExample();

            // Assert...
            Assert.AreEqual(console.SimulatedInput, demo.Number1);
        }

        // Create an interface with a method that will return a value.
        // Create two classes that implement that interface.
        // Create a method that takes the interface.
        // Call the method twice with two different instances, first and second class.
        // Write the output, ensuring that the two classes return two different values.
    }
}
