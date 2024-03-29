﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.VendingMachineFolder
{
    public abstract class VendingMachineItem
    {
        public string Slot { get; }

        public string Name { get; }

        public decimal Price { get; }

        public string Type { get; }

        public int RemainingInventory { get; private set; }

        public VendingMachineItem(string slot, string name, decimal price, string type)
        {
            this.Slot = slot;
            this.Name = name;
            this.Price = price;
            this.Type = type;
            this.RemainingInventory = 5;
        }

        public abstract string MakeFoodSound();

        public void DecrementItem(string code, Dictionary<string, VendingMachineItem> inv)
        {
            inv[code].RemainingInventory--;
        }
    }
}
