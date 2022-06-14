using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD.Models;

[Table("Fornecedores")]
public class Fornecedor
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Obrigatório informar o nome!")]
    [StringLength(100, ErrorMessage="Nome do convênio possui limite de 100 caracteres")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "Obrigatório informar o cnpj!")]
    [StringLength(14, ErrorMessage="Nome do convênio possui limite de 100 caracteres")]
    [RegularExpression(@"^\d+$")]
    public string Cnpj { get; set; }

    [Required(ErrorMessage = "Obrigatório informar o especialidade!")]
    public Especialidade Especialidade { get; set; }
}

public enum Especialidade
{
    Comércio,
    Serviço,
    Indústria
}
