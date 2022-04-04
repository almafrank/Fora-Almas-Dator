using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fora_Almas_Dator.Shared
{
    public class UserInterestModel
    {
        public int UserId { get; set; }
        public UserModel User { get; set; }
        public int InterestId { get; set; }
        public InterestModel Interest { get; set; }
    }
}
