using SinglePageDemo.Debugging;

namespace SinglePageDemo
{
    public class SinglePageDemoConsts
    {
        public const string LocalizationSourceName = "SinglePageDemo";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "e6fb1e4820c943bc9ca72dde8d40d6b7";
    }
}
