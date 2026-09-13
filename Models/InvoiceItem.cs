using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace Models;
public class InvoiceItem
{
    [Required]
    public int PK_InvoiceItem {get; set;} = 0;
    [Required]
    public int Invoice_PK {get; set;}
    [Required][MaxLength(255)]
    public string Name {get; set;} = "";
    [Required][MaxLength(500)]
    public string Description {get; set;} = "";
    [Required]
    public SqlMoney UnitPrice {get; set;}
    [Required]
    public int Quantity {get; set;}
}