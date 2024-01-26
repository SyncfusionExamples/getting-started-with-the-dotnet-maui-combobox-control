# Getting Started with the .NET MAUI ComboBox Control

The [.NET MAUI ComboBox](https://www.syncfusion.com/maui-controls/maui-combobox?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples) control is a selection component that allows users to type a value or choose an option from a list of predefined options. This article shows how to create and configure the Syncfusion .NET MAUI ComboBox control. This project also includes a code snippet to populate the control’s data source, set a custom height and width to the control, customize placeholder text, change the filter type, and hide clear button.

### Adding the .NET MAUI ComboBox control

**Step 1**: Add the NuGet to the project and add the namespace as shown in the following code sample:

**[XAML]**
```
    xmlns:editors="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"
```	

**[C#]**
```
    using Syncfusion.Maui.Inputs;
```

**Step 2**: Set the ComboBox control to content in `ContentPage.`

**[XAML]**
```
<ContentPage.Content>    
    <editors:SfComboBox x:Name="comboBox" />
</ContentPage.Content>
```	

**[C#]**
```
          
SfComboBox comboBox = new SfComboBox(); 
Content = comboBox;  
```

### Populating items using data binding

**Step 1**: Create a model class named SocialMedia that contains information such as social media's ID and name. And generate the collection of social media data in the ViewModel class.

```
//Model.cs
public class SocialMedia
{
    public string Name { get; set; }
    public int ID { get; set; }
}

//ViewModel.cs
public class SocialMediaViewModel
{
    public ObservableCollection<SocialMedia> SocialMedias { get; set; }
    public SocialMediaViewModel()
    {
        this.SocialMedias = new ObservableCollection<SocialMedia>();
        this.SocialMedias.Add(new SocialMedia() { Name = "Facebook", ID = 0 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Google Plus", ID = 1 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Instagram", ID = 2 });
        this.SocialMedias.Add(new SocialMedia() { Name = "LinkedIn", ID = 3 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Skype", ID = 4 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Telegram", ID = 5 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Televzr", ID = 6 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Tik Tok", ID = 7 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Tout", ID = 8 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Tumblr", ID = 9 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Twitter", ID = 10 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Vimeo", ID = 11 });
        this.SocialMedias.Add(new SocialMedia() { Name = "WhatsApp", ID = 12 });
        this.SocialMedias.Add(new SocialMedia() { Name = "YouTube", ID = 13 });
    }
}
```

**Step 2**: Binding the SocialMedias property to the ItemsSource property of `ComboBox`.

**[XAML]**

```
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:editors="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"
             xmlns:local="clr-namespace:ComboBoxSample"             
             x:Class="ComboBoxSample.MainPage">

       <ContentPage.BindingContext>
            <local:SocialMediaViewModel />
       </ContentPage.BindingContext>

       <ContentPage.Content>
            <!--Setting ItemsSource-->
            <editors:SfComboBox x:Name="comboBox" 
                                WidthRequest="250"
                                ItemsSource="{Binding SocialMedias}" />
        </ContentPage.Content>
</ContentPage>
```

## Project pre-requisites

Make sure that you have the compatible versions of Visual Studio with .NET MAUI workloads and .NET SDK version in your machine before starting to work on this project. Refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements).

## How to run this application?

To run this application, you need to first clone the getting-started-with-the-dotnet-maui-combobox-controls repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.

## Features and Benefits

### Selection
Users can select an item, or [multiple](https://help.syncfusion.com/maui/combobox/selection#multiple-selection?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples) items, from the list of options by tapping or clicking it.

### Searching
The first item that fits the user input is highlighted in the dropdown list. Highlighting matching text in the ComboBox dropdown list makes it easy for users to identify and select the items they are looking for at a glance.

### Placeholder
Display hints using [placeholder](https://help.syncfusion.com/maui/combobox/ui-customization#placeholder?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples) text when no item is selected. A well-designed placeholder enhances the user experience by providing context and making the control more intuitive.

### Filtering
The ComboBox [filters](https://help.syncfusion.com/maui/combobox/filtering?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples) items based on the entered text and auto-fills with the first suggestion.

### Data binding
Data-binding support works for all popular data sources and displays data based on the display member path. It automatically generates items from a data-bound collection. The application can be designed in the MVVM pattern.

## Related links
[Learn More about .NET MAUI ComboBox](https://www.syncfusion.com/maui-controls/maui-combobox?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples)

[Download Free Trial](https://www.syncfusion.com/downloads/maui?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples)

[Pricing](https://www.syncfusion.com/sales/teamlicense?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples)

[Documentation](https://help.syncfusion.com/maui/combobox/getting-started?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples)

[View Demos](https://github.com/SyncfusionExamples/getting-started-with-the-dotnet-maui-combobox-control?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples)

[Community Forums](https://www.syncfusion.com/forums/maui?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples)

[Suggest a feature or report a bug](https://www.syncfusion.com/feedback/maui?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples)

[Online example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/Inputs/SampleBrowser.Maui.Inputs/Samples/ComboBox?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples)

## About Syncfusion .NET MAUI Controls

Syncfusion's [.NET MAUI UI Controls](https://www.syncfusion.com/maui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples) library is the only suite that you will ever need to build an application since it contains over 40 high-performance, lightweight, modular, and responsive UI Controls in a single package. In addition to ComboBox, we provide popular .NET MAUI Controls such as [DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples)[Charts](https://www.syncfusion.com/maui-controls/maui-cartesian-charts?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples), [Scheduler](https://www.syncfusion.com/maui-controls/maui-scheduler?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples), [ListView](https://www.syncfusion.com/maui-controls/maui-listview?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples), and [Excel Library](https://www.syncfusion.com/document-processing/excel-framework/maui?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples).

### About Syncfusion
Founded in 2001 and headquartered in Research Triangle Park, N.C., Syncfusion has more than 29,000 customers and more than 1 million users, including large financial institutions, Fortune 500 companies, and global IT consultancies.

Today, we provide 1800+ components and frameworks for web ([Blazor](https://www.syncfusion.com/blazor-components?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples), [ASP.NET Core](https://www.syncfusion.com/aspnet-core-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples), [ASP.NET MVC](https://www.syncfusion.com/aspnet-mvc-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples), [ASP.NET WebForms](https://www.syncfusion.com/jquery/aspnet-webforms-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples), [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples), [Angular](https://www.syncfusion.com/angular-components?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples), [React](https://www.syncfusion.com/react-components?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples), [Vue](https://www.syncfusion.com/vue-components?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples), and [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples)), mobile ([Xamarin](https://www.syncfusion.com/xamarin-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples), [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples), [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples), and [.NET MAUI](https://www.syncfusion.com/maui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples)), and desktop development ([WinForms](https://www.syncfusion.com/winforms-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples), [WPF](https://www.syncfusion.com/wpf-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples), [WinUI](https://www.syncfusion.com/winui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples),[UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples), and [.NET MAUI](https://www.syncfusion.com/maui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples)). We provide ready-to-deploy enterprise software for dashboards, reports, data integration, and big data processing. Many customers have saved millions in licensing fees by deploying our software.

<hr style="height:0.3px;border:none;color:lightgrey;background-color:lightgrey;" />

<p align="center">
<a href="mailto:sales@syncfusion.com?Subject=Syncfusion .NET MAUI ComboBox - GitHub" target="_top">sales@syncfusion.com</a> | <a href="https://www.syncfusion.com?utm_source=github&utm_medium=listing&utm_campaign=maui-combobox-github-samples">www.syncfusion.com</a> | Toll Free: 1-888-9 DOTNET <br>
</p>
