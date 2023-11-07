public class Write
{
    public string _date;
    public string _prompt;
    public string _response;

    public string _instanceName;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_response);
    }
}