using System;
using SapphireEngine;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Framework.FPSLimit = 120;
            Framework.Initialization<AppCore>();
        }
    }
}