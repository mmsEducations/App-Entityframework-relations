// See https://aka.ms/new-console-template for more information
public class PersonelAddress
{
    public int Id { get; set; }
    public string Address { get; set; }
    public Personel Personel { get; set; } //Tekil Navigation property Not:Bir adress sadece bir personele ait olabilir
    public int tugce { get; set; }
}
