// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

























//Entityler arasında ilişkiler Neden kurulur?
/*
  1) Data Consistency : Veri tutarlılığı 
  2) Navigation Propertyler aracılığı ile ilişkili tablolardan veri çekebiliyoruz 
    eager loding : Bilinçli olarak neye ihtiyacın varsa onu yükleriz
    lazy loading : Hantal Yükleme 
 */

//Personel pEsra = new Personel();
//pEsra.PersonelAddress.Address

//lazy loading 
//eager loding 
//PTSContext context = new PTSContext();
//context.Personels.FirstOrDefault().PersonelAddress.Address;