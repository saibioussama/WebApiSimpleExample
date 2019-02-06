using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiSimpleExample.Data;
using WebApiSimpleExample.Models;

namespace WebApiSimpleExample.Controllers
{
  [Route("api/[controller]/[action]")]
  [ApiController]
  public class EtudiantsController : ControllerBase
  {
    private readonly MyDataContext _context;

    public EtudiantsController(MyDataContext context)
    {
      _context = context;
    }

    [ProducesAttribute(typeof(List<Etudiant>))]
    [HttpGet]
    public ActionResult Get()
    {
      return Ok(_context.Etudiants.ToList());
    }

    [ProducesAttribute(typeof(Etudiant))]
    [HttpGet("{id}")]
    public ActionResult GetById(int id)
    {
      var etudiant = _context.Etudiants.Find(id);
      if (etudiant == null)
        return NotFound();
      return Ok(etudiant);
    }

    [HttpPost]
    public async Task<ActionResult> Create(Etudiant etudiant)
    {
      if (!ModelState.IsValid)
        return BadRequest(ModelState);
      _context.Etudiants.Add(etudiant);
      await _context.SaveChangesAsync();
      return Ok();
    }

    [HttpPost]
    public async Task<ActionResult> Update(Etudiant etudiant)
    {
      if (!ModelState.IsValid)
        return BadRequest(ModelState);
      _context.Etudiants.Update(etudiant);
      await _context.SaveChangesAsync();
      return Ok();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> Remove(int id)
    {
      if (!ModelState.IsValid)
        return BadRequest(ModelState);
      var etudiant = _context.Etudiants.Find(id);
      if (etudiant == null)
        return NotFound();
      _context.Etudiants.Remove(etudiant);
      await _context.SaveChangesAsync();
      return Ok();
    }

  }
}