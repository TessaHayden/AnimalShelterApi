using System.ComponentModel.DataAnnotations;
using Microsoft.Build.Framework;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace AnimalShelterApi.Auth
{
  public class RegisterModel
  {
    public int UserId { get; set; }
    [Required(ErrorMessage = "User Name is required")]
    public string Username { get; set; }
    [EmailAddress]
    [Required(ErrorMessage = "Email is required")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Password is Required")]
    public string Password { get; set; }
  }
}