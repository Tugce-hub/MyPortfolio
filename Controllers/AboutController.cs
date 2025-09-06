using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class AboutController : Controller
    {
        private static string aboutContent = "Ben Tuğçe Deniz.Bilgisayar mühendisliği öğrencisi olarak yeni teknolojiler öğrenmeyi ve deneyimlemeyi çok seviyorum.İlk stajımı Savola Gıda'da yapmıştım.Bu stajımda Oracle üzerinden Pl/Sql dilini canlı olarak deneyimleme fırsatı yakalamıştım.İkinci stajımda ise WGuard'da gerek çalışma hayatı açısından gerekse kariyerim açısından çok fazla bilgi ve deneyim kazandım. WGuard'da yoğun olarak bilgisayar ağları ve sanal makineler üzerine geçen stajımda önemli ve büyük şirketlerle toplantılara katılma imkanı yakaladım.Bu toplantılarda PoC çalışmalarında yer alma fırsatı buldum.Staj yapmak hem alanımda yeni deneyimler edinmeme yardımcı oldu hem de çalışma ortamını gördüğümden gelecek hakkında daha fazla bilgim oldu. C#,Python,Sql,Html, Css,JavaScript,React,Asp.Net Core dillerinde ve teknolojilerinde kendimi geliştirdim okul hayatım boyunca.Her zaman gelişime ve yeniliğe açık biri olarak, sektördeki güncel teknolojileri öğrenmeye, gerçek projelerde deneyim kazanmaya ve teknik becerilerimi ileri taşımaya devam ediyorum.";

        public IActionResult Index()
        {
            ViewBag.About = aboutContent;
            return View();
        }
        [HttpPost]
        public IActionResult Update(string content)
        {
            aboutContent = content;
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete()
        {
            aboutContent = string.Empty;
            return RedirectToAction("Index");
        }
    }
}

