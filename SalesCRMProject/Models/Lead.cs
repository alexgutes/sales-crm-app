namespace SalesCRMProject.Models;

public class Lead
{
    public int Id { get; set; }

    public Company Company { get; set; }
    
    public Contact Contact { get; set; } 
    
    public string LeadClass { get; set; }
}



