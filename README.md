# FilterTypes

<h3>Bu proje ASP.NET MVC'De filtreleme ve filtre çeşitleri konularının kavranması amacıyla yapılmıştır.</h3>

## Özet

Bu projede kullanıcının sayfalar arasında gezinmesi sırasında yaptığı işlemler loglanmaktadır. Loglama işlemini gerçekleştirmek amacıylada **filtrelerden** yararlanılmıştır. Projeye ASP.NET MVC'de bulunan 4 çeşit filtreleme eklenmiştir.

####Bunlar eklenme sırasıyla:
	- Action Filtresi
	- Result Filtresi
	- Exception Filtresi
	- Authorize Filtresi

## Filtrelerin Test Edilmesi

#### Action Filtresi:

İlk olarak **Log attribute**'u tanımlı sayfa açılır.
![alt tag](https://github.com/bsokat/FilterTypes/blob/master/Source/ActionFilter1.png)

Daha sonra logların tutulduğu **Log** sayfası açılır.
![alt tag](https://github.com/bsokat/FilterTypes/blob/master/Source/ActionFilter2.png)

Buradaki tip çeşitlerinden **Before**, action  çalışmadan hemen önce çalışan metodu yani **onActionExecuting** metodunun çalıştığını temsil eder.