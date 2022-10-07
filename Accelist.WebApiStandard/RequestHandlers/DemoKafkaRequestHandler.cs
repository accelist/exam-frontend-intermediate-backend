﻿using Accelist.WebApiStandard.Contracts.RequestModels;

namespace Accelist.WebApiStandard.RequestHandlers
{
    public class DemoKafkaRequestHandler : RequestHandlerBase<DemoKafkaRequest>
    {
        public override Task Handle(DemoKafkaRequest request, CancellationToken cancellationToken)
        {
            Console.WriteLine(request.A + request.B);
            return Task.CompletedTask;
        }
    }
}
