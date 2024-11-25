using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class CommandHistory
    {
        private Stack<ICommand> _history = new Stack<ICommand>();

        public void Push(ICommand command)
        {
            _history.Push(command);
        }

        public ICommand Pop()
        {
            if (_history.Count == 0) return null;
            return _history.Pop();
            
            
        }
    }

}
