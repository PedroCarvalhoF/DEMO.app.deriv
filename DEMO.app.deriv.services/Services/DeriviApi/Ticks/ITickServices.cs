﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace DEMO.app.deriv.services.Services.DeriviApi.Ticks
{
    public interface ITickServices
    {
        Task ObserveTicksAsync(string indice, CancellationToken cancellationToken, Action<double> onTickReceived);
    }
}