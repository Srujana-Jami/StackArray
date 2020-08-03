using System;

namespace StackArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, x;

            StackA st = new StackA(8);

            while (true)
            {
                Console.WriteLine("1.Push an element on the stack ");
                Console.WriteLine("2.Pop an element from the stack ");
                Console.WriteLine("3.Display the top element: ");
                Console.WriteLine("4.Display the stack elements: ");
                Console.WriteLine("5.Display the size of the stack ");
                Console.WriteLine("6.Quit");
                Console.Write("enter the choice ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 6)
                    break;

                switch (choice)
                {
                    case 1:
                        Console.Write("enter the elements to be pushed ");
                        x = Convert.ToInt32(Console.ReadLine());
                        st.Push(x);
                        break;
                    case 2:
                        x = st.Pop();
                        Console.WriteLine("Popped element is :" + x);
                        break;
                    case 3:
                        Console.WriteLine("Element at the top is : " + st.Peek());
                        break;
                    case 4:
                        st.Display();
                        break;
                    case 5:
                        Console.WriteLine("size of stack " + st.Size());
                        break;
                    default:
                        Console.WriteLine("Wrong choice ");
                        break;

                }
               
                Console.WriteLine("");




            }
        }
    }
}
