using CoreLayer.CoreCommand;
using CoreLayer.EntityFrameworkRepository;
using System;

namespace EntityLayer.DbLayer.Command
{
    public class SampleProductCommandModel : CommandBase<Guid>, IEntity
    {

        public int SampleProductId { get; set; }

        public string SampleProdcutName { get; set; }

    }
}
