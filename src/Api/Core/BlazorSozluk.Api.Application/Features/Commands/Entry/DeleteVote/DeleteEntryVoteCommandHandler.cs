﻿using BlazorSozluk.Common.Infrastructure;
using BlazorSozluk.Common;
using MediatR;
using BlazorSozluk.Common.Events.Entry;

namespace BlazorSozluk.Api.Application.Features.Commands.Entry.DeleteVote;

public class DeleteEntryVoteCommandHandler : IRequestHandler<DeleteEntryVoteCommand, bool>
{
    public async Task<bool> Handle(DeleteEntryVoteCommand request, CancellationToken cancellationToken)
    {
        QueueFactory.SendMessageToExchange(exchangeName: SozlukConstants.VoteExchangeName,
            exchangeType: SozlukConstants.DefaultExchangeType,
            queueName: SozlukConstants.DeleteEntryVoteQueueName,
            obj: new DeleteEntryVoteEvent()
            {
                EntryId = request.EntryId,
                CreatedBy = request.UserId
            });

        return await Task.FromResult(true);
    }
}

