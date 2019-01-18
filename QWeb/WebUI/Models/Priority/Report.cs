﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebUI.Models.Priority
{
    public class Report
    {
        [Display(Name = "Приоритет:")]
        public string PriorValue { get; set; }
        [Display(Name = "Количество дел в файле:")]
        public string FileCount { get; set; }
        [Display(Name = "Приоритет будет изменен для:")]
        public string WillUpdCount { get; set; }
        [Display(Name = "Приоритет изменен для:")]
        public string UpdatedCount { get; set; }
    }
}