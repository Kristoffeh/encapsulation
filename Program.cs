using System.Net.Mime;
using Encapsulation1.Classes;

namespace Encapsulation1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Application launched.");
        
        var lap = new Lap();
        lap.Gui.setVehicle("FZR");
        
        lap.sendMessage($"Vehicle: {lap.Gui.getVehicle()}");

        Console.ReadLine();
    }
    
}