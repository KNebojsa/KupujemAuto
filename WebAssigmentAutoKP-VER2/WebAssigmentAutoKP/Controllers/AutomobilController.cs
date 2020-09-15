using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using WebAssigmentAutoKP.Models;
using X.PagedList;

namespace WebAssigmentAutoKP.Controllers
{
    public class AutomobilController : Controller
    {
        private readonly AutomobilContext db;
        public IStringLocalizer<Resource> _localizer;
        public AutomobilController(AutomobilContext context, IStringLocalizer<Resource> localizer)
        {
            db = context;
            _localizer = localizer;
        }
        public IActionResult ONama()
        {
            return View();
        }
        public IActionResult Kontakt()
        {
            return View();
        }
        public FileContentResult CitajSliku(int? id)
        {
            if (id == null)
            {
                return null;
            }
            Automobil sl = db.Automobili.Find(id);
            if (sl == null)
            {
                return null;
            }
            return File(sl.BinarniPodaci, sl.TipFajla);
        }
        public IActionResult SetCulture(string culture, string sourceUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(
                    new RequestCulture(culture)
                    ),
                new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddYears(1)
                }
                );
            return Redirect(sourceUrl);
        }
        // GET: Automobil
        public IActionResult Index(int? strana)
        {
            //strana koju zelimo da prikazemo, strana zavisi od broja proizvoda po strani, kome mi oznacimo
            IEnumerable<Automobil> listaProizvoda = db.Automobili;
            int brojStrane = strana ?? 1; //ovo znaci ako nije prosledjena neka strana, prosledjuje se 1
            int brojRedova = 6; //koliko redova po strani prikazuje
            ViewBag.Automobili = new SelectList(db.Automobili, "AutomobilId", "Model");
            return View(listaProizvoda.ToPagedList(brojStrane, brojRedova)); //prvo priakzemo koju stranicu zelimo da prikazemo a ovo je konstanta koja predstavlja broj redova po strani
        }

        // GET: Automobil/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var automobil = await db.Automobili
                .FirstOrDefaultAsync(m => m.AutomobilId == id);
            if (automobil == null)
            {
                return NotFound();
            }

            return View(automobil);
        }

        // GET: Automobil/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Automobil/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AutomobilId,KorisnickoIme,Marka,Model,Godiste,ZapreminaMotora,Snaga,Gorivo,Karoserija,BinarniPodaci,TipFajla,Opis,Cena,Kontakt")] Automobil automobil,IFormFile odabranaSlika)
        {
            if (odabranaSlika == null)
            {
                ModelState.AddModelError("BinarniPodaci", "Niste odabrali sliku");
            }
            if (ModelState.IsValid)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        await odabranaSlika.CopyToAsync(ms);//te binarne podatke kopiram u memori stream(binarni podaci)
                        automobil.BinarniPodaci = ms.ToArray();
                    }
                    automobil.TipFajla = odabranaSlika.ContentType;
                    //sada je objekat slika dopunjen sa podacima iz prosledjenog file-a
                    db.Add(automobil);
                    await db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception)
                {
                    ViewBag.Greska = "Greska pri cuvanju slike ";
                }

            }
            
            return View(automobil);
        }

        // GET: Automobil/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var automobil = await db.Automobili.FindAsync(id);
            if (automobil == null)
            {
                return NotFound();
            }
            
             return View(automobil);
        }

        // POST: Automobil/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AutomobilId,KorisnickoIme,Marka,Model,Godiste,ZapreminaMotora,Snaga,Gorivo,Karoserija,BinarniPodaci,TipFajla,Opis,Cena,Kontakt")] Automobil automobil,IFormFile odabranaSlika, int promena=0)
        {
            if (odabranaSlika == null && promena == 0)
            {
                ModelState.AddModelError("BinarniPodaci", "Niste odabrali sliku");
            }
            //if (id != slika.SlikaId)
            //{
            //    return NotFound();
            //}
            Automobil sl = db.Automobili.Find(automobil.AutomobilId);

            if (ModelState.IsValid)
            {
                if (odabranaSlika != null && promena != 0)//znaci da je stigla slika i da zelim promjenu slike
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        await odabranaSlika.CopyToAsync(ms);
                        sl.BinarniPodaci = ms.ToArray();

                    }
                    sl.TipFajla = odabranaSlika.ContentType;
                 
                }
            }
            sl.KorisnickoIme = automobil.KorisnickoIme;
                sl.Marka = automobil.Marka;
                sl.Model = automobil.Model;
                sl.Godiste = automobil.Godiste;
                sl.ZapreminaMotora = automobil.ZapreminaMotora;
                sl.Snaga = automobil.Snaga;
                sl.Gorivo = automobil.Gorivo;
                sl.Karoserija = automobil.Karoserija;
                sl.Opis = automobil.Opis;
                sl.Cena = automobil.Cena;
                sl.Kontakt = automobil.Kontakt;


                try
                {
                    await db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception)
                {
                    ViewBag.Greska = "Greska pri promjeni automobila ";
                }

            
            return View(automobil);
        }

        // GET: Automobil/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var automobil = await db.Automobili
                .FirstOrDefaultAsync(m => m.AutomobilId == id);
            if (automobil == null)
            {
                return NotFound();
            }

            return View(automobil);
        }

        // POST: Automobil/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var automobil = await db.Automobili.FindAsync(id);
            db.Automobili.Remove(automobil);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AutomobilExists(int id)
        {
            return db.Automobili.Any(e => e.AutomobilId == id);
        }
        public PartialViewResult _PretragaCena(double? min, double? max, int AutomobilId = 0) //mora da se zove isto kao i name atribut select controle KategorijaId i ti parametri mojau da se nadju na kraju 
        {
            IEnumerable<Automobil> listaAutomobila = db.Automobili;
            if (AutomobilId != 0)
            {
                Automobil k1 = db.Automobili.Find(AutomobilId);
                if (k1 != null)
                {
                    ViewBag.Automobil = k1.Marka;
                    listaAutomobila = listaAutomobila.Where(p => p.AutomobilId == AutomobilId);
                }
                else
                {
                    ViewBag.Automobil = "";
                    return PartialView();
                }
            }
            else
            {
                ViewBag.Automobil = "Sve marke";
            }
            if (min == null)
            {
                min = listaAutomobila.Min(p => p.Cena);
            }
            if (max == null)
            {
                max = listaAutomobila.Max(p => p.Cena);
            }
            listaAutomobila = listaAutomobila.Where(p => p.Cena >= min && p.Cena <= max);

            return PartialView(listaAutomobila);

        }

        //public IActionResult PrikaziProizvode(int? strana)
        //{ //strana koju zelimo da prikazemo, strana zavisi od broja proizvoda po strani, kome mi oznacimo
        //    IEnumerable<Automobil> listaProizvoda = db.Automobili;
        //    int brojStrane = strana ?? 1; //ovo znaci ako nije prosledjena neka strana, prosledjuje se 1
        //    int brojRedova = 6; //koliko redova po strani prikazuje
        //    return View(listaProizvoda.ToPagedList(brojStrane, brojRedova)); //prvo priakzemo koju stranicu zelimo da prikazemo a ovo je konstanta koja predstavlja broj redova po strani
        //}

    }
}
