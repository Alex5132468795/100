using System.Collections.ObjectModel;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	public ObservableCollection<string> List1 { get; set; }
	VerticalStackLayout vsl;
	public MainPage()
	{
		List1 = new ObservableCollection<string> { "https://bipbap.ru/pictures/samye-krasivye-kartinki-35-foto.html", "https://www.google.com/imgres?imgurl=https%3A%2F%2Fimg.freepik.com%2Ffree-vector%2Fneon-lights-background-theme_52683-44625.jpg%3Fw%3D2000&imgrefurl=https%3A%2F%2Fru.freepik.com%2Ffree-photos-vectors%2Fbackground&tbnid=wYuBWlE7usuqIM&vet=12ahUKEwivuobdzqP6AhVL0YUKHVg8D6cQMygAegUIARDFAQ..i&docid=USwYxmSM3E7wKM&w=2000&h=1333&q=%D0%BA%D0%B0%D1%80%D1%82%D0%B8%D0%BD%D0%BA%D0%B8&ved=2ahUKEwivuobdzqP6AhVL0YUKHVg8D6cQMygAegUIARDFAQ" };
		BindingContext= this;
		InitializeComponent();
	}
	private void OnCounterClicked(object sender, EventArgs e)
	{
		List1.Add("https://www.google.com/imgres?imgurl=https%3A%2F%2Fimg.freepik.com%2Ffree-vector%2Fneon-lights-background-theme_52683-44625.jpg%3Fw%3D2000&imgrefurl=https%3A%2F%2Fru.freepik.com%2Ffree-photos-vectors%2Fbackground&tbnid=wYuBWlE7usuqIM&vet=12ahUKEwivuobdzqP6AhVL0YUKHVg8D6cQMygAegUIARDFAQ..i&docid=USwYxmSM3E7wKM&w=2000&h=1333&q=%D0%BA%D0%B0%D1%80%D1%82%D0%B8%D0%BD%D0%BA%D0%B8&ved=2ahUKEwivuobdzqP6AhVL0YUKHVg8D6cQMygAegUIARDFAQ");
	}
}

