namespace _2Lygis_Streams
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string content = File.ReadAllText("path.txt");

            File.WriteAllText("anotherPath.txt", content);

            Console.WriteLine(content);

            List<string> list = new List<string>() { "Labas rytas", "Labas vakaras" };

            File.WriteAllLines("Pasisveikinimas.txt", list);

            File.Copy("Pasisveikinimas.txt", "Hello.txt");



            Uzduotis2();
        }
        public static void Uzduotis2()
        {
          List<string> pasakosEilutes =  File.ReadLines("Pasaka.txt").ToList(); 

            foreach (string pasakosEil in pasakosEilutes)
            {
                Console.WriteLine(pasakosEil);
            }
        }
    }
}