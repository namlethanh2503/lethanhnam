using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LeThanhNam.Pages;

public class IndexModel : PageModel
{
private readonly MyContext _context;
    public IndexModel(MyContext context)
    {
        _context = context;
    }
    public List<LeThanhNam.Models.News> News { get; set; }
    public async Task OnGetAsync()
    {
        News = await _context.News.ToListAsync();
    }
}
