﻿using System;
using Capstone.CLIs;
using Capstone.VendingMachineFolder;

namespace Capstone
{
    public class Program
    {
        public static void Main(string[] args)
        {
            VendingMachine vm = new VendingMachine();
            MainMenuCLI menu = new MainMenuCLI();
            menu.Run(vm);
        }
    }
}
