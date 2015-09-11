﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emts.Common.Security {
    public interface IUserSession {
        string Firstname { get; }
        string Lastname { get; }
        string EmailAddress { get; }
        bool IsInRole(string roleName);
    }
}
