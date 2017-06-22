using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Transfer.Commands {
    public class ConnectCommand : TerminalCommand {
        public override void Execute(string nameToConnectTo) {
            GetNodeData();
        }

        public void GetNodeData() {
            Debug.Log("CurNode");
        }
    }
}
