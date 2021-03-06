﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace VideoUploader
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// VideosWithData operations.
    /// </summary>
    public partial interface IVideosWithData
    {
        /// <param name='patientId'>
        /// </param>
        /// <param name='startTime'>
        /// </param>
        /// <param name='endTime'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PathfinderVideoUI>> GetWithHttpMessagesAsync(string patientId, string startTime, string endTime, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
