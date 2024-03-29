﻿using System.Collections.Generic;

namespace uBlog.Entities.BlogEntities
{
    public class Question
    {       
        public int QuestionId { get; set; }

        public string Text { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
    }
}
