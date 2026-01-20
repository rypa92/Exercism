class RemoteControlCar
{
    private int metersDriven = 0;
    private int batteryPercent = 100;
    
    public static RemoteControlCar Buy()
    {
        var newCar = new RemoteControlCar();
        return newCar;
    }

    public string DistanceDisplay()
    {
        return "Driven " + metersDriven + " meters";
    }

    public string BatteryDisplay()
    {
        if(batteryPercent > 0) {
            return "Battery at " + batteryPercent + "%";
        } else {
            return "Battery empty";
        }
    }

    public void Drive()
    {
        if(batteryPercent > 0){
            metersDriven += 20;
            batteryPercent -= 1;
        }
    }
}
