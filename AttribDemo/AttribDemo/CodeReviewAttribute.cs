using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttribDemo
{
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
    class CodeReviewAttribute : Attribute
    {
        public string RevName { get; set; }
        public string RevDate { get; set; }
        public bool IsApproved { get; set; }

        public CodeReviewAttribute(string revName, string revdate, bool isApproved)
        {
            RevName = revName;
            RevDate = revdate;
            IsApproved = isApproved;
        }
    }
}
