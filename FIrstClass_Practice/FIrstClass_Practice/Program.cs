using FIrstClass_Practice;

Person ogrenci1 = new Person();
ogrenci1.Ad = "Ali";   
ogrenci1.Soyad = "Yılmaz";
ogrenci1.DogumTarihi = new DateTime(2000, 5, 15);

Person ogrenci2 = new Person();
ogrenci2.Ad = "Ayşe";
ogrenci2.Soyad = "Demir";
ogrenci2.DogumTarihi = new DateTime(1998, 3, 22); 

Person ogretmen1 = new Person();
ogretmen1.Ad = "Mehmet";
ogretmen1.Soyad = "Kara";
ogretmen1.DogumTarihi = new DateTime(1985, 7, 10);

Console.WriteLine("===== Ogrenci Bilgileri=====");
ogrenci1.Bilgiler();
ogrenci2.Bilgiler();

Console.WriteLine("===== Ogretmen Bilgileri=====");
ogretmen1.Bilgiler();