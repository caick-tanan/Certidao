﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Certidao.API.Models;
using Certidao.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Certidao.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly DataContext _context;

        public EventoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
        }

        [HttpPost]
        public String Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public String Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public String Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
    };
}
