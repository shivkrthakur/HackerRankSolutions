using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    /*	author:@shivkrthakur  */
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int[] NK = Array.ConvertAll(Console.ReadLine().Split(), Int32.Parse);
        long[] N = Array.ConvertAll(Console.ReadLine().Split(), Int64.Parse);

        int n = NK[0], k = NK[1];
        //Console.WriteLine(string.Join(" ", N));
        MinHeap minHeap = new MinHeap(N);
        int count = 0;
        long curValue = minHeap.Pop();
        while (minHeap.Peek() > -1 && curValue < k)
        {
            long nextVal = minHeap.Pop();
            minHeap.Push(curValue + 2 * nextVal);
            curValue = minHeap.Pop();
            count++;
        }
        Console.WriteLine(curValue >= k ? count : -1);
    }

    class MinHeap
    {
        int capacity;
        int size;
        long[] items;

        public MinHeap()
        {
            this.capacity = 10;
            this.size = 0;
            this.items = new long[capacity];
        }

        public MinHeap(int capacity)
        {
            this.capacity = capacity;
            this.size = 0;
            items = new long[capacity];
        }

        public MinHeap(long[] input)
        {
            this.capacity = input.Length;
            this.size = 0;
            items = new long[capacity];
            for (int i = 0; i < capacity; i++)
            {
                this.Push(input[i]);
                //Console.WriteLine(string.Join(" ",this.items));
            }
        }

        public int GetLeftChildIndex(int parentIndex)
        {
            int index = 2 * parentIndex + 1;
            return index;
        }

        public int GetRightChildIndex(int parentIndex)
        {
            int index = 2 * parentIndex + 2;
            return index;
        }

        public int GetParentIndex(int childIndex)
        {
            int index = (childIndex - 1) / 2;
            return index;
        }

        public bool HasLeftChild(int index)
        {
            return (GetLeftChildIndex(index) < size);
        }

        public bool HasRightChild(int index)
        {
            return GetRightChildIndex(index) < size;
        }

        public bool HasParent(int index)
        {
            return GetParentIndex(index) > -1;
        }

        public long LeftChild(int parentIndex)
        {
            int index = GetLeftChildIndex(parentIndex);
            return items[index];
        }

        public long RightChild(int parentIndex)
        {
            int index = GetRightChildIndex(parentIndex);
            return items[index];
        }

        public long Parent(int childIndex)
        {
            int index = GetParentIndex(childIndex);
            return items[index];
        }

        public void Swap(int indexOne, int indexTwo)
        {
            long tempValue = items[indexOne];
            items[indexOne] = items[indexTwo];
            items[indexTwo] = tempValue;
        }

        public void EnsureCapacity()
        {
            if (size == capacity)
            {
                capacity *= 2;
                Array.Copy(items, items, capacity);
            }
        }

        public long Peek()
        {
            if (!IsEmpty())
                return items[0];
            else return -1;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public long Pop()
        {
            if (!IsEmpty())
            {
                long item = items[0];
                items[0] = items[size - 1];
                size--;
                HeapifyDown();
                return item;
            }
            else return -1;
        }

        void HeapifyDown()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                int smallerChildIndex = GetLeftChildIndex(index);
                if (HasRightChild(index))
                    smallerChildIndex = RightChild(index) < LeftChild(index) ? GetRightChildIndex(index) : smallerChildIndex;
                if (items[index] < items[smallerChildIndex]) break;
                else Swap(smallerChildIndex, index);
                index = smallerChildIndex;
            }
        }

        public void Push(long item)
        {
            EnsureCapacity();
            items[size] = item;
            size++;
            HeapifyUp();
        }

        void HeapifyUp()
        {
            int index = size - 1;
            while (HasParent(index) && Parent(index) > items[index])
            {
                int parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }

        public long[] Items { get { return items; } }
    }

}