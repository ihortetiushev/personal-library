using System;
using System.Collections.Generic;

namespace PersonalLibrary.Models
{
    public class Literature
    {
        public int LiteratureId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Publisher { get; set; }
        public DateTime? PublishDate { get; set; }
        public DateTime? OriginDate { get; set; }
        public string OriginComment { get; set; }
        public int? OriginId { get; set; }
        public bool IsAvailable { get; set; }
        public string Comment { get; set; }
        public List<Author> Authors{ get; set; }
        public string CategoryName { get; set; }
        public string GetAuthorsAsString() 
        {
            if (Authors == null) 
            {
                return "";
            }
            List<string> names = new List<string>();
            foreach (Author author in Authors)
            {
                names.Add(author.FirstName + " " + author.LastName);
            }
            return string.Join(";", names.ToArray());
        }
    }
}
