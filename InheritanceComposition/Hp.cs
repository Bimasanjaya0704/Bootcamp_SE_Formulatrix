using ItemHp;

namespace FixHp;

public class Hp
{
	public Camera camera;
	public Storage storage;

	public Hp(Camera camera, Storage storage)
	{
		this.camera = camera;
		this.storage = storage;
		Console.WriteLine("Berhasil membuat HP");
	}
}
