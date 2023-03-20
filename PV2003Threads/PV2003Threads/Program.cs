namespace PV2003Threads
{
    using System.Collections.Concurrent;
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Cviceni 1
            Citac c = new Citac(0);
            Thread t = new Thread(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    c.Zvys();
                }
            }
            );

            Thread t2 = new Thread(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    c.Sniz();
                }
            }
            );
            t.Start();
            t2.Start();
            Console.WriteLine("Hodnota: " + c.Hodnota);
            #endregion

            #region Cviceni 2
            static void ListCisel(List<int> l)
            {
                Random r = new Random();
                for (int i = 0; i < 1000000; i++)
                {
                    l.Add(r.Next(100000)+1);
                }
            }

            List<int> list = new List<int>();

            Thread t3 = new Thread(() =>
            {
                ListCisel(list);
            }
            );

            Thread t4 = new Thread(() =>
            {
                ListCisel(list);
            }
            );

            t3.Start();
            t4.Start();
            t3.Join();
            t4.Join();

            Console.WriteLine("Cisla v listu: " + list.Count);
            #endregion

            #region Cviceni 3
            
            static void ListCisel2(ConcurrentBag<int> cbag)
            {
                Random r = new Random();
                for (int i = 0; i < 1000000; i++)
                {
                    
                    cbag.Add(r.Next(100000) + 1);
                }
            }

            ConcurrentBag<int> cb = new ConcurrentBag<int>();

            Thread t5 = new Thread(() =>
            {
                ListCisel2(cb);
            }
            );

            Thread t6 = new Thread(() =>
            {
                ListCisel2(cb);
            }
            );

            t5.Start();
            t6.Start();
            t5.Join();
            t6.Join();

            Console.WriteLine("Cisla v tasce: " + cb.Count);
            #endregion

            #region Cviceni 4
            //neni hotovy lol

            #endregion
        }
    }
}