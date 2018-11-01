using CalTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalTestingTests
{
    public class TwoAttemptUnitInput : IConsole
    {
        public int NumberOfTimesInvoked { get; set; }
        public string SimulatedInput { get; set; }

        /// <summary>
        /// The implementation that returns what we want, for unit testing purposes.
        /// </summary>
        /// <returns></returns>
        public string ReadLine()
        {
            NumberOfTimesInvoked++;

            if (NumberOfTimesInvoked == 1)
            {
                return "asdf";
            }

            return SimulatedInput;
        }
    }
}
