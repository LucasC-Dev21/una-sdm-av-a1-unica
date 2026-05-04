using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ValeAtivos324111440.Data;
using Microsoft.EntityFrameworkCore;
using ValeAtivos324111440.Models;


namespace ValeAtivos324111440.Controllers
{
    [ApiController]
    [Route("api/equipamentos")]
    public class EquipamentosController : Controller
    {

        private readonly AppDbContext _context;

        public EquipamentosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetEquipamentos()
        {
            var equipamentos = await _context.Equipamentos.ToListAsync();
            return Ok(equipamentos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEquipamento(int id)
        {
            var equipamento = await _context.Equipamentos.FindAsync(id);
            if (equipamento == null)
            {
                return NotFound();
            }
            return Ok(equipamento);
        }

        [HttpPost]
        public async Task<IActionResult> PostEquipamento([FromBody] Equipamento equipamento)
        {
            _context.Equipamentos.Add(equipamento);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetEquipamentos), new {id = equipamento.Id}, equipamento);
        }
        
    }
}