namespace Encapsulation1.Classes;

public class LapGui
{
    private readonly Lap _lap; // Reference to the parent Lap object
    private string vehicle;

    public LapGui(Lap lap)
    {
        _lap = lap;
    }

    public string getVehicle()
    {
        return vehicle;
    }

    public void setVehicle(string vehicle)
    {
        this.vehicle = vehicle;
    }
}