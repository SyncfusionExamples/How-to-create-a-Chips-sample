using Syncfusion.XForms.Buttons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Grid grid = new Grid();
            SfChipGroup chipGroup = new SfChipGroup();
            grid.Children.Add(chipGroup);
            FlexLayout layout = new FlexLayout()
            {
                Direction = FlexDirection.Row,
                Wrap = FlexWrap.Wrap,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center,
                AlignContent = FlexAlignContent.Start,
                JustifyContent = FlexJustify.Start,
                AlignItems = FlexAlignItems.Start,
            };
            chipGroup.ChipLayout = layout;
            this.BindingContext = new ViewModel();
            chipGroup.SetBinding(SfChipGroup.ItemsSourceProperty, "Employees");
            chipGroup.DisplayMemberPath = "Name";
            chipGroup.ChipPadding = new Thickness(8, 8, 0, 0);
            this.Content = grid;
        }
    }

    public class Person
    {
        public string Name
        {
            get;
            set;
        }
    }
    public class ViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<Person> employees;
        public ObservableCollection<Person> Employees
        {
            get
            {
                return employees;
            }
            set
            {
                employees = value;
                OnPropertyChanged("Employees");
            }
        }

        public ViewModel()
        {

            Employees = new ObservableCollection<Person>()
            {
                new Person { Name = "John" },
                new Person { Name = "James" },
                new Person { Name = "Linda" },
                new Person { Name = "Rose" },
                new Person { Name = "Mark" }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
