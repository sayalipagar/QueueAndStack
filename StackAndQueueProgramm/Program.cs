namespace StackAndQueueProgramm
{
    internal class Program
    {
        static void Main(string[] args)
            {
                bool flag = true;
                while (flag)
                {
                Console.WriteLine("\n Select Your Choice: 1.PushElement ");
                int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("----------------------------------\n");
                            Stack stack = new Stack();
                            stack.Push(56);
                            stack.Push(30);
                            stack.Push(70);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                    }
                }
            }
        }
    }
