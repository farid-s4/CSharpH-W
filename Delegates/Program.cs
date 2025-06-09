using Delegates;

void LogSensor(int value) => Console.WriteLine($"Current value of temperature: {value}");
void CheckOilMileage(int value)
{
    if (value > 7000)
    {
        Console.WriteLine("Oil mileage is too high");
    }
}

CarOilSensor carOilSensor = new CarOilSensor();
carOilSensor.AddSensor(LogSensor);
carOilSensor.AddSensor(CheckOilMileage);
while (true)
{
    int choose = 0;

    Console.WriteLine("\nEnter the command:" +
                      "\n1. Add subscriber (Logger) " +
                      "\n2. Add subscriber (CheckOilMileage)" +
                      "\n3. Remove subscriber(Logger)" +
                      "\n4. Remove subscriber(CheckOilMileage)" +
                      "\n5. Set new value(temp)" +
                      "\n6. Set new value(OilMileage)" +
                      "\n7. Show subscriber list" +
                      "\n8. Exit");

    choose = int.TryParse(Console.ReadLine(), out choose) ? choose : 0;

    switch (choose)
    {
        case 1:
        {
            carOilSensor.AddSensor(LogSensor);
            break;
        }
        case 2:
        {
            carOilSensor.AddSensor(CheckOilMileage);
            break;
        }
        case 3:
        {
            carOilSensor.RemoveSensor(LogSensor);
            break;
        }
        case 4:
        {
            carOilSensor.RemoveSensor(CheckOilMileage);
            break;
        }
        case 5:
        {
            int temp = 0;
            Console.WriteLine("Set new temp: ");
            temp = int.TryParse(Console.ReadLine(), out temp) ? temp : 0;
            carOilSensor.SetOilTemp(temp);
            break;
        }
        case 6:
        {
            int mileage = 0;
            Console.WriteLine("Set new OilMileage: ");
            mileage = int.TryParse(Console.ReadLine(), out mileage) ? mileage : 0;
            carOilSensor.SetOilTemp(mileage);
            break;
        }
        case 7:
        {
            carOilSensor.ShowSensors();
            break;
        }
        case 8:
        {
            return;
        }
    }
}
