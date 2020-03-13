﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Aniversario { get; set; }
        public decimal Salario { get; set; }
        public DisciplinaFaculdade DisciplinaFaculdade { get; set; }
    }
}
