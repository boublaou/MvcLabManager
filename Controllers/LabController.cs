using Microsoft.AspNetCore.Mvc;
using MvcLabManager.Models;

namespace MvcLabManager.COntrollers;

public class LabController : Controller
{
    private LabManagerContext _context;

    public LabController(LabManagerContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Labs);
    }

    public IActionResult Show(int id)
    {
        Lab? lab = _context.Labs.Find(id);

        if(lab == null)
        {
            return NotFound(); //RedirectToAction("Index");
        }
        return View(lab);
    }


}