using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
	public class StackNode<T>
	{
		public T Data { get; set; }
		public StackNode<T> Next { get; set; }

		public StackNode(T data)
		{
			Data = data;
			Next = null;
		}
	}

	public class LinkedListStack<T>
	{
		private StackNode<T> top;
		public int Count { get; private set; }

		public LinkedListStack()
		{
			top = null;
			Count = 0;
		}

		public void Push(T item)
		{
			StackNode<T> newNode = new StackNode<T>(item);
			newNode.Next = top;
			top = newNode;
			Count++;
		}

		public T Pop()
		{
			if (IsEmpty())
			{
				throw new InvalidOperationException("Стек пуст");
			}

			T item = top.Data;
			top = top.Next;
			Count--;
			return item;
		}

		public T Peek()
		{
			if (IsEmpty())
			{
				throw new InvalidOperationException("Стек пуст");
			}

			return top.Data;
		}

		public bool IsEmpty()
		{
			return top == null;
		}

		public void Clear()
		{
			top = null;
			Count = 0;
		}
	}
}
