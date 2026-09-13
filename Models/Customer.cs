using System.ComponentModel.DataAnnotations;

namespace Models;

public class Customer
{
    [Required]
    public int PK_Customer {get; set;}
    [Required]
    public int Tenant_PK {get; set;}
    [Required][MaxLength(100)]
    public string FirstName {get; set;}
    [Required][MaxLength(100)]
    public string LastName {get; set;}
    [Required][MaxLength(100)]
    public string Street {get; set;}
    [Required][MaxLength(100)]
    public string City {get; set;}
    [Required][MaxLength(2)]
    public string State {get; set;}
}