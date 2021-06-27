using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern.structure_pattern.proxy
{
    public class ReportMediaServices : IReportMediaServices
    {
        public override string AddImages(params ImageModel[] images)
        {
            return $"images sent ";
        }
    }
}
