﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken  //anlamsız karakterlerden olusan bir anahtar değeridir.
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
