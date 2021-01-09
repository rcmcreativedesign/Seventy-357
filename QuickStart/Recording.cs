using System;
using System.Collections.ObjectModel;

namespace QuickStart
{
    public class Recording
    {
        public string ArtistName { get; set; }
        public string CompositionName { get; set; }
        public DateTime ReleaseDateTime { get; set; }
        public Recording()
        {
            this.ArtistName = "Wolfgang Amadeus Mozart";
            this.CompositionName = "Andante in C for Piano";
            this.ReleaseDateTime = new DateTime(1761, 1, 1);
        }
        public string OneLineSummary
        {
            get
            {
                return $"{this.CompositionName} by {this.ArtistName}, released: "
                    + this.ReleaseDateTime.ToString("d");
            }
        }
    }
    public class RecordingViewModel
    {
        private Recording defaultRecording = new Recording();
        public Recording DefaultRecording { get { return this.defaultRecording; } }
        private ObservableCollection<Recording> recordings = new ObservableCollection<Recording>();
        public ObservableCollection<Recording> Recordings { get { return recordings; } }
        public RecordingViewModel()
        {
            this.recordings.Add(new Recording()
            {
                ArtistName = "Johann Sebastian Bach",
                CompositionName = "Mass in B minor",
                ReleaseDateTime = new DateTime(1748, 7, 8)
            });
            this.recordings.Add(new Recording()
            {
                ArtistName = "Ludwig van Beethoven",
                CompositionName = "Third Symphony",
                ReleaseDateTime = new DateTime(1805, 2, 11)
            });
            this.recordings.Add(new Recording()
            {
                ArtistName = "George Frideric Handel",
                CompositionName = "Serse",
                ReleaseDateTime = new DateTime(1737, 12, 3)
            });
        }
    }

    public class StringFormatter : Windows.UI.Xaml.Data.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string formatString = parameter as string;
            if (!string.IsNullOrEmpty(formatString))
                return string.Format(formatString, value);
            return value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}