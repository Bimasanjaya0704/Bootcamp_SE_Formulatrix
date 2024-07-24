public class Program
{
    static void Main()
    {
        StatusChecker stats = new();
        Status status = Status.serverError;
        stats.CheckStatus(status);

        int resultInt = (int)Status.success;
        Console.WriteLine(resultInt);

        Status resultString = (Status)200;
        Console.WriteLine(resultString);

        string statsRedirect = Status.redirect.ToString();
        Console.WriteLine(statsRedirect);
    }
}

public enum Status
{
    success = 200,
    redirect = 300,
    clientError = 400,
    serverError = 500,
}

public class StatusChecker
{
    public void CheckStatus(Status status)
    {
        if (status == Status.success)
        {
            Console.WriteLine("Status 200 Success");
        }

        else if (status == Status.redirect)
        {
            Console.WriteLine("Status 300 Redirect");
        }
        else if (status == Status.clientError)
        {
            Console.WriteLine("Status 400 Client Error");
        }
        else if (status == Status.serverError)
        {
            Console.WriteLine("Status 500 Server Error");
        }
        else
        {
            Console.WriteLine("Status Not Found");
        }
    }
}