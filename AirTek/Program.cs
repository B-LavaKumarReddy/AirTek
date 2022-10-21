using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string story1 = File.ReadAllText(
    Path.Combine("C:\\Users\\Owner\\source\\repos\\AirTek\\AirTek\\assets\\schedule.json"));
            string story2 = File.ReadAllText(
    Path.Combine("C:\\Users\\Owner\\source\\repos\\AirTek\\AirTek\\assets\\coding-assigment-orders.json"));

            //User Story-1
            var schedule = JsonConvert.DeserializeObject<Model.Rootobject>(story1);
            Console.WriteLine("*********START-Printing Output for User Story-1***********");
            foreach (var record in schedule.FlightSchedule)
            {
                
                Console.WriteLine("Flight:" + record.flight + ", departure:" + record.departure + ", arrival:" + record.arrival + ", day:" + record.day);
            }
            Console.WriteLine("*********END-Printing Output for User Story-1***********");
            Console.WriteLine();


            //User Story-2
            Console.WriteLine("*********START-Printing Output for User Story-2***********");
            dynamic json = JsonConvert.DeserializeObject(story2);
            //int i = 1;
            foreach (var item in json)
            {
                foreach (var item2 in item.Value)
                {
                    foreach (var record in schedule.FlightSchedule)
                    {
                        if (record.arrival == item2.Value.ToString())
                        {
                            Console.WriteLine("order: " + item.Name + ", flightNumber:" + record.flight + ", departure:" + record.departure  +", arrival: " + item2.Value+ ", day: "+record.day);
                        }
                        else
                        {
                            Console.WriteLine("order: "+item.Name+ ", flightNumber: "+ record.flight+" not scheduled");
                        }
                    }
                }

               // i++;
            }
            Console.WriteLine("*********END-Printing Output for User Story-2***********");

            Console.ReadLine();

        }
    }
}
