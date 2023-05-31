using System.ComponentModel.DataAnnotations;

namespace Task_API.ManualClasses
{
    public class MAddingTask
    {
        [Required(ErrorMessage = "Title is Required")]
        [MinLength(10, ErrorMessage = "AName must be at least 10 character long")]
        public string? TTitle { get; set; }

        [Required(ErrorMessage = "Description is Required")]
        [MinLength(10, ErrorMessage = "AName must be at least 100 character long")]
        public string? TDescription { get; set; }

        [Required(ErrorMessage = "StartDate is Required")]
        public DateTime? TStartDate { get; set; }

        [Required(ErrorMessage = "EndDate is Required")]
        public DateTime? TEndDate { get; set; }

        [Required(ErrorMessage = "File is Required")]
        public byte[]? TFile { get; set; }
    }
}
