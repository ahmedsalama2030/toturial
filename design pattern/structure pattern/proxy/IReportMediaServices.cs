using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern.structure_pattern.proxy
{
  public  abstract class IReportMediaServices
    {
        public abstract string AddImages(params ImageModel[] images);
         
    }
}
