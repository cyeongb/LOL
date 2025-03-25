// Controllers/HomeController.cs
using Microsoft.AspNetCore.Mvc;
using FakerChampionMastery.Models;
using System.Diagnostics;
using System.Collections.Generic;
using System;
using System.Web;
using Microsoft.Extensions.Logging; 

namespace FakerChampionMastery.Controllers
{
    public class HomeController : Controller
    {   private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
        public IActionResult Index()  //index.html 로 전달
        {
            // 챔피언 마스터리 데이터를 가져와서 홈 페이지에 표시
            var championMasteryData = GetMockChampionMasteryData();
        
            // 로그 남기기
            foreach (var champion in championMasteryData)
            {
                _logger.LogInformation($"챔피언 이미지 URL: {champion.ImageUrl}");
            }
            return View(championMasteryData);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private List<ChampionMastery> GetMockChampionMasteryData()
        {
            var championList = new List<ChampionMastery>

            {   new ChampionMastery { Id = 1, KoreanName = "아리", EnglishName = "Ahri", UsagePercentage = 95, ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ahri_0.jpg" },
                new ChampionMastery { Id = 2, KoreanName = "아지르", EnglishName = "Azir", UsagePercentage = 92, ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Azir_0.jpg" },
                new ChampionMastery { Id = 3, KoreanName = "르블랑", EnglishName = "LeBlanc", UsagePercentage = 91, ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Leblanc_0.jpg" },
                new ChampionMastery { Id = 4, KoreanName = "라이즈", EnglishName = "Ryze", UsagePercentage = 90, ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ryze_0.jpg" },
                new ChampionMastery { Id = 5, KoreanName = "신드라", EnglishName = "Syndra", UsagePercentage = 89, ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Syndra_0.jpg" },
                new ChampionMastery { Id = 6, KoreanName = "오리아나", EnglishName = "Orianna", UsagePercentage = 88, ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Orianna_0.jpg" },
                new ChampionMastery { Id = 7, KoreanName = "리산드라", EnglishName = "Lissandra", UsagePercentage = 87, ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Lissandra_0.jpg" },
                new ChampionMastery { Id = 8, KoreanName = "제드", EnglishName = "Zed", UsagePercentage = 86, ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Zed_0.jpg" },
                new ChampionMastery { Id = 9, KoreanName = "트위스티드 페이트", EnglishName = "Twisted Fate", UsagePercentage = 85, ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/TwistedFate_0.jpg" },
                new ChampionMastery { Id = 10, KoreanName = "갈리오", EnglishName = "Galio", UsagePercentage = 84, ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Galio_0.jpg" },
                // new ChampionMastery { Id = 11, KoreanName = "빅토르", EnglishName = "Viktor", UsagePercentage = 83, ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Viktor_0.jpg" },
                // new ChampionMastery { Id = 12, KoreanName = "카시오페아", EnglishName = "Cassiopeia", UsagePercentage = 82, ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Cassiopeia_0.jpg" },
                // new ChampionMastery { Id = 13, KoreanName = "코르키", EnglishName = "Corki", UsagePercentage = 81, ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Corki_0.jpg" },
                // new ChampionMastery { Id = 14, KoreanName = "카사딘", EnglishName = "Kassadin", UsagePercentage = 80, ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Kassadin_0.jpg" },
                // new ChampionMastery { Id = 15, KoreanName = "제이스", EnglishName = "Jayce", UsagePercentage = 79, ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Jayce_0.jpg" },
                // new ChampionMastery { Id = 16, KoreanName = "피즈", EnglishName = "Fizz", UsagePercentage = 78, ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Fizz_0.jpg" },
                // new ChampionMastery { Id = 17, KoreanName = "야스오", EnglishName = "Yasuo", UsagePercentage = 77, ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Yasuo_0.jpg" },
                // new ChampionMastery { Id = 18, KoreanName = "에코", EnglishName = "Ekko", UsagePercentage = 76, ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ekko_0.jpg" },
                // new ChampionMastery { Id = 19, KoreanName = "아칼리", EnglishName = "Akali", UsagePercentage = 75, ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Akali_0.jpg" },
                // new ChampionMastery { Id = 20, KoreanName = "요네", EnglishName = "Yone", UsagePercentage = 74, ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Yone_0.jpg" }
           };
            return championList;
        }
    }
}