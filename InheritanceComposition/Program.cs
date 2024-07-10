using FixHp;
using ItemHp;

class Program
{
	static void Main()
	{
		Camera camera = new Camera("Sonny", 100000, 720);
		Storage storage = new Storage("V-Gen", 20000, 256);
		Console.WriteLine("Hasil adalah {0}, {1}, {2}", storage.brand, storage.price, storage.size);

		Hp hp = new Hp(camera, storage);
		int size = 128;
		hp.storage.ReplaceSize(size);
		Console.WriteLine("Hasil adalah {0}, {1}, {2}", storage.brand, storage.price, storage.size);
	}
}