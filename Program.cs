using rpg_console_c_sharp.src.Entities;

class Program {
    public static void Main(string[] args) {
        Kinight aurus = new Kinight("Aurus", 49, "Cavaleiro");
        Wizard jenica = new Wizard("Jenica", 18, "Mago Branco");
        Wizard topapa = new Wizard("Topapa", 21, "Mago Negro");
        Ninja wedge = new Ninja("Wedge", 34, "Ninja");

        Console.WriteLine(aurus);
        Console.WriteLine(aurus.Attack(12));
        Console.WriteLine(aurus.Attack());
        Console.WriteLine(jenica);
        Console.WriteLine(jenica.Attack(50));
        Console.WriteLine(jenica.Attack());
        Console.WriteLine(topapa);
        Console.WriteLine(topapa.Attack(8));
        Console.WriteLine(topapa.Attack());
        Console.WriteLine(wedge);
        Console.WriteLine(wedge.Attack(10));
        Console.WriteLine(wedge.Attack());
    }
}