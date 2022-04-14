using System.ComponentModel.DataAnnotations;
namespace TetrisAPI.Models{
    public class TetrisModel{
        [Key]
        [Required]        
        public int Id {get;set;}
        [Required]   
        public string NickName { get; set; }
        [Required]
        public int Score { get; set; }
        public DateTime dateTime { get;set;}
    }
}