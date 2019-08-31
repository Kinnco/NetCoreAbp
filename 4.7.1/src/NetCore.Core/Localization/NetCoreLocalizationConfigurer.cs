using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace NetCore.Localization
{
    public static class NetCoreLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(NetCoreConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(NetCoreLocalizationConfigurer).GetAssembly(),
                        "NetCore.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
