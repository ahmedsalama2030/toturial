using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern.structure_pattern.FacadePattern
{
    public class OrderProcess
    {
        string result = null;
        public string createOrder()
        {
            Placrorder placeorder = new Placrorder();
            var resultOrder = placeorder.RegisterOrder();
            if (resultOrder)
            {
                Payment payment = new Payment();
                var resultPayment = payment.createPayment();

                result = resultPayment == true ? "success" : "not register";
                return result;
            }
            else
                result = "not register";

            return result;


        }





    }
}
