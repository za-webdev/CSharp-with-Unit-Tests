using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalTesting
{
    /// <summary>
    /// The contract, which we can rely on in our application.
    /// </summary>
    public interface IConsole
    {
        /// <summary>
        /// The method signature, that is the same as Console.
        /// </summary>
        /// <returns></returns>
        string ReadLine();
    }

    public class ConsoleInput : IConsole
    {
        /// <summary>
        /// The wrapped method, that actually calls the console.
        /// </summary>
        /// <returns></returns>
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
    
    public class Demo
    {
        public IConsole Console { get; set; }
        public string Number1 { get; set; }
        public int first;

        public Demo(IConsole console)
        {
            Console = console;
        }

        public void ReadExample()
        {
            while (!IsValid(Number1))
            {
                Number1 = GetFirstNumber(Console);
            }
        }

        private bool IsValid(string value)
        {
            return int.TryParse(value, out first);
        }

        /// <summary>
        /// Our implementation now rely's on the contract, so we can change the implementation for testing purposes.
        /// </summary>
        /// <param name="console"></param>
        /// <returns></returns>
        private string GetFirstNumber(IConsole console)
        {
            return console.ReadLine();
        }
    }
}
 