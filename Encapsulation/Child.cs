using Parent;

namespace Baby;

public class Child : Mother
{
	public string hobby;
	private bool _isCry;

	public Child(string name, int age, string hobby, bool _isCry) : base(name, age)
	{
		this.hobby = hobby;
		this._isCry = _isCry;
	}

	public void SetCry(bool setCry)
	{
		_isCry = setCry;
	}

	public void GetMother()
	{
		Mother mother = new Mother("ana", 12);
		mother.SetNik(332211);
		mother.GetNik();
		Console.WriteLine("Mother name = " + mother.name);
		Console.WriteLine("Mother age = " + mother.age);
		Console.WriteLine("Mother nik = " + mother.GetNik());
	}
}
