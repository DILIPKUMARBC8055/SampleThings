using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SampleThings.Models
{
    public class Admin
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }


        public string Password { get; set; }
    }
}
