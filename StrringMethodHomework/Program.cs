using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrringMethodHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vocable = "Yazılım";
            string sentence = "Bu bir ödev için örnek cümledir.";

            // length foksiyonu

            var length = sentence.Length; // length fonksiyonu burada bize  string'in karakter uzunluğunu int olarak verir.
            Console.WriteLine("length örneği: " + length);

            // concat fonksiyonu

           var concat = sentence.Concat(vocable).ToArray(); // concat fonksiyonu char formatında stringleri birleştirir.
           Console.WriteLine(concat);

            // toUpper fonksiyonu

            var upper = sentence.ToUpper();
            Console.WriteLine("upper örneği: " + upper); // upper fonksiyonu string değerin bütün harflarini büyük yaparak tekrardan string değer döndürür.

            //toLower fonksiyonu

            var lower = sentence.ToLower();
            Console.WriteLine("lower örneği: " + lower); // lower fonksiyonu string değerin bütün harflarini Küçük yaparak tekrardan string değer döndürür.

            //substring fonksiyonu

                    // substring fonksiyonunun 2 hali vardır.
            var substring = vocable.Substring(2); 
            Console.WriteLine("substring-1 örneği: " + substring); // Burada ilk karakter 0 baz alınacak şekilde hangi karakterden sonrasını almak istediğimizi belirtiyoruz.

            substring = vocable.Substring(1,5);
            Console.WriteLine("substring-2 örneği: " + substring ); // burada ise hangi karakterden başlayıp kaç karakter ilerisine kadar alacağımızı belirtiyoruz.

            //indexof fonksiyonu

                    // birden fazla kullanım şekli vardır.

            var indexof = vocable.IndexOf('ı'); //Bunlarıdan biri fonksiyona verdiğimiz karakterin ilk karakter 0 kabul edilecek şekilde ilk konumunu verir.
            Console.WriteLine("indexOf-1 örneği: " + indexof);

            indexof = vocable.IndexOf("ım"); // ikinci kullanımı fonksiyona verdiğimiz string'in ilk karakter 0 kabul edilecek şekilde ilk konumunu verir. Eğer belirtilen string içermiyorsa -1 değeri döndürür.
            Console.WriteLine("indexOf-2 örneği: " + indexof);

            indexof = vocable.IndexOf('ı',3); // ilk kullanımdan farklı olarak başlangıç konumu için ikinci bir parametre alır. 
            Console.WriteLine("indexOf-3 örneği: " + indexof);

            indexof = vocable.IndexOf("ız",3 ); // ikinci kullanımdan farklı olarak başlangıç konumu için ikinci bir parametre alır. 
            Console.WriteLine("indexOf-4 örneği: " + indexof);

            indexof = vocable.IndexOf('ı',2,2); 
            Console.WriteLine("indexOf-5 örneği: " + indexof);

            // lastindexof fonksiyonu

            var lastindexof = vocable.LastIndexOf('ı'); // indexof un tersten başlamış halidir. yani 0,1,2,3 şeklinde gitmek yerine 6-5-4-3 şeklinde gider.
            Console.WriteLine("lastindexof örneği: " + lastindexof);

            //contains fonksiyonu

            var contains = vocable.Contains("zı"); // String içinde belirtilen string var mı kontrol eder. bool değer döndürür. 
            Console.WriteLine("contains örneği: " + contains);

            // startswith fonksiyonu 

            var startswith = vocable.StartsWith("Y"); // string'in başlangıç harfini büyük küçük harfe dikkat ederek kontrol eder bool değer döndürür.
            Console.WriteLine("startwith örneği: " + startswith);

            // endsSwith fonksiyonu

            var endsSwith = vocable.StartsWith("Y"); // string'in son harfini büyük küçük harfe dikkat ederek kontrol eder bool değer döndürür.
            Console.WriteLine("endsSwith örneği: " + endsSwith);

            // replece fonksiyonu 

            var replece = vocable.Replace('ı','i'); // stirng değerde verilen 1.parametredeki karakterleri bulur ve 2. parametredeki ile değiştirir.
            Console.WriteLine("replece örneği: " + replece);

            // split fonksiyonu

            var split = sentence.Split(' '); // belirtilen karakterden stringki keser ve arraylist oluşturur.
            Console.WriteLine("split örneği: " + split);

            // trim fonksiyonu

            var trim = sentence.Trim(); // stringin başında ve sonunda bulunan boşlukları siler.
            Console.WriteLine("trim örneği : " + trim);

            // trimStart fonksiyonu

            var trimstart = sentence.TrimStart(); // stringin başında bulunan boşlukları siler.
            Console.WriteLine("trimstart örneği : " + trimstart);

            // trim fonksiyonu

            var trimend = sentence.TrimEnd(); // stringin sonunda bulunan boşlukları siler.
            Console.WriteLine("trim örneği : " + trimend);

            // format fonksiyonu ?????

            var format = string.Format("{0:C}", 10.50m);
            Console.WriteLine("format örneği: " + format);

            // join fonksiyonu

            var join = string.Join("ı", "k");
            Console.WriteLine("join örneği: " + join);


            Console.ReadKey();
            
        }
       
    }
}
