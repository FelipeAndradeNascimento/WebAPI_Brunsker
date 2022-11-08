using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Adm_Imoveis.Data;
using Adm_Imoveis.Models;
using Correios;

namespace Adm_Imoveis.Controllers
{
    public class ImoveisController : Controller
    {
        private readonly Context_db _context;

        public ImoveisController(Context_db context)
        {
            _context = context;
        }

        // GET: Imoveis
        public async Task<IActionResult> Index()
        {
              return View(await _context.DbSetImovel.ToListAsync());
        }

        // GET: Imoveis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DbSetImovel == null)
            {
                return NotFound();
            }

            var imovel = await _context.DbSetImovel
                .FirstOrDefaultAsync(m => m.IdImovel == id);
            if (imovel == null)
            {
                return NotFound();
            }

            return View(imovel);
        }

        // GET: Imoveis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Imoveis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdImovel,Tipo,Endereco")] Imovel imovel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(imovel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(imovel);
        }

        // GET: Imoveis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DbSetImovel == null)
            {
                return NotFound();
            }

            var imovel = await _context.DbSetImovel.FindAsync(id);
            if (imovel == null)
            {
                return NotFound();
            }
            return View(imovel);
        }

        // POST: Imoveis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdImovel,Tipo,Endereco")] Imovel imovel)
        {
            if (id != imovel.IdImovel)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(imovel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImovelExists(imovel.IdImovel))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(imovel);
        }

        // GET: Imoveis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DbSetImovel == null)
            {
                return NotFound();
            }

            var imovel = await _context.DbSetImovel
                .FirstOrDefaultAsync(m => m.IdImovel == id);
            if (imovel == null)
            {
                return NotFound();
            }

            return View(imovel);
        }

        // POST: Imoveis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DbSetImovel == null)
            {
                return Problem("Entity set 'Context_db.DbSetImovel'  is null.");
            }
            var imovel = await _context.DbSetImovel.FindAsync(id);
            if (imovel != null)
            {
                _context.DbSetImovel.Remove(imovel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImovelExists(int id)
        {
          return _context.DbSetImovel.Any(e => e.IdImovel == id);
        }

       /* [HttpGet]
        public JsonResult CorreiosEndereco(string cep)
        {
            var objCep = new Correios.AtendeClienteClient();
            var consulta = objCep.consultaCEPAsync(cep.Replace("-", ""));

            if (consulta != null)
            {
                return Json(consulta.Result, new Newtonsoft.Json.JsonSerializerSettings());
            }
            return Json(null, new Newtonsoft.Json.JsonSerializerSettings());
        }*/
    }
}