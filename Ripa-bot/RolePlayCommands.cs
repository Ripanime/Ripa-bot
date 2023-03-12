using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ripabot.Commands
{
    internal class RolePlayCommands
    {
        var rpcommands = new List<RolePlayCommand>();
        
    }
    internal struct RolePlayCommand 
    {
        readonly string _name;
        readonly string _description;
        readonly int _commandID;
        public RolePlayCommand(string name,string description,int CommandID) 
        {
            _name = name;
            _description = description;
            _commandID = CommandID;
        }
    }
}
