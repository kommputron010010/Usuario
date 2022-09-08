internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hola Usuario!!");
        double altura = 1.65;
        int edad = 51;
        string nombre = "Adria&Martin3z";
        string alias = "Kommputron";
        string information = "La informacion solicitada es ..." + "\nNombre :" + nombre +
            "\nAlias :"+alias+"\nEdad=" + edad +"-años"+ "\nAltura=" + altura+"-metros";

        Console.WriteLine(information);
    }
}