namespace prog6test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program to copy the contents of one file to another file and encrypt the new file. Have any rule to differentiate the contents along with the encryption. 

            File.Copy("C:\\Users\\poojitha.devaki\\file1.txt", "C:\\Users\\poojitha.devaki\\file2.txt");
                Console.WriteLine(File.ReadAllText("file2.txt"));
        }
    }
}