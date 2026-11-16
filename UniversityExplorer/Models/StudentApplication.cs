using System.ComponentModel.DataAnnotations;

namespace UniversityExplorer.Models;

// Used to GET, POST and PUT applications, and for form validation
public class StudentApplication
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Student name is required")]
    public string StudentName { get; set; } = "";

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Enter a valid email address")]
    public string Email { get; set; } = "";

    [Required(ErrorMessage = "Country is required")]
    public string Country { get; set; } = "";

    [Required(ErrorMessage = "University name is required")]
    public string University { get; set; } = "";

    [Required(ErrorMessage = "Course name is required")]
    public string Course { get; set; } = "";

    [Required(ErrorMessage = "Application date is required")]
    public DateTime? ApplicationDate { get; set; } = DateTime.Today;

    public string? PersonalStatement { get; set; }
}