namespace Assignment6_2_1
{
    internal class Program
    {
        //Write a C# program to implement a stack by using array with push and pop operations
        static void Main(string[] args)
        {
            CustomStack customStack = new CustomStack();
            customStack.PrintStack();
            customStack.Push(3);
            customStack.Push(4);
            customStack.PrintStack();
            customStack.Push(0);
            customStack.Push(1);
            customStack.Push(10);
            customStack.PrintStack();
            Console.WriteLine($"Popped Element: { customStack.Pop() }");
            customStack.PrintStack();
            Console.WriteLine($"Popped Element: { customStack.Pop() }");
            customStack.PrintStack();
        }


    }

    public class CustomStack
    {
        int[] Stack = new int[100];
        int count = -1; //Last index in the stack

        // Replaces "last index" with 0 and returns the elem on said index, decrement count to save end of stack
        public int Pop()
        {
            int retVar = -1;
            if (count >= 0)
            {
                retVar = Stack[count];
                Stack[count] = 0;
                count--;
                
            }
            else
            {
                Console.WriteLine("Empty Stack");
            }
            return retVar;
        }

        //Pushes num to last index, increment count to save end of stack
        public void Push(int num)
        {
            Stack[count + 1] = num;
            count++;
        }

        public void PrintStack()
        {
            Console.WriteLine();
            Console.WriteLine("<=================PRINT START=================>");
            for (int i = 0; i < count + 1; i++)
            {
                Console.WriteLine($"Index: {i}   Element: { Stack[i] }");
            }
            Console.WriteLine();
        }
    }
}
