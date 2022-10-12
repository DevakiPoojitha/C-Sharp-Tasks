﻿namespace prog8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your name");
            string name = Console.ReadLine();
            string fileName = @"C:\Users\poojitha.devaki\OneDrive - Entain Group\" + name + ".txt";
            try
            {
                StreamWriter sw = File.AppendText(fileName);

                sw.WriteLine("The first line has been added");
                sw.WriteLine("Second line");
                sw.WriteLine("Third Line");
                sw.WriteLine("fourth line has been added");
                sw.WriteLine("The fifth line has been added");
                
                sw.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    sr.Close();
                }
            }



            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Enter the text you wanna replaced");
            string OldText = Console.ReadLine();



            Console.WriteLine("Enter the text you want in the file");
            string NewText = Console.ReadLine();



            string text = File.ReadAllText(fileName);
            text = text.Replace(OldText, NewText);
            File.WriteAllText(fileName, text);
            Console.ReadKey();




        }
    }
}