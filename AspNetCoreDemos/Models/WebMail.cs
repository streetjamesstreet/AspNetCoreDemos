﻿using System;

namespace AspNetCoreDemos.Models
{
    public class WebMail
    {
        public int MailID { get; set; }

        public int FromID { get; set; }

        public string From { get; set; }

        public string Date { get; set; }

        public string Title { get; set; }
    }
}