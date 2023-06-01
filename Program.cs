using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    public class Program
    {
        List<Nobel> adatok = new List<Nobel>();
        static void Main(string[] args)
        {
            File.ReadAllLines("nobel.csv").Skip(1).ToList().ForEach(x => new Nobel(adatok.Add(x));
        }
    }
}
