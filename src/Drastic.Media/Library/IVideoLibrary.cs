// <copyright file="IVideoLibrary.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using Drastic.Media.Core.Model;

namespace Drastic.Media.Core.Library
{
    /// <summary>
    /// Video Library.
    /// </summary>
    public interface IVideoLibrary : IMediaLibrary
    {
        /// <summary>
        /// Fetches all VideoItems.
        /// </summary>
        /// <returns>VideoItem.</returns>
        Task<List<VideoItem>> FetchVideosAsync();
    }
}
