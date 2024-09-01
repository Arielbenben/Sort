namespace BubleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Buble = [3, 1, 5, 2, 7, 4, 0];
            
            Console.WriteLine(string.Join(",", BubleSort(Buble)));

            
            Console.WriteLine(string.Join(",", SelectionSort(Buble)));

        }


        public static List<int> BubleSort(List<int> list)
        {
            int count = list.Count;
            for (int i = 0; i < list.Count; i++)
            {
                for(int j = 0; j < count - 1 ; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int change = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = change;
                    }
                }
                count--;
            }
            return list;
        }

        public static List<int> SelectionSort(List<int> list)
        {
            int min = list[0];

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i; j < list.Count - 1 ; j++)
                {
                    if (list[j] < min)
                        min = list[j];
                }
            }
            return list;
        }
    }
}
