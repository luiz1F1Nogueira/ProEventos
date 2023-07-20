using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] {
            new Evento() {
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "Alambari",
                Lote = "1° lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
            },new Evento() {
                EventoId = 2,
                Tema = "Angular 12 e .NET 5",
                Local = "Itapetininga",
                Lote = "2° lote",
                QtdPessoas = 450,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")
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
    }
}
