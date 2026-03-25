namespace _11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine(MaxProfit(prices));
            int[] prices2 = new int[] { 7, 6, 4, 3, 1 };
            Console.WriteLine(MaxProfit(prices2));
            Console.WriteLine();

            //Question 2
            NodeLL list = new NodeLL();
            list.AddNode(1);
            list.AddNode(2);
            list.AddNode(3);
            list.AddNode(4);
            list.AddNode(5);

            list.DisplayList();
            list.ReverseLL();
            list.DisplayList();
            
        }

        //Question1
        public static int MaxProfit(int[] prices)
        {
            int cheapest = prices[0];
            int bestProfit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < cheapest)
                {
                    cheapest = prices[i];
                }
                else
                {
                    int profit = prices[i] - cheapest;
                    if (profit > bestProfit)
                    {
                        bestProfit = profit;
                    }
                }
            }
            return bestProfit;
        }

        //Question2
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
            }
        }

        public class NodeLL
        {
            public Node tail;
            public Node head;
            public void AddNode(int data)
            {
                Node newNode = new Node(data);
                if (head == null)
                {
                    head = newNode;
                    tail = newNode;
                }
                else
                {
                    tail.next = newNode;
                    tail = newNode;
                }
            }
            public void DisplayList()
            {
                Node current = head;
                while (current != null)
                {

                    Console.Write(current.data + " ");
                    current = current.next;
                }
                Console.WriteLine();
            }
            public void ReverseLL()
            {
                Node prev = null;
                Node current = head;
                tail = head;
                while (current != null)
                {
                    Node next = current.next;
                    current.next = prev;
                    prev = current;
                    current = next;
                }
                head = prev;
                Console.WriteLine();
            }
        }
    }
}
