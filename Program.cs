using System;
using System.ComponentModel.DataAnnotations;

namespace json_parser_LukeBeirne
{
    class Program
    {
        static void Main(string[] args)
        {            
            Address a = new() {Street="Main",Number=120,City="Conway", Zip="29528"};
            Person p = new() {Name="Mary", Id="123"};

            string jsonStr= MyJsonParser.Parse(a);
            Console.WriteLine(jsonStr);

            string jsonStr2= MyJsonParser.Parse(p);
            Console.WriteLine(jsonStr2);
        }
    }
}
