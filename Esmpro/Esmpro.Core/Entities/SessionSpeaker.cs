﻿using CLTech.Core.Models;

namespace Esmpro.Core.Entities;

public class SessionSpeaker : EntityModel
{
    public long SessionId { get; set; }

    public Session? Session { get; set; }

    public long SpeakerId { get; set; }

    public Speaker? Speaker { get; set; }
}
