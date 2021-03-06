﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using SuperSocket.Common;
using SuperSocket.SocketBase;
using AnyLog;

namespace SuperSocket.SocketEngine
{
    interface IAsyncSocketSession
    {
        void ProcessReceive(SocketAsyncEventArgs e);
    }
}
