using ComponentHp;
namespace ItemHp;

public class Camera : Components
{
	public int resolusi;
	public Camera(string brand, int price, int resolusi) : base(brand, price)
	{
		this.resolusi = resolusi;
	}
}
