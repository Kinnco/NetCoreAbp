using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace NetCoreAbp.Localization
{
    public static class NetCoreAbpLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(NetCoreAbpConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(NetCoreAbpLocalizationConfigurer).GetAssembly(),
                        "NetCoreAbp.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
