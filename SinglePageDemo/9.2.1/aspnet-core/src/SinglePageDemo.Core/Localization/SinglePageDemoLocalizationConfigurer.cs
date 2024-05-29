using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace SinglePageDemo.Localization
{
    public static class SinglePageDemoLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(SinglePageDemoConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(SinglePageDemoLocalizationConfigurer).GetAssembly(),
                        "SinglePageDemo.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
