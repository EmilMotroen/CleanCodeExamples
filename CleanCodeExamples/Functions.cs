namespace CleanCodeExamples
{
    public class LinkedListDemo
    {
        Node head;

        int size = 0;
        int totalCapacity = 3;

        public LinkedListDemo() { }

        public void Add(int value)
        {
            IncrementSize();
            if (AtCapacity())
            {
                Grow();
            }

            AddElement(value);
        }

        private void AddElement(int value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                head = newNode;
                return;
            }

            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }

            current.next = newNode;
        }

        private void IncrementSize()
        {
            size++;
        }

        private bool AtCapacity()
        {
            return size == totalCapacity;
        }

        private void Grow()
        {
            totalCapacity++;
        }

        public void Print()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node current = head;
            while (current != null)
            {
                Console.Write($"{current.data} -> ");
                current = current.next;
            }

            Console.WriteLine("null");
        }

        public int GetSize()
        {
            return size;
        }

        public class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
                next = null;
            }
        }
    }
}
