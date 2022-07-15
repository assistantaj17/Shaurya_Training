using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaurya_Training.Collection.Generic
{
    internal class DemoDictionary
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> NumName = new Dictionary<int, string>();
            NumName.Add(1, "One");  // adding element by add method;
            NumName.Add(2, "Two");
            NumName.Add(3, "Three");
            NumName.Add(4, "Four");

            foreach(KeyValuePair<int,string> kv in NumName)
                Console.WriteLine(kv.Key+"   "+kv.Value); // print the key and value 

            var cities = new Dictionary<string, string>() {   // Adding element directly
                {"UK","London,Manchester,Berlin" },
                {"USA","Chicago,New York,Washington" },
                {"INDIA","Mumbai,New Delhi,Pune" }
            };
            foreach(KeyValuePair<string,string> kv in cities)
                Console.WriteLine(kv.Key+" =====> "+kv.Value);
            Console.WriteLine(cities["UK"]); // Print value of UK key
            Console.WriteLine(cities["INDIA"]);// print value of India key
            //Console.WriteLine(cities["France"]);// run time exception key does not exist

            // TryGetValue() to get value of unknown key
            string result;
            if(cities.TryGetValue("INDIA",out result))
            {
                Console.WriteLine(result);
            }
            // use ElementAt() to retrive key-value pair using index
            for(int i=0;i<cities.Count;i++)
                Console.WriteLine("Key:{0},Value:{1}",cities.ElementAt(i).Key,cities.ElementAt(i).Value);

            cities["UK"] = "Liverpool,Bristen"; //Update value of UK Key
            cities["USA"] = "Los Angels,Boston"; // Update value of USA Key
            for(int i=0;i<cities.Count;i++)
                Console.WriteLine("Key:{0},Value:{1}",cities.ElementAt(i).Key,cities.ElementAt(i).Value);

            cities.Remove("UK"); // Remove UK key value;
            //cities.Clear(); // Remove all Element
            foreach(KeyValuePair<string,string> kv in cities)
                Console.WriteLine(kv.Key+" =======> "+kv.Value);
        }
    }
}
