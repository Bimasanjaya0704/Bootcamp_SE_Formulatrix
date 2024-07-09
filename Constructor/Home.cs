namespace Constructor;

class Home
{
    public int window;
    public int door;
    public string color;
    public string address;
    public Home(int window, int door, string color, string address)
    {
        this.window = window;
        this.door = door;
        this.color = color;
        this.address = address;
        Console.WriteLine($"Home Created : {window} window, {door} door, {color} color, address {address}");
    }
    public Home(string color, string address)
    {
        this.color = color;
        this.address = address;
        Console.WriteLine($"Home Created : {color}, {address}");
    }
    public Home()
    {
        Console.WriteLine("Home created");
    }
}
