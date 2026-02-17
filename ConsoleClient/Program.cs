// See https://aka.ms/new-console-template for more information

internal class Program
{
    
    public static void Main(string[] args)
    {
        var displayCommands = new PersonDisplayCommands();
        
        displayCommands.DisplayAllAdults();
        displayCommands.DisplayAllChildren();
    }
}