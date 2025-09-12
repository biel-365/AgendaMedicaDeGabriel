﻿using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;

namespace AgendaMedica.Models
{
    public class Paciente
    {
        public Guid PacienteId { get; set; }
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public string? Celular { get; set; }
        public string? Telefone { get; set; }
        public DateOnly DataNascimento { get; set; }
        public string? Endereco { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? UF { get; set; }
        public string? CEP { get; set; }
        public int? Prontuario { get; set; }
        public string? Email { get; set; }

        // Vincular a Identididade ao Paciente (IdentityUser)

    }
}
