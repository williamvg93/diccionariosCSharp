using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace diccionariosCSharp
{
    public class MyFunctions
    {
        public static string AddElement(Dictionary<int,string> dict, int key, string val){
            try
            {
                dict.Add(key,val);
                return $"Element ({key} : {val}) added successfully";
            }
            catch (Exception error)
            {
                return $"Error Type: {error.GetType()}, \n Error Message: {error.Message}";
            }
            
        }

        public static string CheckKey(Dictionary<int, string> dict, int key){
            return dict.ContainsKey(key) ? "If it exists" : "does not exists";
        }

        public static string CheckValue(Dictionary<int, string> dict, string val){
            return dict.ContainsValue(val) ? "If it exists" : "does not exists";
        }

        public static string RemoveElement(Dictionary<int,string>dict, int key){
            return dict.Remove(key) ? $"Element {key} removed" : $"Element {key} not removed";
        } 

    }
}