using System;
using System.Collections.Generic;
using Alea;
using Alea.Parallel;
using Grasshopper.Kernel;

namespace AleaGH
{
    public class AleaGHSumComponent : GH_Component
    {
        public AleaGHSumComponent()
          : base("AleaGH Sum", "Sum",
            "Calc Sum using GPU",
            "Category", "Subcategory")
        {
        }

        protected override void RegisterInputParams(GH_InputParamManager pManager)
        {
            pManager.AddNumberParameter("Number", "N", "Description", GH_ParamAccess.list);
        }

        protected override void RegisterOutputParams(GH_OutputParamManager pManager)
        {
            pManager.AddNumberParameter("Sum", "Sum", "Sum(use GPU)", GH_ParamAccess.item);
        }

        [GpuManaged]
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            var gpu = Gpu.Default;
            var inputList = new List<double>();

            if (!DA.GetDataList(0, inputList)) { return; }
            double[] inputArray = inputList.ToArray();

            double sum = gpu.Sum(inputArray);

            DA.SetData(0, sum);
        }

        protected override System.Drawing.Bitmap Icon => null;
        public override Guid ComponentGuid => new Guid("57877d7c-1a66-41b1-876d-0c99ee39bf4d");
    }
}
