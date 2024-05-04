public class Personel
{
    public int PersonelId { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Tckn { get; set; }

    public PersonelAddress PersonelAddress { get; set; }//Tekil Navigation property Not:Bir personelin bir adresi olabilir
}
