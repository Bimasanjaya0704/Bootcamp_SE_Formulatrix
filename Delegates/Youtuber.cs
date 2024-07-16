namespace Delegates;

public delegate void Subscriber(string text);
public class Youtuber
{
	public Subscriber subscriber;
	public void SentNotification(string title)
	{
		subscriber(title);
	}

	public void UploadVideo()
	{
		Console.WriteLine("Upload Video baru");
		SentNotification("Video Baru nih");
	}
}