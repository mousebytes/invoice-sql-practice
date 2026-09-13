using System.ComponentModel.DataAnnotations;

namespace Models;
public class Tenant
{
    [Required]
    public int PK_Tenant {get; set;}
    [Required][MaxLength(100)]
    public string TenantName {get; set;}
}