class BearsFC
{
    public void HomeKit()
    {
        Console.WriteLine("Bears FC Home Kit: Blue with white stripes.");
    }

    public void AwayKit()
    {
        Console.WriteLine("Bears FC Away Kit: White with blue trims.");
    }

    public void ThirdKit()
    {
        Console.WriteLine("Bears FC 3rd Kit: Black with gold accents.");
    }
}

public delegate void KitAction();

class Program
{
    static void Main()
    {
        BearsFC bears = new();

        // Create delegate instances
        KitAction homeKit = new(bears.HomeKit);
        KitAction awayKit = new(bears.AwayKit);
        KitAction thirdKit = new(bears.ThirdKit);

        // Multicast delegate example (show all kits)
        KitAction allKits = homeKit + awayKit + thirdKit;

        Console.WriteLine("Bears FC Official Kits:");
        allKits();

        // Optionally, you can call individual kits
        Console.WriteLine("\nDisplaying Away Kit Only:");
        awayKit();
    }
}
