using System.ComponentModel.DataAnnotations;

namespace DotNetApi.Entities;
[System.ComponentModel.DataAnnotations.Schema.Table("T_Customers")]
public class T_Customers
{
    [Key]
    public string Id {get; set;}
    public string Name {get; set;}
    public string LastName {get; set;}
    public string Identification {get; set;}
    public string Mail {get; set;}
    public bool Active {get; set;}
    public DateTime CreateAt {get; set;}
    public DateTime? UpdateAt {get; set;}
}