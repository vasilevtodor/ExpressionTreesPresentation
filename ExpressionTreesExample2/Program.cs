public delegate void KitAction(string primaryColor, string secondaryColor);

class Program
{
    static void Main(string[] args)
    {
        // Anonymous delegate for Home Kit
        KitAction homeKit = delegate (string primary, string secondary)
        {
            Console.WriteLine($"Bears FC Home Kit: Primary Color - {primary}, Secondary Color - {secondary}");
        };

        // Anonymous delegate for Away Kit
        KitAction awayKit = delegate (string primary, string secondary)
        {
            Console.WriteLine($"Bears FC Away Kit: Primary Color - {primary}, Secondary Color - {secondary}");
        };

        // Anonymous delegate for 3rd Kit
        KitAction thirdKit = delegate (string primary, string secondary)
        {
            Console.WriteLine($"Bears FC 3rd Kit: Primary Color - {primary}, Secondary Color - {secondary}");
        };

        Console.WriteLine("Bears FC Official Kits:");

        // Call each kit with different color combinations
        homeKit("Blue", "White");
        awayKit("White", "Blue");
        thirdKit("Black", "Gold");
    }
}

