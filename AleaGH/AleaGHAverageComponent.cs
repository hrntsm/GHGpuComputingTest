using System;
using System.Collections.Generic;
using Alea;
using Alea.Parallel;
using Grasshopper.Kernel;

namespace AleaGH
{
    public class AleaGHAverageComponent : GH_Component
    {
        public AleaGHAverageComponent()
          : base("AleaGH Average", "Ave",
            "Calc Average using GPU",
            "Category", "Subcategory")
        {
        }

        protected override void RegisterInputParams(GH_InputParamManager pManager)
        {
            pManager.AddNumberParameter("Number", "N", "Description", GH_ParamAccess.list);
        }

        protected override void RegisterOutputParams(GH_OutputParamManager pManager)
        {
            pManager.AddNumberParameter("Average", "ave", "Average(use GPU)", GH_ParamAccess.item);
        }

        [GpuManaged]
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            var gpu = Gpu.Default;
            var inputList = new List<double>();

            if (!DA.GetDataList(0, inputList)) { return; }
            double[] inputArray = inputList.ToArray();

            double average = gpu.Average(inputArray);

            DA.SetData(0, average);
        }

        protected override System.Drawing.Bitmap Icon => null;
        public override Guid ComponentGuid => new Guid("e8812531-c9b1-4705-8f90-2685104c5ab2");
    }
}
