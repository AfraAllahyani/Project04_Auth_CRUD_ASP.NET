﻿//using finalProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Models
{
    public class CoursesModel
    {
        public int id { get; set; }
        public string subject { get; set; }
        public string imgurl { get; set; }

        public int ProfileId { get; set; }
        [ForeignKey("ProfileId")]
        public ProfileModel Profiles { get; set; }

        public List<Files_UploadedModel> Files { get; set; }
        public List<InfoModel> Information { get; set; }
    }
}
