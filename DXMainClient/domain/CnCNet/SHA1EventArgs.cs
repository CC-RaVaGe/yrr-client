﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTAClient.domain.CnCNet
{
    public class SHA1EventArgs : EventArgs
    {
        public SHA1EventArgs(string sha1)
        {
            SHA1 = sha1;
        }

        public string SHA1 { get; private set; }
    }
}
