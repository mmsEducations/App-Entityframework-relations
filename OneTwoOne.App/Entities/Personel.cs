// See https://aka.ms/new-console-template for more information
/*
 *  Tablolar arası ilişki kurma yöntemleri
 *  Dafault Convention
    * Navigation propertyler kullanılır  
 *  Data Annotation
    * Attribute ile işaretlenerek yapılır   
    * [ForeignKey("Personel"))]//bu neyin forign key'si 
       public int PersonelId { get; set; } 
 *  Fluent Api
    * OnModelCreating Metodu Override edilerek ilişkilerin c# kodları ile yazılarak yapılmasıdır 
    * HasOne,WithOne... 
   Biz tabloara arası ilşki kurarken istediğimiz yöntemlerden biri ile hareket edebiliriz 
   Dafault Convention ile tablolar arası 1'e 1 ilişki Kurma 
 */

/*
 * Dafault Convention
   Tekil Navigation propertyler  üzerinden ilişki kurulur  
 */

public class Personel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Tckn { get; set; }

    public PersonelAddress PersonelAddress { get; set; }//Tekil Navigation property Not:Bir personelin bir adresi olabilir
}
