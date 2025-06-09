namespace Delegates;

public class CarOilSensor
{
    public delegate void OilSensorSubscriber(int temperature);
    public int Temp { get; set; }
    public int OilMileage { get; set; }
    
    private List<OilSensorSubscriber> _oilSensors = new List<OilSensorSubscriber>();

    public void SetOilTemp(int value)
    {
        Temp = value;
        NotifySensor();
    }
    public void SetOilMileage(int value)
    {
        OilMileage = value;
        NotifySensor();
    }

    private void NotifySensor()
    {
        foreach (var oilSensor in _oilSensors)
        {
            oilSensor?.Invoke(Temp);
        }
    }

    public void AddSensor(OilSensorSubscriber oilSensor)
    {
        _oilSensors.Add(oilSensor);
    }

    public void RemoveSensor(OilSensorSubscriber oilSensor)
    {
        _oilSensors.Remove(oilSensor);
    }

    public void ShowSensors()
    {
        foreach (var oilSensor in _oilSensors)
        {
            Console.WriteLine(oilSensor);
        }
    }
    
    
}