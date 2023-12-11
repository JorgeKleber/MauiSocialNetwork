using System.Runtime.CompilerServices;

namespace MauiSocialNetwork.Components;

public partial class CardViewApp : ContentView
{
	public CardViewApp()
	{
		InitializeComponent();
	}

	// Propriedade para definir a origem da imagem
	public static readonly BindableProperty ImageSourceProperty =
		BindableProperty.Create(nameof(ImageSource), typeof(ImageSource), typeof(CardViewApp), null);

	public ImageSource ImageSource
	{
		get { return (ImageSource)GetValue(ImageSourceProperty); }
		set { SetValue(ImageSourceProperty, value); }
	}

	// Propriedade para definir o texto da descrição
	public static readonly BindableProperty DescriptionTextProperty =
		BindableProperty.Create(nameof(DescriptionText), typeof(string), typeof(CardViewApp), string.Empty);

	public string DescriptionText
	{
		get { return (string)GetValue(DescriptionTextProperty); }
		set { SetValue(DescriptionTextProperty, value); }
	}

	protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		base.OnPropertyChanged(propertyName);

		if (propertyName == ImageSourceProperty.PropertyName)
			myImage.Source = ImageSource;

		if (propertyName == DescriptionTextProperty.PropertyName)
			mySubtitle.Text = DescriptionText;
	}
}