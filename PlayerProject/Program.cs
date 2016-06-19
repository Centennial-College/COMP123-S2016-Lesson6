using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Author: Kevin Ma
 * Date: June 18, 2016
 * StudentID: 300867968
 * Description: This Program tests the Player and Enemy Classes
 * Version: 0.01 - Initial Test Version - testing basic classes and methods
 */

namespace PlayerProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Player greenPlayer = new Player("green");
            greenPlayer.MoveForward();

            TouchingEnemy redEnemy = new TouchingEnemy("red");
            redEnemy.MoveForward();

            WaitForAnyKey();
        }

        /**
         * <summary>
         * Utility method to wait for a console key press from the user
         * </summary>
         * 
         * @method WaitForAnyKey
         * @returns {void}
         */
        public static void WaitForAnyKey()
        {
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++++++");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
