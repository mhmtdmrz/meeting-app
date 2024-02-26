Meeting App

.Net Core 8.0 ile geliştirilmiştir. 

.Net Core çalışmaları temel düzeyde sayfalar arası geçişlerin veri taşımalarının yapıldığı bir uygulama. Veritabanı vs bağlantıları bulunmamaktadır.
Boş bir .net core projesi içerisine MVC tabanı manuel eklenmiştir.

* localhost:xxxx / home / index --> Ana sayfada toplantı bilgileri yer alacaktır. Konum, zaman ve katılımcı sayısı.
* localhost:xxxx / meeting / index --> Toplantıya başvuru için ilk girilen sayfa.
* localhost:xxxx / meeting / list --> Toplantıya katılacak kişilerin bilgilerinin yer aldığı sayfa
* localhost:xxxx / meeting / apply  --> Toplantıya katılmak için post isteği atarak kayıt olunan sayfa. (DB Bağlantısı vs bulunmamaktadır.)

