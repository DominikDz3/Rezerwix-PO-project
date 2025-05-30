namespace Rezerwix_project.Forms
{
    // DTD do przekazywania danych
    public class EventCardViewModel
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public string Location { get; set; }
        public string Categories { get; set; }
    }

    public partial class EventCardControl : UserControl
    {
        private EventCardViewModel _eventData;
        public event EventHandler<int> DetailsClicked;

        public EventCardControl()
        {
            InitializeComponent();
            if (this.btnDetails != null)
            {
                this.btnDetails.Click += BtnDetails_Click;
            }
        }

        public void SetEventData(EventCardViewModel eventData)
        {
            _eventData = eventData;
            if (_eventData != null)
            {
                if (this.lblTitle != null) this.lblTitle.Text = _eventData.Title;
                if (this.lblDate != null) this.lblDate.Text = $"Data: {_eventData.StartDate:yyyy-MM-dd HH:mm}";
                if (this.lblLocation != null) this.lblLocation.Text = $"Miejsce: {_eventData.Location}";
                if (this.lblCategories != null) this.lblCategories.Text = $"Kategorie: {_eventData.Categories}";
            }
        }

        private void BtnDetails_Click(object sender, EventArgs e)
        {
            if (_eventData != null)
            {
                DetailsClicked?.Invoke(this, _eventData.EventId);
            }
        }
    }
}
