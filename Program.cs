using System.Text;

namespace Assignment7._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "ab";
            string b = "pqr";
            string c; 
            int l = Math.Min(a.Length, b.Length);
            StringBuilder sb = new StringBuilder();


            for (int i = 0;i<l; i++)
            {
                sb.Append(a[i]);
                sb.Append(b[i]);
            }
            if(a.Length>l)
            {
                for (int i = l; i<a.Length; i++)
                {
                    sb.Append(a[i]);
                }
            }
            if (b.Length > l)
            {
                for (int i = l; i < b.Length; i++)
                {
                    sb.Append(b[i]);
                }
            }
            c= sb.ToString();
            Console.WriteLine(c);
        }
    }
}
