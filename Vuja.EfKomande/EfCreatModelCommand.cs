using System;
using System.Collections.Generic;
using System.Text;
using Vuja.Aplikacija.Commands;
using Vuja.Aplikacija.DataTransfer;
using Vuja.KomunikacijaSaBazom.Domains;

namespace Vuja.EfKomande
{
    public class EfCreatModelCommand : ICreateModelCommand
    {
        private readonly VujaNBApatikeContext _context;

        public EfCreatModelCommand(VujaNBApatikeContext context)
        {
            _context = context;
        }

        public void Execute(CreateModelDto request)
        {
            _context.Model.Add(new Model
            {
                BrendId = request.BrendId,
                IgracId = request.IgracId,
                ModelIme = request.ModelIme,
                ModelCena = request.ModelCena,
                ModelDatumIzlaska = request.ModelDatumIzlaska


            });

            _context.SaveChanges();
        }
    }
}
