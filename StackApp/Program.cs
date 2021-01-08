using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4;
namespace StackApp
{
    class Program
    {
        static  Stack <int> Copy (Stack <int>s)
            {
            //at the end of the method it will perform copy from s to new Stack-no changes at end to the existing Stack
            throw new NotImplementedException();
        }
        static void Spill (Stack <int> destStack, Stack <int> sourceStack)
        {
            // copy source stack into dest_stack
        }
        static int GetBiggest (Stack<int> s)
        {
            // finds the largest number in stack without removing
            throw new NotImplementedException();
        }
        static int Sum (Stack <int> p)
        {
            // sum all the values in the stack
            throw new NotImplementedException();
        }
        static void Print (Stack<int> s)
        {
            // prints all the values without ruining the stack

        }
        static Stack <int> RemoveToNewStackEvenNumbers (Stack <int> s)
        {
            //removes even numbers and puts in new stack. Method returns new stack
            throw new NotImplementedException();
        }
        static Stack <int> Gather (Stack <int> s)
        {
            //gathers same numbers and adds them and saves in new stack. if has only one, doesn't add the value to stack
            // example [3,3,3,4,5,5,1,1,1,1] => [9, 10,4]
            throw new NotImplementedException();
        }
        static Stack <int> Merge (Stack<int> s1, Stack<int> s2)
        {
            // merge two ordered stacks 
            throw new NotImplementedException();
        }
        static bool AllDifferent (Stack <int> s)
        {
            // checks and returns true if all the numbers are different
            throw new NotImplementedException();
        }
        static Stack<int> MakeStack(int count)
        {
            Stack<int> stack = new Stack<int>();
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
                stack.Push(rnd.Next(40) + 1);
            return stack;
        }
        static void Main(string[] args)
        {
            Stack<int> st = MakeStack(10);
        }
    }
}
