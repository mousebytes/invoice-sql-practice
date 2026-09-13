using System.Data.SqlTypes;

namespace Models.ViewModels;
public class InvoiceItemView : InvoiceItem
{
    // calculated on SELECT
    public SqlMoney? Total {get; set;} = null;
}