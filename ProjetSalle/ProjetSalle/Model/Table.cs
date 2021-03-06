﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSalle.Model
{
    class Table
    {
        public int NumTable { get; set; }

        public CustomerGroup ClientsOnTable { get; set; }

        public List<String> ElementsOnTable { get; set; }

        public EnumStatus StatusTable { get; set; }

        public int CapaciteTable { get; set; }
    }
}
