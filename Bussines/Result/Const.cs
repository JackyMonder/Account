using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Const
{
    internal class Const
    {
        [MetadataType(typeof(Account.MetaData))]
        public partial class Account
        {
            internal class MetaData
            {
                [Required]
                [MaxLength(50, ErrorMessage = "Username dài tối đa 50 ký tự")]
                public string Username;

                [Required]
                [MaxLength(50, ErrorMessage = "Password dài tối đa 50 ký tự")]
                public string Password;
            }
            public DateTime Last_Login { get; set; }
        }
    }
}
