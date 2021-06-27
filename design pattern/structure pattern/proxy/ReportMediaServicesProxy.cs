using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace design_pattern.structure_pattern.proxy
{
   public  class ReportMediaServicesProxy
    {
        IReportMediaServices _IReportMediaServices;
        Dictionary<int, ImageModel> Images = new Dictionary<int, ImageModel>();
        public  string AddImages(params ImageModel[] images)
        {
            if (_IReportMediaServices == null)
                _IReportMediaServices = new ReportMediaServices();
            string result=null;
            foreach (var image in images)
            {
                var countImagesSelected = Images.Where(a=>a.Value.Selected==true).Count();
                if (countImagesSelected > 3)
                {
                    image.Selected = false;
                    Images.Add(image.Id, image);
                }
                else
                    Images.Add(image.Id, image);

                result = "done add";
            }

            foreach (var item in Images)
            {
                Console.WriteLine(item.Value.Id + "+++++" + item.Value.Selected);

            }
            return result;

         }


        public string EditImages(params ImageModel[] images)
        {
            if (_IReportMediaServices == null)
                _IReportMediaServices = new ReportMediaServices();
            string result = null;
            foreach (var image in images)
            {
                var countImagesSelected = Images.Where(a => a.Value.Selected == true).Count();
                if (countImagesSelected > 3)
                {
                    image.Selected = false;
                    Images[image.Id] = image;
                }
                else
                    Images[image.Id] = image;
 
                result = "done add";
            }

            foreach (var item in Images)
            {
                Console.WriteLine(item.Value.Id +"+++++"+ item.Value.Selected);
             }
            return result;

        }
    }
}
