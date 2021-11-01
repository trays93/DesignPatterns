using System;

namespace Bridge
{
    public class MySuperSmartTV
    {
        IVideoSource _currentVideoSource = null;

        public IVideoSource VideoSource
        {
            get => _currentVideoSource;
            set { _currentVideoSource = value; }
        }

        public void PlayTV()
        {
            if (_currentVideoSource != null)
            {
                Console.WriteLine(_currentVideoSource.PlayVideo());
            }
            else
            {
                Console.WriteLine("Please select a Video Source to play");
            }
        }

        public void ShowTvGuide()
        {
            if (_currentVideoSource != null)
            {
                Console.WriteLine(_currentVideoSource.GetTvGuide());
            }
            else
            {
                Console.WriteLine("Please select a Video Source to get TV guide from");
            }
        }
    }
}
