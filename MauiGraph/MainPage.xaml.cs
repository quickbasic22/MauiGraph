using System.Diagnostics;

namespace MauiGraph;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();    
	}

    private void PointerGestureRecognizer_PointerMoved(object sender, PointerEventArgs e)
    {
        lblCoordinates.Text = e.GetPosition(MyGraphicsView).Value.ToString();       
    }
}

