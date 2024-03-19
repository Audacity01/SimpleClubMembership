using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldValidatorsAPI
{
    public static class CommonRegularExpressionValidationPatterns
    {
        public const string Email_Address_RegEx_Pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";

        public const string In_PhoneNumber_RegEx_Pattern = @"((\+*)((0[ -]*)*|((91 )*))((\d{12})+|(\d{10})+))|\d{5}([- ]*)\d{6}";

        public const string In_Post_Code_RegEx_Pattern = @"([0-9]{6}|[0-9]{3}\s[0-9]{3})";

        public const string Strong_Password_RegEx_Pattern = @"(?=^.{6,10}$)(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&amp;*()_+}{&quot;:;'?/&gt;.&lt;,])(?!.*\s).*$";
    }
}
