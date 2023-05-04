using Microsoft.Maui.Controls.Shapes;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace MauiGraph;

public partial class HeartPage : ContentPage
{
    public HeartPage()
	{
		InitializeComponent();
		Label1.Text = this.Width.ToString() + " " + this.Height.ToString();
		BindingContext = this;
    }

    private void PointerGestureRecognizer_PointerMoved(object sender, PointerEventArgs e)
    {
		Label1.Text = e.GetPosition(MyLayout).Value.ToString();
    }
}