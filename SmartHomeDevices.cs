/*Smart Home Devices
○ Description: Create a hierarchy for a smart home system where Device is the superclass and Thermostat is a subclass.
○ Tasks:
■ Define a superclass Device with attributes like DeviceId and Status.
■ Create a subclass Thermostat with additional attributes like TemperatureSetting.
■ Implement a method DisplayStatus() to show each device's current settings.
○ Goal: Understand single inheritance by adding specific attributes to a subclass, keeping the superclass general.*/


using System; 

public class Device
{
	public int DeviceId;
	public string Status;
	public virtual void DisplayStatus()
	{
		Console.WriteLine("Device ID:" + DeviceId);
		Console.WriteLine("Status:" + Status);
	}
}

public class Thermostat: Device
{
	public int TemperatureSetting;

	public override void DisplayStatus()
	{
		base.DisplayInfo();
		Console.WriteLine("Temeparture Setting: " + TemperatureSetting);
	}
}