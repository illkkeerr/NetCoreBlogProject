﻿using BlogCore.Entities;

namespace BlogEntity.Entities
{
    public class Image:EntityBase
    {
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public ICollection<Article> Articles { get; set; }  
    }
}
