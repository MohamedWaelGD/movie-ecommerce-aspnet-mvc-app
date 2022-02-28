using System.ComponentModel.DataAnnotations;

namespace MovieWeb.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }
        public string Name { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
        public Producer()
        {

        }
    }
}
