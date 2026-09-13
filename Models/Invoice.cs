using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace Models;

public class Invoice
{
    [Required]
    public int PK_Invoice {get; set;}
    [Required]
    public int Customer_PK {get; set;}
    [Required]
    public DateTime DateCreated {get; set;}
    public DateTime? DatePaid {get; set;} = null;    
    [Required]
    public SqlMoney AmountPaid {get; set;}
}