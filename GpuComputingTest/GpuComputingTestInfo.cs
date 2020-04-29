using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace GpuComputingTest
{
    public class GpuComputingTestInfo:GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "GpuComputingTest";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return null;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("cb038356-ce31-45bf-81d1-236f5bebacb8");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "";
            }
        }
    }
}
