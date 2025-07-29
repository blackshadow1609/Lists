using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Тестовый стек:");
			var stack = new LinkedListStack<int>();
			stack.Push(1);
			stack.Push(2);
			stack.Push(3);

			Console.WriteLine(stack.Pop()); 
			Console.WriteLine(stack.Peek()); 
			stack.Push(4);
			Console.WriteLine(stack.Pop()); 
			Console.WriteLine(stack.IsEmpty()); 

			Console.WriteLine("\nОчередь тестирования:");
			var queue = new DoublyLinkedListQueue<string>();
			queue.Enqueue("первый");
			queue.Enqueue("второй");
			queue.Enqueue("третий");

			Console.WriteLine(queue.Dequeue()); 
			Console.WriteLine(queue.Peek()); 
			queue.Enqueue("четвертый");
			Console.WriteLine(queue.Dequeue()); 
			Console.WriteLine(queue.IsEmpty()); 
		}
	}
}
