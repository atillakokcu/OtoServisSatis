using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace OtoServisSatis.Entities
{
    public  class Marka:IEntitiy
    {
        public int Id { get; set; }

        [StringLength(50), Display(Name = "Adı"), Required(ErrorMessage = "{0} Boş bırakılamaz")]
        public string Adi { get; set; }
    }
}
