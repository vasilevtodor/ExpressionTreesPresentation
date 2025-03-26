class Program
{
    static void Main(string[] args)
    {
        Func<string, string, string> getKitDescription = (primaryColor, secondaryColor) => $"Primary Color - {primaryColor}, Secondary Color - {secondaryColor}";
        
        Console.WriteLine("Bears FC Official Kits:");

        Console.WriteLine($"Home Kit: {getKitDescription("Blue", "White")}");
        Console.WriteLine($"Away Kit: {getKitDescription("White", "Blue")}");
        Console.WriteLine($"3rd Kit: {getKitDescription("Black", "Gold")}");
    }
}
