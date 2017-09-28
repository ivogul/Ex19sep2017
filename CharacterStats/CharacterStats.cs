﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Health: |" + new string('|', currentHealth) + new string('.', maxHealth - currentHealth) + "|");
            Console.WriteLine("Energy: |" + new string('|', currentEnergy) + new string('.', maxEnergy - currentEnergy) + "|");
        }
    }
}
