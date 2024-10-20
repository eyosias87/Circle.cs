namespace Circle.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Skapa två cirkelobjekt*/
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            /* Beräkna och skriv ut arean för båda cirklarna*/
            Console.WriteLine("Area av cirkel 1 (radie 5): " + string.Format("{0:0.0#}", circle1.GetArea()));
            Console.WriteLine("Area av cirkel 2 (radie 6): " + string.Format("{0:0.0#}", circle2.GetArea()));
            Console.WriteLine();

            /* Beräkna och skriv ut omkrets och volym för båda cirklarna*/
            Console.WriteLine("Omkrets av cirkel 1: " + string.Format("{0:0.0#}", circle1.GetCircumference()));
            Console.WriteLine("Volym av cirkel 1 (sfär): " + string.Format("{0:0.0#}", circle1.GetVolume()));
            Console.WriteLine();

            Console.WriteLine("Omkrets av cirkel 2: " + string.Format("{0:0.0#}", circle2.GetCircumference()));
            Console.WriteLine("Volym av cirkel 2 (sfär): " + string.Format("{0:0.0#}", circle2.GetVolume()));
            Console.WriteLine();

            /* Skapa ett triangelobjekt*/
            Triangle triangle = new Triangle(7, 21);

            /* Beräkna och skriv ut arean av triangeln*/
            Console.WriteLine("Area av triangel (bas 7, höjd 21): " + string.Format("{0:0.0#}", triangle.GetArea()));
            Console.WriteLine();
        }
    }

}
