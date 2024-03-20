﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
      public IEnumerable<Evento> _evento = new Evento[] {
              new Evento(){
              EventoId = 1,
              Tema = "Angular 11 e .NET 5",
              Local = "Belo Horizonte",
              Lote = "Lote 1",
              QtdPessoas = 250,
              DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),  
              ImagemURL = "foto1.png" 
          },

              new Evento(){
              EventoId = 2,
              Tema = "Angular 11 e Suas Novidades",
              Local = "São Paulo",
              Lote = "Lote 2",
              QtdPessoas = 350,
              DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),  
              ImagemURL = "foto2.png"

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
            return _evento.Where(evento =>evento.EventoId == id);
        }


        [HttpPost]
        public string Post()
        {
          return "Exemplo de Post";  
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
          return $"Exemplo de Put com {id}";  
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
          return $"Exemplo de Delete com {id}";  
        }
    }
}
