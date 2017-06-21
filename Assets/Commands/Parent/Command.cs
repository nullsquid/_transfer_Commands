using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Transfer.Commands {
    public abstract class Command {
        List<string> commands = new List<string>();
        public abstract void Execute(string args);
        public virtual void PreviousCommand(string command) { }
    }
}
