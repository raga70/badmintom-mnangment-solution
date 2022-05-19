using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO;

public class Register
{
    [Required] public string username { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string password { get; set; }

    [Required] public string firstName { get; set; }
    [Required] public string lastName { get; set; }
    [Required] [DataType(DataType.Date)] public string birthdayDate { get; set; }
    [Required] public int gender { get; set; }

    [Required]
    [DataType(DataType.EmailAddress)]
    public string email { get; set; }

    [Required]
    [DataType(DataType.PhoneNumber)]
    public string phoneNumber { get; set; }
}