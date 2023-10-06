namespace CollectionOfButtons
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;
        }

        private List<string> _stringList = new List<string>{"How now brown cow", "The quick brown fox jumps over the lazy dog", "Random text", "Four score and seven years ago our fathers brought forth on this continent, a new nation" };
        public List<string> StringList { get { return _stringList; } }
    }
}
