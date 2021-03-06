﻿using System;
using System.Collections.Concurrent;
using System.Linq;
using TwitchLeecher.Services.Interfaces;

namespace TwitchLeecher.Services.Services.Download
{
    internal class DownloadService : IDownloadService
    {
        #region Fields

        private ConcurrentDictionary<Guid, Download> _downloads;

        #endregion Fields

        #region Constructors

        public DownloadService()
        {
            _downloads = new ConcurrentDictionary<Guid, Download>();
        }

        #endregion Constructors

        #region Properties

        public int Rate
        {
            get
            {
                return _downloads.Values.Sum(d => d.Rate);
            }
        }

        #endregion Properties
    }
}