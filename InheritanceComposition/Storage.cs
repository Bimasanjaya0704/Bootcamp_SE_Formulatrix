using ComponentHp;
namespace ItemHp;

public class Storage : Components
{
	public int size;
	public Storage(string brand, int price, int size) : base(brand, price)
	{
		this.size = size;
	}

	public void ReplaceSize(int sizeNew)
	{
		size = sizeNew;
	}
}
