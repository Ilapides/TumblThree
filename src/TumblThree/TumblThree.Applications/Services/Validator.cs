﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumblThree.Applications.Services
{
    public static class Validator
    {
        public static bool IsValidTumblrUrl(string url)
        {
            return url != null && url.Length > 18 && url.Contains(".tumblr.com") && (url.StartsWith("http://", true, null) || url.StartsWith("https://", true, null));
        }
    }
}