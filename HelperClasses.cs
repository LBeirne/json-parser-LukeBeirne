using System;

namespace json_parser_LukeBeirne
{
    public class Address {
        public string Street  {get;set;}
        public int Number {get;set;}
        public string City {get;set;}
        [NoJson]
        public string Zip {get;set;} 
    }
    
    public class Person {
        public string Name {get;set;}
        public string Id {get;set;}
    }
}
