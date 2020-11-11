using System;
using System.Collections.Generic;

namespace GenericTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, string> myDictionary = new Dictionary<string, string>();

            myDictionary.Add("Tom Lee", "Training");
            myDictionary.Add("James Anderson", "HR");
            myDictionary.Add("Michael Chan", "Content Development");
            myDictionary.Add("Jackie Jackson", "Training");
            myDictionary.Add("Bruce Douglas", "Graphics");
            myDictionary.Add("Kim Date", "HR");
            myDictionary.Add("Joseph Mathews", "Content Development");
            myDictionary.Add("Rose Dorson", "Marketing");
            myDictionary.Add("Andrews Stephan", "Graphics");


            SortedList<string, string> myDictionary2 = new SortedList<string, string>();
            myDictionary2.Add("Tom Lee", "Training");
            myDictionary2.Add("James Anderson", "HR");
            myDictionary2.Add("Michael Chan", "Content Development");
            myDictionary2.Add("Jackie Jackson", "Training");
            myDictionary2.Add("Bruce Douglas", "Graphics");
            myDictionary2.Add("Kim Date", "HR");
            myDictionary2.Add("Joseph Mathews", "Content Development");
            myDictionary2.Add("Rose Dorson", "Marketing");
            myDictionary2.Add("Andrews Stephan", "Graphics");

            

             foreach (var item in myDictionary2)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");

            }

            
            if(myDictionary2.ContainsKey("Andrews Stephan"))
            {
                myDictionary2.Remove("Andrews Stephan");
            }


            Console.Write("\nmy Dictionary2 after removing key Andrews\n\n");

             foreach (var item in myDictionary2)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");

            }



            

        }
    }
}
