﻿using System.Threading.Tasks;

namespace Brickweave.Cqrs.Cli
{
    public interface ICliDispatcher
    {
        Task<object> DispatchAsync(string commandText);
    }
}