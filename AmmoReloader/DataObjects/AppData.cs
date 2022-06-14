using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public static class AppData
    {
        public static string DataPath { get; set; }

        public const string AmmoFolder = "AmmoFolder";

        public const string AmmoFileName = "ammo.csv";

        public const string InventoryFileName = "inventory.csv";
    }
}
