using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSimpleExample.Models
{
  public class Etudiant
  {
    public int Id { get; set; }

    [Required]
    public string LastName { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    [Range(18,40)]
    public int Age { get; set; }
    public string Section { get; set; }

    public DateTime Birthdate { get; set; }
  }
}
