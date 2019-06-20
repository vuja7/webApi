using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vuja.Aplikacija.Commands;
using Vuja.Aplikacija.DataTransfer;
using Vuja.Aplikacija.Exceptions;
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
            if (!_context.Brend.Any(b => b.BrendId == request.BrendId))
            {
                throw new EntityNotFoundException("Brend");
                
            }

            if (!_context.Igrac.Any(i => i.IgracId == request.IgracId))
            {
                throw new EntityNotFoundException("Igrac");
                
            }
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
