using System.ComponentModel.DataAnnotations.Schema;

namespace TarefasAPI.Data;

    [Table("Tarefas")]
    public record Terefa(int Id, string Atividade, string Status);


