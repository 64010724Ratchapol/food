using Microsoft.AspNetCore.Mvc;
using foodde.Models;

namespace foodde.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            User u1 = new User();
            u1.Name = "Tao";
            u1.Id = 64010724;
            u1.Store = "ข้าวดีอร่อย";
            u1.Menu = "ผัดกระเพรา";
            u1.Address = "ตึก ecc ชั้น8";
            u1.Number = 0896790015;

            var u2 = new User();
            u2.Name = "Tan";
            u2.Id = 64010646;
            u2.Store = "ข้าวดีอร่อยมาก";
            u2.Menu = "ผัดกระเพราไก่ไข่ดาว";
            u2.Address = "ตึก ecc ชั้น8";
            u2.Number = 0888888888;

            List<User> user = new List<User>();
            user.Add(u1);
            user.Add(u2);
           

            return View(user);
        }
        public IActionResult Getorder()
        {
            return View();
        }

        public IActionResult Confirm()
        {
            return View();
        }
    }
}
