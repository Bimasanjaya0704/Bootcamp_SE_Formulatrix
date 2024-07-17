public delegate void MyDelegates();
public class Publisher
{
	public event MyDelegates del;
	public void ResetSubs()
	{
		del = null;
	}
}
