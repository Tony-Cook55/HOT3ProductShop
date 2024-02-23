using System.ComponentModel.DataAnnotations;

namespace ProductShop.Models
{
    public class Record
    {

        // Read-Only Property for the /slug in the Program.cs file   This Shows the ArtistName and the RecordName
        public string Slug => ArtistName?.Replace(" ", "-").ToLower() + "-" + RecordName?.Replace(" ", "-").ToLower() + "-" /*+ Price?.ToString()*/;


        //Primary Key
        public int RecordId { get; set; }



        [Required(ErrorMessage = "Please Enter a The Records Name")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Record Names Must Have At Least 1 to 100 Characters")]
        public string? RecordName { get; set; } = string.Empty;


        [Required(ErrorMessage = "Please Enter The Artists Name")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Artist's Names Must Have At Least 1 to 100 Characters")]
        public string? ArtistName { get; set; } = string.Empty;


        [Required(ErrorMessage = "Please Enter a Price")]
        [Range(1, 100000, ErrorMessage = "Price Must be Above $1 to $1,000,000 ")]
        public decimal? Price { get; set; }


        public string? ImageFileName { get; set; }



    }
}
