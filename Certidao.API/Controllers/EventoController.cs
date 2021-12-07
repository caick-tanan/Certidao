using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Certidao.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Certidao.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento[] {
                new Evento(){
                    EventoId = 1,
                    Nome = "Michael Jackson",
                    Cpf = "472.1860.78-94",
                    EstadoCivil = "Casado",
                    Sexo = "Masculino",
                    DataDoObito = "25/05/2009",
                    ImageURL = "Foto.png"
                },
                new Evento(){
                    EventoId = 2,
                    Nome = "MC kevin",
                    Cpf = "625.1860.78-95",
                    EstadoCivil = "Solteiro",
                    Sexo = "Masculino",
                    DataDoObito = "16/05/2021",
                    ImageURL = "Foto1.png"
                },
                new Evento(){
                    EventoId = 3,
                    Nome = "Marília Mendonça",
                    Cpf = "374.1860.78-96",
                    EstadoCivil = "Solteira",
                    Sexo = "Feminino",
                    DataDoObito = "05/11/2021",
                    ImageURL = "Foto2.png"
                }
            };          

        public EventoController()
        {
           
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
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
