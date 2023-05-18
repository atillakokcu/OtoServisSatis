namespace OtoServisSatis.WebUI.Utils
{
    public class FileHelper
    {
        public static async Task<string> FileLoaderAsync(IFormFile formfile,string filePath="/Img/")
        {
            var FileName = "";

            if (formfile!=null && formfile.Length>0)
            {
                FileName = formfile.FileName;
                string directory = Directory.GetCurrentDirectory()+ "/wwwroot/"+ filePath+ FileName; // dosya yolunu oluşturduk./ Directory.GetCurrentDirectory() Uygulamanın çalıştığı dizini döndürür
                using var stream = new FileStream(directory, FileMode.Create); // dosya oluşturma için yaptık. bilgisayarımızdan seçtiğimiz bir dosyayı sunucumuza yollayacağız

                await formfile.CopyToAsync(stream);
            }

            return FileName;

        }


    }
}
// 1. Dosya var mı yok mu kontrol ettik
// 2. File name dosyanın file namene işaretledik
// 3. Kaydedilecek dosyayolunu oluşturduk
// 4. Filestream ile sunucuya yazılacak olan dosyanın işlemini oluşturduk
// 5. sunucuya soyayı kopyalarız
