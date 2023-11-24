using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage ="İsim alanı zorunludur...")]
        public string? Name { get; set; }
        [Required(ErrorMessage ="Telefon alanı zorunludur...")]
        [MaxLength(11)]
        [RegularExpression(@"^\d\d+$",ErrorMessage ="Telefon numarası için sadece rakam girilmelidir...")]
        public string? Phone { get; set; }
        [Required(ErrorMessage ="E posta alanı zorunludur...")]
        [EmailAddress(ErrorMessage ="Geçerli bir e posta adresi girin...")]
        public string? Email { get; set; }
        [Required(ErrorMessage ="Katılım durumu alanı zorunludur...")]
        public bool? WillAttend { get; set; }
    }
}