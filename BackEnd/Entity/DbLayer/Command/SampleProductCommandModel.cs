using Core.CoreCommand;
using Core.EntityFrameworkRepository;
using MediatR;
using System;

namespace Entity.DbLayer.Command
{
    public class SampleProductCommandModel : CommandBase<Unit>, IEntity
    {

        public int SampleProductId { get; set; }

        public string SampleProdcutName { get; set; }

    }
}
