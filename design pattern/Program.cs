using design_pattern.Factory_Pattern;
using System;
using design_pattern.structure_pattern.proxy;
using System.Collections.Generic;
using design_pattern.structure_pattern.Decorator;
using design_pattern.structure_pattern.FacadePattern;
using design_pattern.structure_pattern.Bridge.Implementation;
using design_pattern.structure_pattern.Bridge;
using design_pattern.Behavoir_Pattern.concrete;
using design_pattern.Behavoir_Pattern.solve.concrete;
using design_pattern.Behavoir_Pattern.Mediator.concerete;

namespace design_pattern
{
    public class y
    {
        public int nId { get; set; }

        
    }
    public class x:ICloneable
    {
        public int id { get; set; }
        public int age { get; set; }
        public y nid { get; set; }

        public object Clone()
        {
        return    this.MemberwiseClone();
        }

        public object DeepClone()
        {
            var z = new x();
            z=(x) this.MemberwiseClone();
            z.nid = new y
            {
                nId = z.nid.nId
            };
            return z;
        }
    }
    public class Program
    {

        static void Main(string[] args)
        {
            var o1 = new x
            {
                age = 12,
                id=1,
                nid = new y
                {
                    nId = 12
                }
            };

            var o2 =(x)  o1.DeepClone();
            o2.nid.nId = 13;
            o2.age = 888;
            o2.id = 2;

            var o3 = (x)o1.DeepClone();
            o3.nid.nId = 14;
            o3.age = 7777;
            o3.id = 3;

            Console.ReadKey();




            #region Factory Pattern
            //string cardNumber,cardcode;


            //Console.WriteLine("enter your card number");
            //cardNumber = Console.ReadLine().ToString();
            //cardcode = cardNumber.Substring(0,6);
            //FactoryBank factoryBank = new FactoryBank();

            //IBank bank = factoryBank.GetBank(cardcode);
            //Console.WriteLine(bank.withdrow());
            //Console.ReadKey();

            #endregion
            #region structure Paterrn

            #region Proxy
            //ReportMediaServicesProxy ReportMediaServicesProxy = new ReportMediaServicesProxy();
            //ImageModel[] ImageModel = new ImageModel[] {
            //    new ImageModel() { Id = 1, Path = "cd/dd", Selected = true },
            //    new ImageModel() { Id = 2, Path = "cd/dd", Selected = true },
            //    new ImageModel() { Id = 3, Path = "cd/dd", Selected = true },
            //    new ImageModel() { Id = 4, Path = "cd/dd", Selected = true },
            //    new ImageModel() { Id = 5, Path = "cd/dd", Selected = true },
            //    new ImageModel() { Id = 6, Path = "cd/dd", Selected = false },
            //    new ImageModel() { Id = 7, Path = "cd/dd", Selected = false },
            //    new ImageModel() { Id = 8, Path = "cd/dd", Selected = false },
            //    new ImageModel() { Id = 9, Path = "cd/dd", Selected = true },
            //    new ImageModel() { Id = 10, Path = "cd/dd", Selected = false },
            //    new ImageModel() { Id = 11, Path = "cd/dd", Selected = false }
            //};
            //ImageModel[] ImageModelEdit = new ImageModel[] {
            //    new ImageModel() { Id = 1, Path = "cd/dd", Selected = true },
            //    new ImageModel() { Id = 2, Path = "cd/dd", Selected = false },
            //    new ImageModel() { Id = 3, Path = "cd/dd", Selected = true },
            //    new ImageModel() { Id = 4, Path = "cd/dd", Selected = false },
            //    new ImageModel() { Id = 8, Path = "cd/dd", Selected = true },
            //    new ImageModel() { Id = 9, Path = "cd/dd", Selected = true },
            //    new ImageModel() { Id = 10, Path = "cd/dd", Selected = true },
            //    new ImageModel() { Id = 11, Path = "cd/dd", Selected = true }
            //     };



            //ReportMediaServicesProxy.AddImages(ImageModel);
            //ReportMediaServicesProxy.EditImages(ImageModelEdit);
            #endregion

            #region Decorator Pattern



            //Shap Circle = new Circle();
            //Circle.draw();

            //Shap rectangle = new Rectangle();
            //rectangle.draw();

            //ShapWithBorder shapWithBorder = new ShapWithBorder(new Circle(),"red");
            //shapWithBorder.draw();
            //ShapWithBorder shapWithBorder2 = new ShapWithBorder(new Rectangle(),"yellow");
            //shapWithBorder2.draw();


            #endregion

            #region Adapter Pattern

            #endregion
            #region Facade Pattern
            //   var OrderProcess = new OrderProcess();
            //Console.WriteLine(   OrderProcess.createOrder());

            #endregion

            #region Bridge
            //    BankAhly bankAhly = new BankAhly();
            //bankAhly.ProcessPayment("1") ;
            //    BankCairo BankCairo = new BankCairo();
            //    BankCairo.ProcessPayment("2");
            //PaymentBridge order = new CardPayment();
            //order.iPaymentSystem = new BankAhly();
            //order.MakePayment();
            //order.iPaymentSystem = new BankAhly();
            //order.MakePayment();



            #endregion
            #endregion

            #region Design Structure
            #region Behavoir
            //PhotoshopEditor photoshopEditor = new PhotoshopEditor();
            //photoshopEditor.Use(new ImageElement());
            //photoshopEditor.Use(new TextElement());
            //photoshopEditor.Crop();
            ////photoshopEditor.Resize();
            //solvePhotoshopEditor photoshopEditor = new solvePhotoshopEditor();
            //photoshopEditor.Use(new Behavoir_Pattern.solve.concrete.ImageElement());
            //photoshopEditor.Use(new Behavoir_Pattern.solve.concrete.TextElement());
            //photoshopEditor.Execute(new DeleteOperation());
            //photoshopEditor.Execute(new ResizeOperation());
            #endregion

            //#region Mediator
            //EmailCommand email = new EmailCommand();
            //SMSCommand sms = new SMSCommand();
            //mediator mediator = new mediator();
            //mediator.send(email);
            //mediator.send(sms);

            #endregion

             

        }


    }
}
