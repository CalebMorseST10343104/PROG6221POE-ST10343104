using System;

namespace CyberSecurityChatBot;

public class Greeter
{
    //Responsible for greeting the user
    public required string UserName { get; set; }
    public static void GreetUser()
    {
        ImageDisplay imageDisplay = new();
        VoiceGreeting voiceGreeting = new();
        //Ask for the user's name
        Console.WriteLine("Hello! What is your name?");
        //Get the user's name
        string? input = Console.ReadLine();
        string userName = input ?? "User";
        //Greet the user by name with decorated border
        string message = $"Hello, {userName}! Welcome to the Cyber Security Chat Bot!";
        Console.WriteLine(new string('*', message.Length + 4));
        Console.WriteLine($"* {message} *");
        Console.WriteLine(new string('*', message.Length + 4));
    }
}

internal class ImageDisplay
{
    public ImageDisplay()
    {
        DisplayImage();
    }
    //Using ASCII art to display an image
    public void DisplayImage()
    {
        //Read ascii art from logo.txt file
        string asciiArt = System.IO.File.ReadAllText("logo.txt");
        Console.WriteLine(asciiArt);
    }
}

internal class VoiceGreeting
{
    public VoiceGreeting()
    {
        PlayVoiceGreeting();
    }
    //Using the OpenAL Library to play a voice greeting
    public void PlayVoiceGreeting()
    {
        Console.WriteLine("Voice greeting played here");
    }
}
