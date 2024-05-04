
using System.ComponentModel.DataAnnotations.Schema;

public class PersonelAddress
{
    //[ForeignKey(nameof(Personel))]//atirbute yani data annotation ile ilişki kurduk
    [ForeignKey("Personel")]//atirbute yani data annotation ile ilişki kurduk
    public int PersonelAddressId { get; set; }
    public string Address { get; set; }
    public Personel Personel { get; set; } //Tekil Navigation property Not:Bir adress sadece bir personele ait olabilir

}
