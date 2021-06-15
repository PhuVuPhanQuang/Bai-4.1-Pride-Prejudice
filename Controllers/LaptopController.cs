using Bai_4._1_Pride_Prejudice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai_4._1_Pride_Prejudice.Controllers
{
    public class LaptopController : Controller
    {
        // GET: Laptop
        public ActionResult Index()
        {
            return View();
        }

        private List<Laptop> listLaptops;
        public LaptopController()
        {
            listLaptops = new List<Laptop>();
            listLaptops.Add(new Laptop()
            {
                Id = 1,
                Name = "Laptop Dell Gaming G7 15 7500",
                CPU = "Intel Core i7-10750H",
                RAM = "2 x 4GB DDR4 2933MHz",
                SSD = "512GB SSD",
                Color = "Red & Black", 
                Inch = "15.6 TN(1920 x 1080) 144Hz",
                Price = "33.090.000đ",
                Image = "Content/images/Laptop1.jpg"
            });
            listLaptops.Add(new Laptop()
            {
                Id = 2,
                Name = "Laptop LG gram 14Z980-G.AH52A5",
                CPU = "Intel Core i5-8250U ( 1.6 GHz - 3.4 GHz / 6MB / 4 nhân, 8 luồng )",
                RAM = " 1 x 8GB Onboard DDR4 2400MHz",
                SSD = "256GB SSD M.2 SATA",
                Color = "Gray",
                Inch = "15.6 TN(1920 x 1080) 144Hz",
                Price = "33.090.000đ",
                Image = "Content/images/Laptop2.jpg"
            });
            listLaptops.Add(new Laptop()
            {
                Id = 3,
                Name = "Laptop ASUS ROG Strix G15 G513QC-HN015T 90NR0512-M00190",
                CPU = "Intel Core i7-10750H",
                RAM = "2 x 4GB DDR4 2933MHz",
                SSD = "512GB SSD",
                Color = "Red & Black",
                Inch = "15.6 TN(1920 x 1080) 144Hz",
                Price = "33.090.000đ",
                Image = "Content/images/Laptop3.jpg"
            });
            listLaptops.Add(new Laptop()
            {
                Id = 4,
                Name = "Laptop ASUS ROG Zephyrus G14 GA401QC-HZ021T 90NR05T5-M00510",
                CPU = "Intel Core i7-10750H",
                RAM = "2 x 4GB DDR4 2933MHz",
                SSD = "512GB SSD",
                Color = "Red & Black",
                Inch = "15.6 TN(1920 x 1080) 144Hz",
                Price = "33.090.000đ",
                Image = "Content/images/Laptop4.jpg"
            });
            listLaptops.Add(new Laptop()
            {
                Id = 5,
                Name = "Laptop Lenovo Ideapad S340-14IIL-81VV00FRVN",
                CPU = "Intel Core i7-10750H",
                RAM = "2 x 4GB DDR4 2933MHz",
                SSD = "512GB SSD",
                Color = "Red & Black",
                Inch = "15.6 TN(1920 x 1080) 144Hz",
                Price = "33.090.000đ",
                Image = "Content/images/Laptop5.jpg"
            });
            listLaptops.Add(new Laptop()
            {
                Id = 6,
                Name = "Laptop ASUS ZenBook 14 UX434FAC-A6064T",
                CPU = "Intel Core i7-10750H",
                RAM = "2 x 4GB DDR4 2933MHz",
                SSD = "512GB SSD",
                Color = "Red & Black",
                Inch = "15.6 TN(1920 x 1080) 144Hz",
                Price = "33.090.000đ",
                Image = "Content/images/Laptop6.jpg"
            });
            listLaptops.Add(new Laptop()
            {
                Id = 7,
                Name = "Laptop ASUS VivoBook S15 S530UA-BQ291T",
                CPU = "Intel Core i7-10750H",
                RAM = "2 x 4GB DDR4 2933MHz",
                SSD = "512GB SSD",
                Color = "Red & Black",
                Inch = "15.6 TN(1920 x 1080) 144Hz",
                Price = "33.090.000đ",
                Image = "Content/images/Laptop7.jpg"
            });
            listLaptops.Add(new Laptop()
            {
                Id = 8,
                Name = "Laptop LG Gram 14Z90N-V.AR52A5",
                CPU = "Intel Core i7-10750H",
                RAM = "2 x 4GB DDR4 2933MHz",
                SSD = "512GB SSD",
                Color = "Red & Black",
                Inch = "15.6 TN(1920 x 1080) 144Hz",
                Price = "33.090.000đ",
                Image = "Content/images/Laptop8.jpg"
            });
            listLaptops.Add(new Laptop()
            {
                Id = 9,
                Name = "Laptop MSI Prestige PS42 Modern 8M-288VN",
                CPU = "Intel Core i7-10750H",
                RAM = "2 x 4GB DDR4 2933MHz",
                SSD = "512GB SSD",
                Color = "Red & Black",
                Inch = "15.6 TN(1920 x 1080) 144Hz",
                Price = "33.090.000đ",
                Image = "Content/images/Laptop9.jpg"
            });
            listLaptops.Add(new Laptop()
            {
                Id = 10,
                Name = "Laptop Dell G5 5590-4F4Y41",
                CPU = "Intel Core i7-10750H",
                RAM = "2 x 4GB DDR4 2933MHz",
                SSD = "512GB SSD",
                Color = "Red & Black",
                Inch = "15.6 TN(1920 x 1080) 144Hz",
                Price = "33.090.000đ",
                Image = "Content/images/Laptop10.jpg"
            });
        }

        public ActionResult ListLaptops()
        {
            ViewBag.TitlePageName = "Laptop view page";
            return View(listLaptops);
        }

    }
}