using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Welcome to .Net tutorial.list of topics include:");//Append
            sb.Remove(25, 7);//Remove
            sb.AppendLine();//AppendLine
            sb.Append("C#.Net, ASP.Net, ADO.Net, MVC").AppendLine();
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
