using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TrafficManagerWebAppSqlDbHaDr.Models;
using TrafficManagerWebAppSqlDbHaDr.ViewModels;

namespace TrafficManagerWebAppSqlDbHaDr.Controllers
{
    public class HomeController : Controller
    {
        private MySettings _mySettings;
        private AppDbContext _dbContext;

        public HomeController(IOptions<MySettings> mySettings, AppDbContext dbContext)
        {
            _mySettings = mySettings.Value;
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new HomeViewModel {WebApp = _mySettings.WebApp};
            var firstMovie = await _dbContext.Movies.FirstAsync();
            viewModel.FirstMovieTitle = firstMovie.Title;
            var splitStrings = _mySettings.SqlConnectionString.Split(';');
            splitStrings = splitStrings[0].Split('=');
            viewModel.SqlServer = splitStrings[1];

            return View(viewModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}