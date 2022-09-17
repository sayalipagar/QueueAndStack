namespace StackAndQueueProgramm
{
    internal class Program
    {
        static void Main(string[] args)
            {
                bool flag = true;
                while (flag)
                {
                Console.WriteLine("\n\n Select Your Choice \n 1.PushElement\n 2.PeakElement ");
                int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                    case 1:
                        Stack stack = new Stack();
                        stack.Push(56);
                        stack.Push(30);
                        stack.Push(70);
                        break;
                    case 2:
                        Stack stack1 = new Stack();
                        stack1.Push(56);
                        stack1.Push(30);
                        stack1.Push(40);
                        stack1.Push(70);
                        stack1.Peek();
                       break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                    }
                }
            }
        }
    }
