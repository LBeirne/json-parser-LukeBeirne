using System;
using System.Reflection;

namespace json_parser_LukeBeirne
{
    class MyJsonParser
    {
        public static string Parse(object input) {
            string output = "{";
            bool foundJson = false;
            
            PropertyInfo[] pi = input.GetType().GetProperties();
            foreach(PropertyInfo p in pi) {
                object[] attributes = p.GetCustomAttributes(true);

                foreach(object o in attributes) {
                    if(o is NoJson) {
                        foundJson = true;
                    }
                }

                //if the NoJson attribute is found on a property, its Name and associated
                //value will not be appended to the output string
                if(!foundJson) {
                    output += $"“{p.Name}”:“{p.GetValue(input)}”,";
                }
            }

            output = output.Remove(output.Length - 1); //remove last comma for readability
            output += "}";
            return output;
        }
    }

    public class NoJson : Attribute
    {
    }
}
