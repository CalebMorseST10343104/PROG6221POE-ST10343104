namespace CyberSecurityChatBot;

public static class Bot
{

    public static void Run()
    {
        Greeter.GreetUser();

        Console.WriteLine("Bot finishes running");
    }

}

internal class Input
{
    public string GetInput()
    {
        // Validate against null inputs
        string input = Console.ReadLine() ?? string.Empty;
        Console.WriteLine($"User input: {input}");
        return input;
    }
}

internal class Output
{
    public void DisplayMenu() 
    {
        DisplayMenu("general");
    }

    public void DisplayMenu(string option)
    {
        Console.WriteLine($"Displaying menu for {option}");
    }
}