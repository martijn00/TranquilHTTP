﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TranquilHTTP
{
    public interface IWebApiClient : IDisposable
    {
        string AcceptHeader { get; set; }
        IDictionary<string, string> Headers { get; }
        IHttpContentResolver HttpContentResolver { get; set; }
        IHttpResponseResolver HttpResponseResolver { get; set; }

        Task<TResult> GetAsync<TResult>(Priority priority, string path, CancellationToken? cancellationToken = null);

        Task<TResult> PostAsync<TContent, TResult>(Priority priority, string path, TContent content = default(TContent));
        Task<TResult> PutAsync<TContent, TResult>(Priority priority, string path, TContent content = default(TContent));
        Task<TResult> DeleteAsync<TContent, TResult>(Priority priority, string path, CancellationToken? cancellationToken = null);
    }
}