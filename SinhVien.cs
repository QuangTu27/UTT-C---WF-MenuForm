﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuForm
{
    internal class SinhVien
    {
        private int id;

        public int Id {  
            get { return id; } 
            set { id = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public SinhVien(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
