﻿using Modelos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interface
{
    public interface IProfessor<T> : IPessoa where T : class
    {
        ICollection<T> Pesquisar(T t);
        T Guardar(T t);
        T Atualizar(T t);
        void Deletar(T t);
    }
}
