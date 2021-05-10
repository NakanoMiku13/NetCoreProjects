using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project1.Models;
using Project1.Data;
namespace Project1.Controllers
{
    public class ProductosController : Controller
    {
        private readonly ApplicationDbContext context;
        public ProductosController(ApplicationDbContext context)
        {
            this.context=context;
        }
        public IActionResult Index()
        {
            return View(context.Productos.ToList());
        }
    }
}
