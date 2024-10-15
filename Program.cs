namespace _4labs
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ComputerBuilder builder = new ComputerBuilder();
            Computer computer = builder
                .SetCPU("Intel Core i512600f")
                .SetMotherboard("Gigabyte b750m")
                .SetRAM(16)
                .SetHDD(2000)
                .SetGPU("NVIDIA GeForce RTX 4070")
                .Build();

            Console.WriteLine(computer.ToString());
        }
    }
}
