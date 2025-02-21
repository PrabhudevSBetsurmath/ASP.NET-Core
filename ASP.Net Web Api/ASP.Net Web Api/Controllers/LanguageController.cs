using ASP.Net_Web_Api.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public LanguageController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public IActionResult GetLanguages()
        {
            return Ok(_appDbContext.Languages.ToList());
        }

        [HttpGet("{languageId}")]
        public IActionResult GetLanguageById(int languageId)
        {
            return Ok(_appDbContext.Languages.FirstOrDefault(x=>x.Id == languageId));
        }

        [HttpPost]
        public IActionResult AddLangauge(Language langauge)
        {
      
            try
            {
                Language langaugeData = new Language()
                {
                    Id = langauge.Id,
                    Title = langauge.Title,
                    Description = langauge.Description,
                };
                _appDbContext.Languages.Add(langauge);
                _appDbContext.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
