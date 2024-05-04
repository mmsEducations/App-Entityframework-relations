/*
 * Default Convention 
 * Bire çok ilişkiyi Default Convention yöntemile yapmak ,
 * Foreign key vermezsek dahi kendisi otomatikoluşturur
 * Biz Foreign key'i vermeden de Default Convention yöntemi otomatik oluşturur
 * Örenğin aşaığıda bulunan ilişkilere göre migration oluşturudğumuzda personel tablosunda entity Adını içeren bir kolon yaniproperty oluşturur 
 */

public class Personel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public Department Department { get; set; } //Tekil Navigation Property

    public int DepId { get; set; }


}

public class Department
{
    public int Id { get; set; }

    public string Name { get; set; }

    public ICollection<Personel> Personels { get; set; } //Çoğul Navigation Property 
}