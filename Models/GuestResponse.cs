using System.ComponentModel.DataAnnotations;


namespace MvcMovie.Models

{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please enter your Arrival Time")]
        public string Time { get; set; }

        [Required(ErrorMessage = "Do you want parking?")]
        public bool Parking { get; set; }
    }
}
