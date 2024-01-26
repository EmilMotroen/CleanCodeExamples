using System.Collections;

namespace CleanCodeExamples
{
    public class LinkedListDemo
    {
        Node head;

        int size = 0;
        public int totalCapacity = 3;

        readonly bool readOnly = false;

        public LinkedListDemo() { }

        public void Add(int value)
        {
            if (!ReadOnly())
            {
                IncrementSize();
                if (AtCapacity())
                {
                    Grow();
                }

                AddElement(value);
            }
        }

        private bool ReadOnly()
        {
            return readOnly;
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

        // -----------------------------------------------------------------------------------
        // Metoder fra side 23 i PowerPoint (side 18-19 i Clean Code boka) - minesweeper
        // Merk: Disse metodene er hentet fra PowerPoint og har ikke en full implementasjon
        // av et fungerende program
        int[] theList = [1, 2, 3, 4, 5];
        public List<int> GetThem()
        {
            List<int> list1 = new List<int>();
            for (int i = 0; i < theList.Length; i++)
            {
                if (theList[i] == 4)
                {
                    list1.Add(theList[i]);
                }
            }

            return list1;
        }

        // 3x3 minesweeper der 1 representerer der det er et flagg, 0 er uten flagg
        Cell[] gameBoard = [
            new Cell(0), new Cell(0), new Cell(0),
            new Cell(0), new Cell(1), new Cell(0),
            new Cell(0), new Cell(0), new Cell(0)
            ];

        public List<Cell> GetFlaggedCells()
        {
            List<Cell> flaggedCells = new List<Cell>();
            foreach (Cell cell in gameBoard)
            {
                if (cell.IsFlagged())
                {
                    flaggedCells.Add(cell);
                }
            }

            return flaggedCells;
        }

        // 
        public class Cell
        {
            int flag;

            public Cell(int flag)
            {
                this.flag = flag;
            }

            public bool IsFlagged()
            {
                if (flag == 1)
                {
                    return true;
                }

                return false;
            }
        }
    }
}
