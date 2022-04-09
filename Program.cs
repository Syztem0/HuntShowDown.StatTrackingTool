// See https://aka.ms/new-console-template for more information
using System;

namespace HuntShowDown.StatTrackingTool
{
    using System.Diagnostics;

    class Program
    {
        // TODO:What is the actual effect of having a top level variable public, and are there any security issues with it?
        public ProgramState{};
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World.");
            MainLoop();
        }

        private static void MainLoop()
        {
            throw new NotImplementedException();
        }
    }

    struct ProgramState
    {
        
    }
}

