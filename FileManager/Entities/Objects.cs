﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FileManager.Entities
{
    public class Objects
    {
        // данные, которые будут вноситься в БД
        [Key]
        public int objectId { get; set; }
        public int userId { get; set; }
        public string objectName { get; set; }
        public bool type { get; set; } // 0 - файлы, 1 - директории
        public byte[] binaryData { get; set; }
        // использовал концепцию вложенных множеств, т.к. легче делать и меньше запросов к БД
        public int right { get; set; }
        public int left { get; set; }
        public User user { get; set; }
        public int level { get; set; }
    }
}
