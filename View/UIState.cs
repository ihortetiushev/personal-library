using PersonalLibrary.Models;
using System;

namespace PersonalLibrary.View
{
    public enum Operation { CANCEL, CREATE, UPDATE, DELETE, SELECTION };
    public class UIState
    {
        public Object LastModified { get; set; }
        public int? LastModifiedId { get; set; }
        public Operation LastOperation { get; set; }
        public User LoggedInUser { get; set; }
        
    }
}
