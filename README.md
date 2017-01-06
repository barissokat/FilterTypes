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

Action filtreleri, bir action çalışmadan hemen önce ya da hemen sonra çalışan filtredir. Oluşturulan filtre sınıfı, işlem yapılacak action'a attribute olarak tanımlandıktan sonra çalışmaya başlar.

İlk olarak **Log attribute**'u tanımlı sayfa açılır.

![alt tag](https://github.com/bsokat/FilterTypes/blob/master/Source/ActionFilter1.png)

Daha sonra logların tutulduğu **Log** sayfası açılır.

![alt tag](https://github.com/bsokat/FilterTypes/blob/master/Source/ActionFilter2.png)

Üstteki ekran görüntüsündeki tip çeşitlerinden **Before**, action'ın çalışmadan hemen önce çalışan metodu yani **onActionExecuting** metodunun çalıştığını temsil eder. onActionExecuting metodu **ActionExecutingContent** türünden bir nesne alır. Bu nesne ile işlem yapılan controller ve action bilgileri ile varsa action'a gönderilen parametrelere ulaşılabilinir.

Yine aynı ekran görüntüsündeki tip çeşitlerinden **After**, action'ın çalışmasını tamamlamasından hemen sonra çalışan metodu yani **onActionExecuted** metodunun çalıştığını temsil eder. onActionExecuted metodu **ActionExecutedContent** türünden bir nesne alır. Bu nesne ile işlem yapılan controller ve action bilgileri, action'un çalışması sırasında hata var mı bilgisi, oluşabilecek hatanın hata detayı, action çalışması sırasında iptal edildi mi bilgisi ile action'ın çalışması ardından geri dönen değer bilgilerine ulaşılabilinir.

> Action'a tanımlanan **Log attribute**, tek tek action'lara tanımlamam yerine controller içindeki tüm action'larda geçerli olması isteniyorsa, action yerine controller sınıfına tanımlanmalıdır.

#### Result Filtresi:

Result filtreleri, bir action çalıştıktan sonra geri dönüş verisinin derlenmeye başlamasından hemen önce ya da hemen sonrasında çalışan filtrelerdir. Oluşturulan filtre sınıfı, işlem yapılacak action'a attribute olarak tanımlandıktan sonra çalışmaya başlar.

İlk olarak **Log attribute**'u tanımlı sayfa açılır.

![alt tag](https://github.com/bsokat/FilterTypes/blob/master/Source/ResultFilter1.png)

Daha sonra logların tutulduğu **Log** sayfası açılır.

![alt tag](https://github.com/bsokat/FilterTypes/blob/master/Source/ResultFilter2.png)

Üstteki ekran görüntüsündeki tip çeşitlerinden **Before Result**, action'ın geri dönüş verisi işlenmeden hemen önce çalışan metodu yani **onResultExecuting** metodunun çalıştığını temsil eder. onResultExecuting metodu **ResultExecutingContent** türünden bir nesne alır. Bu nesne ile işlem yapılan controller bilgisi, action'ın geri dönüş değeri, sonucun çalışması sırasında hata var mı bilgisi, oluşabilecek hatanın hata detayı, sonucun çalışması sırasında iptal edildi mi bilgisi  ile **RouteData** ve **HttpContext** nesneleri bulunur.

Yine aynı ekran görüntüsündeki tip çeşitlerinden **After Result**, action'ın geri dönüş verisi işlenmeden hemen sonra çalışan metodu yani **onResultExecuted** metodunun çalıştığını temsil eder. onResultExecuted metodu **ResultExecutedContent** türünden bir nesne alır. Bu nesne ile işlem yapılan controller bilgisi, action'ın geri dönüş değeri, sonucun çalışması sırasında hata var mı bilgisi, oluşabilecek hatanın hata detayı, sonucun çalışması sırasında iptal edildi mi bilgisi  ile **RouteData** ve **HttpContext** nesneleri bulunur.