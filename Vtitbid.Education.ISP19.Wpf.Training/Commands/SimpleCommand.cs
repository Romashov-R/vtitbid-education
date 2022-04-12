using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.Education.ISP19.Wpf.Training.Commands
{
    public class SimpleCommand : Command
    {
        public SimpleCommand(Action<object> command, Predicate<object> predicate = null)
        {
            _command = command;
            _predicate = predicate;
        }
    }
}
