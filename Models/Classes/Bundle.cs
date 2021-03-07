using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreSite.Models.Classes
{
    public class Bundle
    {
        public Guid BundleID { get; set; }
        public string BundleName { get; set; }
        public string BundleDescription { get; set; }
        public Guid Item1 { get; set; }
        public Guid Item2 { get; set; }
        public Guid Item3 { get; set; }
        public Guid Item4 { get; set; }
    }
}
