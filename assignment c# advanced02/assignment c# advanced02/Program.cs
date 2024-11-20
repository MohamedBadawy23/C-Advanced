namespace assignment_c__advanced02
{
    internal class Program
    {

        //public static int SummArraylist(ArrayList arrayList)
        //{
        //    int sum = 0;
        //    if(arrayList!=null)
        //    {
        //        for(int i = 0; i < arrayList.Count; i++)
        //        {
        //            sum += (int)arrayList[i];
        //        }

        //    }
        //    return sum;
        //}
        //public static int Summlist(List<int> list)
        //{
        //    int sum = 0;
        //    if (list != null)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            sum += (int)list[i];
        //        }

        //    }
        //    return sum;
        //}
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            #region DEMO
            //---------------------------------------
            #region ArrayList
            //-------------------------------------------
            ////ArrayList arrayList = new ArrayList();
            ////arrayList.Add(1);
            ////arrayList.Add(2);
            ////arrayList.Add(3);
            ////arrayList.Add(4);
            ////arrayList.Add(5);
            //////Console.WriteLine($"The Capacity of array:{arrayList.Capacity}");
            //////Console.WriteLine($"The Count of array:{arrayList.Count}");
            ////arrayList.AddRange(new int[] { 7, 8, 9 });
            ////Console.WriteLine($"The Capacity of array:{arrayList.Capacity}");
            ////Console.WriteLine($"The Count of array:{arrayList.Count}");
            //ArrayList arrayList02 = new ArrayList(5) { 1, 2, 3, 4, 5 };
            ////Console.WriteLine($"The Capacity of array:{arrayList02.Capacity}");
            ////Console.WriteLine($"The Count of array:{arrayList02.Count}");
            //arrayList02.Add(6);
            ////Console.WriteLine("After 6the Element");
            ////Console.WriteLine($"The Capacity of array:{arrayList02.Capacity}");
            ////Console.WriteLine($"The Count of array:{arrayList02.Count}");
            ////arrayList02.TrimToSize();
            ////Console.WriteLine("After TrimTosize");
            ////Console.WriteLine($"The Capacity of array:{arrayList02.Capacity}");
            ////Console.WriteLine($"The Count of array:{arrayList02.Count}");
            ////foreach(int Numbers in arrayList02)
            ////{
            ////    Console.WriteLine(Numbers);
            ////}
            //int summ = SummArraylist(arrayList02);
            //Console.WriteLine($"The Sum Of ArrayList:{summ}");
            #endregion
            #region List
            //------------------------------------
            //------------------------------------
            //List<int> Numbers = new List<int>();
            //Console.WriteLine($"Count Of list:{Numbers.Count}");//0
            //Console.WriteLine($"Capacity Of list:{Numbers.Capacity}");//0
            //Numbers.Add(1);
            //Console.WriteLine($"Count Of list:{Numbers.Count}");//1
            //Console.WriteLine($"Capacity Of list:{Numbers.Capacity}");//4
            //Numbers.AddRange(new int[] { 2, 3, 4 });
            //Console.WriteLine($"Count Of list:{Numbers.Count}");//4
            //Console.WriteLine($"Capacity Of list:{Numbers.Capacity}");//4
            //Numbers.Add(5);
            //Console.WriteLine("After Add 5The Element");
            //Console.WriteLine($"Count Of list:{Numbers.Count}");//5
            //Console.WriteLine($"Capacity Of list:{Numbers.Capacity}");//8
            //Numbers.TrimExcess();
            //Console.WriteLine($"Count Of list:{Numbers.Count}");//5
            //Console.WriteLine($"Capacity Of list:{Numbers.Capacity}");//5
            //foreach(int Num in Numbers)
            //{
            //    Console.WriteLine(Num);
            //}
            //Numbers[0] = 12345;//Indexer as setter
            //Numbers[9] = 100;//Invalid We Can Not use  indexr  to add element  
            //for(int i = 0; i < Numbers.Count; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            //List<int> list = new List<int>(5) { 1, 2, 3, 4, 5 };
            //int sum = Summlist(list);
            //Console.WriteLine(sum);
            #endregion
            #region LIst Methods
            //-------------------------------------
            //List<int> list = new List<int>(5) { 1, 2, 3, 4, 5 };
            //list.Add(6);
            //list.AddRange(new int[] { 7,8});
            //list.Insert(3, 2);
            //list.InsertRange(4, new int[] { 1, 2, 3 });
            //Console.WriteLine($"The Capacity Of lis:{list.Capacity}");
            //Console.WriteLine($"The Count Of lis:{list.Count}");
            //list.Clear();
            //list.BinarySearch(3);
            //list.Contains(9);
            //list.EnsureCapacity(4);
            //list.IndexOf(5);
            //list.LastIndexOf(4);


            #endregion
            #region Linked List
            //------------------------------
            //LinkedList<int> linkedlist = new LinkedList<int>();
            //Console.WriteLine($"The Count Of linkedlist:{linkedlist.Count}");
            //linkedlist.AddFirst(1);
            //linkedlist.AddLast(3);
            //Console.WriteLine($"The Count Of linkedlist:{linkedlist.Count}");
            //linkedlist.AddAfter(linkedlist.Find(1), 2);
            //linkedlist.AddAfter(linkedlist.Find(2), 26);
            //linkedlist.AddBefore(linkedlist.Find(3), 5);
            //foreach (int Nu in linkedlist)
            //{
            //    Console.WriteLine(Nu);
            //}
            #endregion
            //----------------------------------------
            #region Stack
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop());

            #endregion
            //------------------------------------
            #region Queue
            //Queue<int> queu = new Queue<int>();
            //queu.Enqueue(1);
            //queu.Enqueue(2);
            //queu.Enqueue(3);
            //Console.WriteLine(queu.Peek());
            //Console.WriteLine(queu.Dequeue());

            #endregion
            //-------------------------------------
            #region HashTable[Dictionary]
            //Dictionary<string, int> phonebook = new Dictionary<string, int>();
            //phonebook.Add("Ahmed", 123);
            //phonebook.Add("Amr", 345);
            //phonebook.Add("Aya", 789);
            // phonebook.Add("Amr", 999);
            // phonebook.Add("Ahmed", 999);
            //phonebook["Ahmed"] = 999;
            //Console.WriteLine(phonebook["Ahmed"]);
            //phonebook["Mona"] = 333;
            //phonebook.Add("Mona",555 );
            //if (!phonebook.ContainsKey("Mona"))
            //{
            //    phonebook.Add("Mona", 2222);
            //}
            //else
            //{
            //    phonebook["Mona"] = 333;//Update
            //}
            // if (!phonebook.TryAdd("Mona", 333)) ;
            //phonebook["Mona"] = 111;
            ////phonebook.TryAdd("Mona", 555);
            //Console.WriteLine(phonebook["Yasmin"]);
            //int n=0;
            //phonebook.TryGetValue("Yasmin",out n);
            //Console.WriteLine(n);



            //foreach (KeyValuePair<string, int> item in phonebook)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion
            //----------------------------
            #region HashSet
            //HashSet<int> set = new HashSet<int>();
            //set.Add(1);
            //set.Add(2);
            //foreach(int var in set)
            //{
            //    Console.WriteLine(var);
            //}
            #endregion
            #region Delegate
            //int X = 3;
            //StringFuncDelegate delgatee;
            // delgatee = new StringFuncDelegate(StringFunction.Upper);
            //delgatee += new StringFuncDelegate(StringFunction.Lower);
            ////  delgatee = new StringFunction.Upper;//Syntax sugar
            //int Result = delgatee.Invoke("Nader Rahoumah");
            //Console.WriteLine(Result);
            ////StringFuncDelegate stringFuncDelegate;
            ////stringFuncDelegate = new StringFuncDelegate(StringFunction.Lower);
            ////int Result02 = stringFuncDelegate.Invoke("Ahmed Ibrahim");
            ////Console.WriteLine(Result02);
            #endregion
            //-------------------------------------------


            #endregion

        }
    }
}
