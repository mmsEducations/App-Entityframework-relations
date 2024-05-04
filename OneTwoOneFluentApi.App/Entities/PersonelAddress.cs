

public class PersonelAddress
{
    public int PersonelAddressId { get; set; }
    public string Address { get; set; }
    public Personel Personel { get; set; } //Tekil Navigation property Not:Bir adress sadece bir personele ait olabilir

}
