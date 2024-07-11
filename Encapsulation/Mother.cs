namespace Parent;

public class Mother
{
	public string name;
	public int age;

	public Mother(string name, int age)
	{
		this.name = name;
		this.age = age;
	}
	private int _nik;
	public int GetNik()
	{
		return _nik;
	}

	public void SetNik(int newNik)
	{
		if (newNik > 0 && newNik <= 16)
		{
			_nik = newNik;
		}
	}
}
