using PersonalLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLibrary.View
{
    public enum Operation { CANCEL, CREATE, UPDATE, DELETE };
    public class UIState
    {
        public Object LastModified { get; set; }
        public int? LastModifiedId { get; set; }
        public Operation LastOperation { get; set; }
        public User LoggedInUser { get; set; }
        
    }
}
