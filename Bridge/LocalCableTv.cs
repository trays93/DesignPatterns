namespace Bridge
{
    public class LocalCableTv : IVideoSource
    {
        private const string SOURCE_NAME = "Local Cable TV";

        public string GetTvGuide()
            => $"Getting TV guide from - {SOURCE_NAME}";

        public string PlayVideo()
            => $"Playing - {SOURCE_NAME}";
    }
}
