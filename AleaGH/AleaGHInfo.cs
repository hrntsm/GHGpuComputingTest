using System;
using System.Drawing;
using Grasshopper;
using Grasshopper.Kernel;

namespace AleaGH
{
    public class AleaGHInfo : GH_AssemblyInfo
    {
        public override string Name => "AleaGH Info";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("9FBF4A08-E8A5-4FCB-BD59-947E8C59D09E");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}
