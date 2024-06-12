using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewsWebAPI.Controllers
{
 [ApiController]
[Route("api/[controller]")]
public class NewsController : ControllerBase
{
    private readonly NewsWebDbContext _context;

    public NewsController(NewsWebDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<News>>> GetNews()
    {
        return await _context.News.ToListAsync();
    }

    [HttpPost("AddNews")]
    public async Task<ActionResult<News>> AddNews(News news)
    {
        _context.News.Add(news);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetNews", new { id = news.Id }, news);
    }
}
}