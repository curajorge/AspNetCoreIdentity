﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreIdentity.ViewModel
{
    public class UserStateVM
    {
        public bool IsAuthenticated { get; set; }
        public string Username { get; set; }
    }
}
