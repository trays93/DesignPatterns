namespace Bridge
{
    public class IPTvService : IVideoSource
    {
        private const string SOURCE_NAME = "IP TV";

        public string GetTvGuide()
            => $"Getting TV guide from - {SOURCE_NAME}";

        public string PlayVideo()
            => $"Playing - {SOURCE_NAME}";
    }
}
