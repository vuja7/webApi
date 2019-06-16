using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCommands
{
    public class EfCreatePatikaIgracCommand : ICreatePatikaIgracCommand
    {
        private readonly VujaResenjeContext _context;

        public EfCreatePatikaIgracCommand(VujaResenjeContext context)
        {
            _context = context;
        }

        public void Execute(CreatePatikaIgracDto request)
        {

            if (!_context.IgracIme.Any(c => c.IgracId == request.IgracId))
            {
                throw new EntityNotFoundException("IgracIme");
                //Message -> Customer doesnt exist
            }

            if (!_context.Model.Any(e => e.ModelId == request.ModelId))
            {
                throw new EntityNotFoundException("ModelIme");
                //Message -> Customer doesnt exist
            }

            if (request.ShipVia.HasValue)
            {
                if (!_context.Marka.Any(e => e.MarkaId == request.MarkaIme))
                {
                    throw new EntityNotFoundException("MarkaIme");
                    //Message -> Customer doesnt exist
                }
            }

            _context.PatikaIgrac.Add(new PatikeIgraci
            {
                IgracId = request.IgracId,
                PatikaId = request.PatikaId,
            });

            _context.SaveChanges();
        }
    }
}
