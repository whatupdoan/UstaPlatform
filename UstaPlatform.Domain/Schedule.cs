namespace UstaPlatform.Domain
{
    public class Schedule
    {
        private readonly Dictionary<DateOnly, List<IsEmri>> _takvim = new();

        public List<IsEmri> this[DateOnly tarih]
        {
            get
            {
                if (!_takvim.ContainsKey(tarih))
                    _takvim[tarih] = new List<IsEmri>();

                return _takvim[tarih];
            }
        }
    }
}
