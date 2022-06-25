﻿using System.Collections.Generic;
using JetBrains.Annotations;
using MediatR;
using Skateboard3Server.Blaze.Serializer.Attributes;
using Skateboard3Server.Blaze.Server;

namespace Skateboard3Server.Blaze.Handlers.Authentication.Messages;

[BlazeRequest(BlazeComponent.Authentication, (ushort)AuthenticationCommand.Dlc)]
[UsedImplicitly]
public record DlcRequest : BlazeRequestMessage, IRequest<DlcResponse>
{
    [TdfField("BUID")]
    public uint BlazeId { get; set; }

    [TdfField("EPSN")]
    public ushort Epsn { get; set; } //TODO

    [TdfField("EPSZ")]
    public ushort Epsz { get; set; } //TODO

    [TdfField("GNLS")]
    public List<string> Gnls { get; set; } //TODO

    [TdfField("OLD")]
    public bool Old { get; set; } //TODO

    [TdfField("ONLY")]
    public bool Only { get; set; } //TODO

    [TdfField("PERS")]
    public bool Pers { get; set; } //TODO
}