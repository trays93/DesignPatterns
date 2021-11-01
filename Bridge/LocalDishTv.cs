namespace Bridge
{
    public class LocalDishTv : IVideoSource
    {
        private const string SOURCE_NAME = "Local DISH TV";

        public string GetTvGuide()
            => $"Getting TV guide from - {SOURCE_NAME}";

        public string PlayVideo()
            => $"Playing - {SOURCE_NAME}";
    }
}
