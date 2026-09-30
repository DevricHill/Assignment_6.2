using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6._2
{
    internal class StackArray<T>
    {
        int top;
        T[] data;

        public StackArray(int size)
        {
            data = new T[size];
            top = -1;
        }

        public bool IsFull()
        {
            return top == data.Length;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public void Push(T value)
        {
            if (IsFull()) throw new InvalidOperationException("Stack is full!");
            
            data[++top] = value;
        }

        public T Pop() {
            if(IsEmpty()) throw new InvalidOperationException("Stack is empty!");
            
            T value = data[top];
            top--;
            return value;
        }

        public T Peek()
        {
            if (IsEmpty()) throw new InvalidOperationException("Stack is empty!");

            return data[top];
        }

        public void Display()
        {
            if (IsEmpty()) throw new InvalidOperationException("Stack is empty!");
            for (int i = top; i >= 0; i--) { Console.WriteLine($"{data[i]} "); }
            Console.WriteLine();
        }
    }
}
