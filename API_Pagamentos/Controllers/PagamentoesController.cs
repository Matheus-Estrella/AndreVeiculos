﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_Pagamentos.Data;
using Models;

namespace API_Pagamentos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoesController : ControllerBase
    {
        private readonly API_PagamentosContext _context;

        public PagamentoesController(API_PagamentosContext context)
        {
            _context = context;
        }

        // GET: api/Pagamentoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pagamento>>> GetPagamento()
        {
          if (_context.Pagamento == null)
          {
              return NotFound();
          }
            return await _context.Pagamento.ToListAsync();
        }

        // GET: api/Pagamentoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pagamento>> GetPagamento(int id)
        {
          if (_context.Pagamento == null)
          {
              return NotFound();
          }
            var pagamento = await _context.Pagamento.FindAsync(id);

            if (pagamento == null)
            {
                return NotFound();
            }

            return pagamento;
        }

        // PUT: api/Pagamentoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPagamento(int id, Pagamento pagamento)
        {
            if (id != pagamento.Id)
            {
                return BadRequest();
            }

            _context.Entry(pagamento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PagamentoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Pagamentoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pagamento>> PostPagamento(Pagamento pagamento)
        {
          if (_context.Pagamento == null)
          {
              return Problem("Entity set 'API_PagamentosContext.Pagamento'  is null.");
          }
            _context.Pagamento.Add(pagamento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPagamento", new { id = pagamento.Id }, pagamento);
        }

        // DELETE: api/Pagamentoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePagamento(int id)
        {
            if (_context.Pagamento == null)
            {
                return NotFound();
            }
            var pagamento = await _context.Pagamento.FindAsync(id);
            if (pagamento == null)
            {
                return NotFound();
            }

            _context.Pagamento.Remove(pagamento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PagamentoExists(int id)
        {
            return (_context.Pagamento?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
