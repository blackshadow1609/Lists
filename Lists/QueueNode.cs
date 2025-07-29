using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
	public class QueueNode<T>
	{
		public T Data { get; set; }
		public QueueNode<T> Next { get; set; }
		public QueueNode<T> Previous { get; set; }

		public QueueNode(T data)
		{
			Data = data;
			Next = null;
			Previous = null;
		}
	}

	public class DoublyLinkedListQueue<T>
	{
		private QueueNode<T> front;
		private QueueNode<T> rear;
		public int Count { get; private set; }

		public DoublyLinkedListQueue()
		{
			front = null;
			rear = null;
			Count = 0;
		}

		public void Enqueue(T item)
		{
			QueueNode<T> newNode = new QueueNode<T>(item);

			if (rear == null)
			{
				front = rear = newNode;
			}
			else
			{
				newNode.Previous = rear;
				rear.Next = newNode;
				rear = newNode;
			}

			Count++;
		}

		public T Dequeue()
		{
			if (IsEmpty())
			{
				throw new InvalidOperationException("Очередь пуста");
			}

			T item = front.Data;
			front = front.Next;

			if (front == null)
			{
				rear = null;
			}
			else
			{
				front.Previous = null;
			}

			Count--;
			return item;
		}

		public T Peek()
		{
			if (IsEmpty())
			{
				throw new InvalidOperationException("Очередь пуста");
			}

			return front.Data;
		}

		public bool IsEmpty()
		{
			return front == null;
		}

		public void Clear()
		{
			front = null;
			rear = null;
			Count = 0;
		}
	}
}
