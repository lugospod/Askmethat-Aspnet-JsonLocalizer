﻿using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Localization;
using System;
using System.Globalization;
using System.Text;

namespace Askmethat.Aspnet.JsonLocalizer.Extensions
{
    public class JsonLocalizationOptions : LocalizationOptions
    {

        const char PLURAL_SEPARATOR = '|';
        const string DEFAULT_RESOURCES = "Resources";
        const string DEFAULT_CULTURE = "en-US";
        
        public new string ResourcesPath { get; set; } = DEFAULT_RESOURCES;
        public TimeSpan CacheDuration { get; set; } = TimeSpan.FromMinutes(30);
        public IMemoryCache Caching { get; set; } = new MemoryCache(new MemoryCacheOptions
        {
        });
        public CultureInfo DefaultCulture { get; set; } = new CultureInfo(DEFAULT_CULTURE);

        public bool IsAbsolutePath { get; set; } = false;

        public Encoding FileEncoding { get; set; } = Encoding.UTF8;

        public bool UseBaseName { get; set; } = false;
        public char PluralSeparator { get; set; } = PLURAL_SEPARATOR;
    }
}
