﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PrestoStore.Common.Entities
{
    public class City
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage ="The field {0} must contain less than {1} characteres")]
        [Required]
        public string Name { get; set; }
    }

}