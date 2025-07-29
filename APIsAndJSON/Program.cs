using System;
using System.Net.Http;
using System.Runtime.InteropServices.JavaScript;
using Newtonsoft.Json.Linq;


namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
           RonVSKanyeAPI.Convo();
           OpenWeatherMapAPI.GetuserTemp(); 
        }
    }
}
