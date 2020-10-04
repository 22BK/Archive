using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.OopDescriptions
{
    public class Descriptions : IGetDescription
    {
        public void GetDescription(string principleCode)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            
            switch (principleCode)
            {
                case "a": Console.WriteLine("Abstraction, gereksiz detayları göz ardı ederek ve bir amaç için neyin önemli olduğuna odaklanarak sınıfları tanımlama sürecidir.\nBelirli bir uygulama için neyin uygun olduğuna odaklanmak için gereksiz ayrıntıların soyutlanması ile ilgilenir.\nBuradan yola çıkacak olursak etrafımızda gördüğümüz her şey aslında abstraction’a dahildir.\n\n");
                    break;

                case "e": Console.WriteLine("Türkçe’de kapsülleme veya sarmalama olarak bilinen encapsulation prensibi class’ın property’lerini korumaya almasıdır.\nBu korumayı sağlamak için private ve protected access modifier’larını (erişim belirteci) kullanırız.\nEğer bir property’i tanımlarken private kullanırsak o class dışında hiçbir yerden erişim sağlanamaz.\nProtected kullanırsak da yalnızca subclass’lar ve aynı package’da bulunan classlar tarafından erişilir.\nEncapsulation prensibinin maksadı class’a ait property’lere her classın istediği gibi erişmesini ve değiştirmesini engellemektir.\n\n");
                    break;

                case "i": Console.WriteLine("Adından tahmin edilebileceği üzere herhangi bir class’ın üst class’larına ait olan method ve propertyleri kalıtım yoluyla almasıdır.\nGünlük hayattan bir örnekle anlaması çok daha kolay. Telefon adında bir class düşünelim.\nBu class tüm telefonlarda ortak olan bazı property’leri ve method’ları barındıracak. aramaYap(); mesajGonder(); methodları ve imeiNumber property’sini örnek verebiliriz.\nBu class’ın tüm alt class’ları bu methodları ve property’leri kullanabilecektir.\nBöylece AkilliTelefon ve TusluTelefon classlarını tanımlarken kalıtım yoluyla alınan bu property’leri ve method’ları tekrar tanımlamak zorunda kalmayacağız.\n\n");
                    break;

                case "p": Console.WriteLine("Basitçe polymorphism, tek bir metodun farklı işlevlere sahip olabileceği anlamına gelir.\nKullanıcıların farklı şekillerde çizmelerine olanak tanıyan bir program düşünün.Her şekil farklı şekilde çizilir ve kullanıcının hangi şekli seçeceğini bilmiyorsunuzdur.\nBurada, polymorphism, türetilmiş sınıfın uygunDrawmetodunu çağırmak için temel sınıfta aynı metodu geçersiz kılarak uygunDrawmetodunu çağırmak için kullanılabilir\nBu tür metotlar, temel sınıftavirtual anahtar sözcüğünü kullanarak bildirilmelidir.\n\n");
                    break;

                default:
                    break;
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
