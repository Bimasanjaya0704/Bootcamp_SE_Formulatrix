namespace Delegates;

public class Program
{
	static void Main()
	{
		Youtuber youtuber = new Youtuber();
		Notifications notifications = new Notifications();

		youtuber.subscriber += notifications.ShowNotification;
		youtuber.UploadVideo();
		youtuber.subscriber += notifications.ShowNotification;
		youtuber.subscriber = notifications.ShowNotification;

	}

}