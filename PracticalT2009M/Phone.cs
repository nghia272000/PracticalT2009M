using System;

namespace PracticalT2009M
{
    public class Phone
    {
        public string PhoneName { get; set; }
        public string PhoneType { get; set; }
        public float PhonePrice { get; set; }

        public void display()
        {
            Console.WriteLine($"Phone {PhoneName},type {PhoneType}, Price {PhonePrice}");
        }
        
    }
}