using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLecture2
{
    internal class Player
    {
        //properties
        public string Username { get; set; }
        public string Role { get; set; }
        public int Level { get; set; }
        //constructor
        public Player(string _username, string _role, int _level)
        {
            Username = _username;
            Role = _role;
            Level = _level;
        }
        //overloading
        public Player()
        {
            Username = "New User";
            Role = "Unassigned";
            Level = 1;
        }
        //methods
        public string GetDetails()
        {
            return $"Username: {Username} Role: {Role} Level: {Level}";
        }
    }
}
