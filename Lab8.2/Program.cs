using System;
using System.IO;

namespace Lab8._2
{
    class Class1
    {
        class Program
        {
            static int count = 0;
            public int[] text;
            public string[] st;
            public string b;

            static void Main(string[] args)
            {
                Program a = new Program();
                string s = "D://f.txt";

                if (!File.Exists(s))
                    File.Create(s);
                using (StreamWriter n = new StreamWriter(s))
                {

                    for (int i = 0; i < 20; i++)
                    {
                        n.Write(i + " ");
                    }

                }
                using (FileStream fs = new FileStream(s, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader r = new StreamReader(fs))
                    {
                        a.b = r.ReadToEnd();
                    }
                }

                a.st = a.b.Split(' ');
                a.text = new int[a.st.Length - 1];

                for (int i = 0; i < a.st.Length; i++)
                {
                    try
                    {
                        a.text[i] = Int32.Parse(a.st[i]);
                    }
                    catch { }
                }

                for (int i = 0; i < a.text.Length; i++)
                {
                    if (a.text[i] % 2 == 0)
                        count++;
                    if (i == (a.text.Length - 1))
                        Console.WriteLine("Парних: " + count);
                }
                count = 0;
                StreamReader f; StreamWriter wr;  
                try
                {
                    f = new StreamReader("D:\\f.txt");
                    // файл буде створюватися заново     
                    wr = new StreamWriter("D:\\g.txt");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message); return;
                }
                while ((s = f.ReadLine()) != null)
                    wr.WriteLine(s);
                wr.Close();
                f.Close();
            }


        }
    }

    }
