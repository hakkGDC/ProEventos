﻿
using ProEventos.Domain;
using System;
using System.Collections.Generic;

namespace ProEventos.Application.Dtos
{
    public class EventoDto
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }
        public string Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string ImagemURL { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        //public IEnumerable<Lote> Lotes { get; set; }
        //public IEnumerable<RedeSocial> RedesSociais { get; set; }
        //public IEnumerable<PalestranteEvento> PalestranteEventos { get; set; }
    }
}
