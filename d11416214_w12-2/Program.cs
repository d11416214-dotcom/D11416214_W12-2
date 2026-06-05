namespace d11416214_w12_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IName n1;
            string input=Console.ReadLine();
            if (input == "1")
            {
                n1=new Student();
            }
            else
            {
                n1=new Teacher();
            }
            Console.WriteLine(n1.GetName());
        }
    }
}
