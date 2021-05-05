using Brewsty.DataAccess;
using Brewsty.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brewsty.Bll
{
    public class BrewstyService
    {
        public Beer Beer { get; set; }

        private BrewstyUnitOfWork uow;

        public void Create(Beer beer)
        {
            
        }
    }
}
