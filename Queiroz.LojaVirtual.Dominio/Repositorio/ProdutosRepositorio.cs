﻿using Queiroz.LojaVirtual.Dominio.Entidades;
using System.Collections.Generic;

namespace Queiroz.LojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
        private readonly EfDbContext _context = new EfDbContext();

        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }
        }


    }
}
