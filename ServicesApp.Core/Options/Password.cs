using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Core.Options
{
    public static class Password
    {
         public const bool RequireDigit = true;
         public const bool RequireLowercase = true;
         public const bool boolRequireNonAlphanumeric = false;
         public const bool boolRequireUppercase = true;
         public const int RequiredLength = 6;
         public const int RequiredUniqueChars = 1;
    }
}
