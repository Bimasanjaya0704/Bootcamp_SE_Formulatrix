using BicycleComponents;
namespace BicycleBody;

public class Bicycle
{
	public Lamp lamp;
	public Tire tire;
	public Bell bell;
	public Bicycle(Lamp lamp, Tire tire, Bell bell)
	{
		this.lamp = lamp;
		this.tire = tire;
		this.bell = bell;
	}

}
