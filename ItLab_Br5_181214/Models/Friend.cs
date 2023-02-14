using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ItLab_Br5_181214.Models
{
    public class Friend
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        [Range(0, 200, ErrorMessage = "Friends Id. must be between 0 and 200")]
        [Key]
        public int Friend_id { get; set; }
        [Required]
        public String Friend_name { get; set; }
        [Required]
        public String Place { get; set; }
        public Friend()
        {

        }

        public Friend(int fid, String fn, String pl)
        {
            Friend_id = fid;
            Friend_name = fn;
            Place = pl;
        }
    }
}