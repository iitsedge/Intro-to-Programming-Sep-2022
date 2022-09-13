// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your Goal for today:");
Console.WriteLine("---------------------------------");
string? goal = Console.ReadLine();
Console.WriteLine($"\n[For {DateTime.Now.ToString("dddd, MMMM dd, yyyy")} Your Goal Is:]");
Console.WriteLine($"\n\"{goal}\"");
Console.Write("\n[Save Changes (Y/n)] ");
char? answer = Console.ReadLine()[0];
