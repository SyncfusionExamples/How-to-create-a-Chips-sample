# Getting Started for Xamarin.Forms Chips
This is demo application of Xamarin.Forms Chips control. The minimal set of required properties have been configured in this project to get started with Chips in Xamarin.Forms.

For more details please refer the Xamarin.Forms Chips UG documentation [Getting Started](https://help.syncfusion.com/xamarin/chips/getting-started) link.

## <a name="requirements-to-run-the-demo"></a>Requirements to run the demo ##

* [Visual Studio 2019 or Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/).
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## <a name="description"></a>Description ##

### Initialize Chips

Import the [`Chips`](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.html) namespace as shown below in your respective Page,

###### Xaml
```xaml
xmlns:buttons="clr-namespace:Syncfusion.XForms.Buttons;assembly=Syncfusion.Buttons.XForms"
```
###### C#
```C#
using Syncfusion.XForms.Buttons;
```

Create an instance of ViewModel class,and then set it as the `BindingContext`. Bind the `ItemsSource` property with a collection, and then set the `DisplayMemberPath` property:

###### Xaml
```xaml
<ContentPage
	xmlns="http://xamarin.com/schemas/2014/forms"
	xmlns:buttons="clr-namespace:Syncfusion.XForms.Buttons;assembly=Syncfusion.Buttons.XForms"
	xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
	xmlns:local="clr-namespace:Chips"
	x:Class="Chips.GettingStarted">
	<ContentPage.BindingContext>
		<local:ViewModel x:Name="viewModel"/>
	</ContentPage.BindingContext>
	<ContentPage.Content>
		<Grid>
			<buttons:SfChipGroup 
				ItemsSource="{Binding Employees}" 
				ChipPadding="8,8,0,0" 
				DisplayMemberPath="Name">
				<buttons:SfChipGroup.ChipLayout>
					<FlexLayout 
						HorizontalOptions="Start" 
						VerticalOptions="Center" 
						Direction="Row" 
						Wrap="Wrap"
						JustifyContent="Start"
						AlignContent="Start" 
						AlignItems="Start"/>
				</buttons:SfChipGroup.ChipLayout>
			</buttons:SfChipGroup>  
		</Grid>
	</ContentPage.Content>
</ContentPage>
```
###### C#
```C#
using Syncfusion.XForms.Buttons;
using System.Collections.ObjectModel;
using System.ComponentModel;
namespace Chips
{
	public partial class GettingStarted: ContentPage
	{
		public GettingStarted()
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
}
```

### Initialize view model

Now, let us define a simple data model that represents a data point in [`Chips`.](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.html)

```C#
public class Person   
{   
    public string Name { get; set; }
}
``` 

Next, create a view model class and initialize a list of `Person` objects as shown below,

```C#
public class ViewModel  
{
    public List<Person> Employees { get; set; }      

    public ViewModel()    
    {
        Employees = new List<Person>()
        {
            new Person { Name = "John" },
            new Person { Name = "James" },
            new Person { Name = "Linda" },
            new Person { Name = "Rose" },
            new Person { Name = "Mark" }
        }; 
    }
}
```

Set the `ViewModel` instance as the `BindingContext` of your Page; this is done to bind properties of `ViewModel` to [`Chips`.](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.html)

 Add namespace of `ViewModel` class in your XAML page if you prefer to set `BindingContext` in XAML.

## <a name="output"></a>Output ##

![Xamarin.Forms Getting_Started Chips image](Getting_Started_Chips_image.png)
