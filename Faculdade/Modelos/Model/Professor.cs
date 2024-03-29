﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Model
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Aniversario { get; set; }
        public decimal Salario { get; set; }

        [ForeignKey("DisciplinaFaculdade")]
        public int DisciplinaFaculdadeId { get; set; }
        public DisciplinaFaculdade DisciplinaFaculdade { get; set; }
    }
}
