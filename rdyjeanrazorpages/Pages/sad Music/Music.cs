using System.ComponentModel.DataAnnotations;
namespace rdyjeanrazorpages.Pages.Jane
{
    public class Class
    {
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime no { get; set; }
        public string sad { get; set; } = string.Empty;
        public decimal about { get; set; }
    }
}
