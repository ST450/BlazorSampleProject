using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSampleProject.Models
{
    public class Message
    {
        private string _name;

        public Message()
        {
            _name = "Guest";
        }

        public Message(string name)
        {
            _name = name;
        }

        public string GetText()
        {
            return $"Hello {_name} !!";

        }
    }
}
