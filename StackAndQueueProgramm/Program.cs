namespace StackAndQueueProgramm
{
    internal class Program
    {
        static void Main(string[] args)
            {
                bool flag = true;
                while (flag)
                {
                Console.WriteLine("\n\n Select Your Choice \n 1.PushElement\n 2.PeakElement\n 3.PopElement\n 4.InsertElementInQueue\n 5.DeleteElement in Queue ");
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
                    case 3:
                        Stack list = new Stack();
                        list.Push(56);
                        list.Push(30);
                        list.Push(40);
                        list.Push(70);
                        list.Pop();
                        list.Display();
                        break;
                    case 4:
                        Queue listQueue = new Queue();
                        listQueue.Enqueue(56);
                        listQueue.Enqueue(30);
                        listQueue.Enqueue(70);
                        break;
                    case 5:
                        Queue queue = new Queue();
                        queue.Enqueue(56);
                        queue.Enqueue(30);
                        queue.Enqueue(70);
                        queue.Dequeue();
                        queue.Display();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                    }
                }
            }
        }
    }
