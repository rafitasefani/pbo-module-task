using System;

class Processor
{
    public string Merk { get; set; }

    public string Tipe { get; set; }

    public Processor(string merk, string tipe)
    {
        this.Merk = merk;
        this.Tipe = tipe;
    }
}

class Intel : Processor
{
    public Intel(string tipe) : base("Intel", tipe) { }
}

class CoreI3 : Intel
{
    public CoreI3() : base("Core i3") { }
}

class CoreI5 : Intel
{
    public CoreI5() : base("Core i5") { }
}

class CoreI7 : Intel
{
    public CoreI7() : base("Core i7") { }
}

class AMD : Processor
{
    public AMD(string tipe) : base("AMD", tipe) { }
}

class Ryzen : AMD
{
    public Ryzen() : base("Ryzen") { }
}

class Athlon : AMD
{
    public Athlon() : base("Athlon") { }
}

class VGA
{
    public string Merk { get; set; }

    public VGA(string merk)
    {
        this.Merk = merk;
    }
}

class Nvidia : VGA
{
    public Nvidia() : base("Nvidia") { }
}

class Radeon : VGA
{
    public Radeon() : base("Radeon") { }
}


class Laptop
{
    public string Merk { get; set; }
    public string Tipe { get; set; }
    public VGA Vga { get; set; }
    public Processor Processor { get; set; }

    public Laptop(string merk, string tipe, VGA vga, Processor processor)
    {
        this.Merk = merk;
        this.Tipe = tipe;
        this.Vga = vga;
        this.Processor = processor;
    }

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} menyala");
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} mati");
    }
}


class Asus : Laptop
{
    public Asus(string tipe, VGA vga, Processor processor) : base("Asus", tipe, vga, processor) { }
}

class ROG : Asus
{
    public ROG(VGA vga, Processor processor) : base("ROG", vga, processor) { }
}

class VivoBook : Asus
{
    public VivoBook(VGA vga, Processor processor) : base("VivoBook", vga, processor) { }

    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

class Acer : Laptop
{
    public Acer(string tipe, VGA vga, Processor processor) : base("Acer", tipe, vga, processor) { }
}

class Swift : Acer
{
    public Swift(VGA vga, Processor processor) : base("Swift", vga, processor) { }
}

class Predator : Acer
{
    public Predator(VGA vga, Processor processor) : base("Predator", vga, processor) { }

    public void BermainGame()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} sedang memainkan game");
    }
}

class Lenovo : Laptop
{
    public Lenovo(string tipe, VGA vga, Processor processor) : base("Lenovo", tipe, vga, processor) { }
}

class IdeaPad : Lenovo
{
    public IdeaPad(VGA vga, Processor processor) : base("IdeaPad", vga, processor) { }
}

class Legion : Lenovo
{
    public Legion(VGA vga, Processor processor) : base("Legion", vga, processor) { }
}

// main program
class Program
{
    static void Main(string[] args)
    {
        // Soal 1
        Laptop laptop2;
        laptop2 = new IdeaPad(new Radeon(), new Ryzen());
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();

        // Soal 2
        Laptop laptop1;
        laptop1 = new VivoBook(new Nvidia(), new CoreI5());
        // laptop1.Ngoding(); error 
        ((VivoBook)laptop1).Ngoding();

        // Soal 3
        Console.WriteLine($"Tipe Laptop: {laptop1.Tipe}");
        Console.WriteLine($"Merk Laptop: {laptop1.Merk}");
        Console.WriteLine($"Merk VGA: {laptop1.Vga.Merk}");
        Console.WriteLine($"Merk Processor: {laptop1.Processor.Merk}");
        Console.WriteLine($"Tipe Processor: {laptop1.Processor.Tipe}");

        // Soal 4
        Predator predator;
        predator = new Predator(new Radeon(), new CoreI7());
        predator.BermainGame();

        // Soal 5
        Acer acer;
        acer = new Predator(new Radeon(), new CoreI7());
        // acer.BermainGame(); error
        ((Predator)acer).BermainGame();
    }

}