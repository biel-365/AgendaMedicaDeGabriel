namespace AgendaMedica.Models
{
    public class Agenda
    {
        public Guid AgendaId { get; set; } // PK
        public Guid PacienteId { get; set; } // FK
        public Paciente? Paciente { get; set; } // Objeto referente a chave acima
        public Guid MedicoId { get; set; } // PK
        public Medico? Medico { get; set; } // Objeto referente a chave acima
        public DateTime DataConsulta { get; set; }
        public string? Status { get; set; }
    }
}
