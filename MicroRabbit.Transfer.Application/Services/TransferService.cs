using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        //private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _bus;

        public TransferService(IEventBus bus)
        {
          //  _transferRepository = transferRepository;
            _bus = bus;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            var transferLogs = new List<TransferLog>();
            var transferLog = new TransferLog()
            {
                Id = 1,
                FromAccount = 1,
                ToAccount = 2,
                TransferAmount = 10
            };
            transferLogs.Add(transferLog);
            return transferLogs;
        }
    }
}
