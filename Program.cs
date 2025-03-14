



using System;

const string numsDizisiKisitHatasi = "Girdi dizisi 2'den küçük, 10_000' den büyük olamaz";





TwoSum([3], 6);//kısıtlama kontrol-tek eleman
TwoSum([], 6);//kısıtlama kontrol-boş dizi
TwoSum([2, 7, 11, 58686], int.MaxValue);//kısıtlama kontrol-target 1 milyardan fazla

TwoSum([3, int.MaxValue], 6);//kısıtlama kontrol-elemanın biri 1 milyardan fazla





TwoSum([2, 7, 11, 15], 9);
TwoSum([3, 2, 4], 6);
TwoSum([3, 3], 6);
TwoSum([3, 3], 6);





static int[] TwoSum(int[] nums, int target)
{
    if (nums.Length < 2 || nums.Length > 10_000)
    {
        Console.WriteLine(numsDizisiKisitHatasi);
        return [];
    }
    int elemanAndTargetLimit = (int)Math.Pow(10, 9);

    if (target < -elemanAndTargetLimit || target > elemanAndTargetLimit)
    {
        string targetDizisiKisitHatasi = $"Hedef sayı {-elemanAndTargetLimit} ile {elemanAndTargetLimit} arasında olmalıdır.";
        Console.WriteLine(targetDizisiKisitHatasi);
        return [];
    }

    if (nums.Any(y => y < -elemanAndTargetLimit || y > elemanAndTargetLimit))
    {
        string targetDizisiKisitHatasi = $"Girdi Elemanları {-elemanAndTargetLimit} ile {elemanAndTargetLimit} arasında olmalıdır.";
        Console.WriteLine(targetDizisiKisitHatasi);
        return [];
    }  

    Dictionary<int,int> kume = new Dictionary<int,int>();
    //Kısıtlamalar doğruysa toplam işlemi
    for (int index = 0; index < nums.Length; index++)
    {
        int dizideAranilacakSayi = target - nums[index];//targettan mevcut dizi elemanını çıkaralım.
                                                        //Örneğin 500 target, şuanki dizi elemanı 100, 500-100 = 400 

        

        //Önce kümede dizide aranilacak sayi var mı diye kontrol ediyoruz
        if (kume.TryGetValue(dizideAranilacakSayi, out int value))
        {
            //burada hem eski varyasyonu hem yeniyi dönmem lazımdı yetiştiremedim
            Console.WriteLine($"[{value}, {index}]");//varsa dönüyoruz
            return [value, index];//varsa dönüyoruz
          
         
        }

        kume.Add(index, dizideAranilacakSayi);//yoksa küme dictionary'sine aralanilacak sayıyı ve indexi atıyoruz.





    }


    return [];
}
