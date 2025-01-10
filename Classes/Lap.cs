using Encapsulation1.Classes;

public class Lap
{
    public LapGui Gui { get; private set; }

    public Lap()
    {
        Gui = new LapGui(this); // Pass this Lap instance to the Database class
    }
}