﻿using System;

namespace uBlog.BLL.DataTransferObjects
{
    public class ReviewDto
    {
        public int ReviewId { get; set; }

        public string AuthorName { get; set; }

        public string Text { get; set; }

        public DateTime PublishDate { get; set; }
    }
}
