﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSLibrary
{
    public enum AuthenticationState
    {
        UserNotFound,
        WrongPassword,
        Authenticated
    }
}
