﻿using BlazorSozluk.Common.ViewModels;

namespace BlazorSozluk.Api.Domain.Models;

public class EntryVote : BaseEntity
{
    public Guid EntryId { get; set; }
    public VoteType VoteType { get; set; }
    public Guid CreatedById { get; set; }

    public virtual Entry Entry { get; set; }
}
