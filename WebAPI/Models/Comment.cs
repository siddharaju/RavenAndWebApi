﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string CommentText { get; set; }
        public DateTime PostedOn { get; set; }
    }
}