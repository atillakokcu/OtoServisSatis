using OtoServisSatis.Entities;

namespace OtoServisSatis.WebUI.Models
{
    public class HomePageViewModel // view'e hem silider ler hamde araçları göndermemiz gerekiyordu tek bir model içerisinde o yüzden bunu yaptık
    {
        public List<Slider> Sliders { get; set; }
        public List<Arac> Araclar { get; set; }



    }
}
