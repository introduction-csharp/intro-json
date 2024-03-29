﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace introduction_to_json
{
    class Program
    {
        // step one - https://stackoverflow.com/a/42218729/2902 
        // terminal > dotnet add package Newtonsoft.Json 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string json = @"{""key1"":""value1"",""key2"":""value2""}";

            IDictionary<string, string> values = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            foreach(string k in values.Keys)
                Console.WriteLine($"{k}: {values[k]}");


            // https://www.newtonsoft.com/json/help/html/DeserializeObject.htm 
            string json2 = @"{
            'Email': 'james@example.com',
            'Active': true,
            'CreatedDate': '2021-01-20T00:00:00Z',
            'Roles': [
                'User',
                'Admin'
            ]
            }";

            Account account = JsonConvert.DeserializeObject<Account>(json2);

            Console.WriteLine(account.Email);

        }

        public class Account
        {
            string _email;
            bool _active;
            DateTime _created;
            IList<string> _roles;

            public string Email { get => _email; set => _email = value; }
            public bool Active { get => _active; set => _active = value; }
            public DateTime CreatedDate { get => _created; set => _created = value; }
            public IList<string> Roles { get => _roles; set => _roles = value; }

            public Account(string e, bool a, DateTime c, IList<string> r)
            {
                _email = e;
                _active = a;
                _created = c;
                _roles = r;
            }
        }
    }


}
