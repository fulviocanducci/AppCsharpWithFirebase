using AppCsharpWithFirebase.Models;
using Firebase.Database;
using System;
using System.Text.Json;

namespace AppCsharpWithFirebase
{
    class Program
    {
        static void Main(string[] args)
        {
            const string db = "Database/Peoples";
            FirebaseClient firebase =
                new FirebaseClient("https://csharp-localhost-default-rtdb.firebaseio.com/");

            Peoples peoples =
                new Peoples("Gabriel Santos de Andrade", DateTime.Now);

            // ADD
            //var result = firebase.Child(db)
            //    .PostAsync(JsonSerializer.Serialize(peoples))
            //    .GetAwaiter()
            //    .GetResult();

            // UPDATE - -MQZMuByH5vCRx_4QHBs
            //firebase.Child($"{db}/{"-MQZN6qN-A4EvkzQuCa0"}" )                
            //    .PutAsync(JsonSerializer.Serialize(peoples))
            //    .GetAwaiter()
            //    .GetResult();



            // LIST            
            var list = firebase.Child(db)
                .OnceAsync<Peoples>()
                .GetAwaiter()
                .GetResult();

            foreach(var item in list)
            {
                System.Console.WriteLine("{0} - {1} {2}", item.Key, item.Object.Name, item.Object.CreatedAt);
            }

        }
    }
}
