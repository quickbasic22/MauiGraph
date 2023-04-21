namespace MauiGraph;

public partial class MyShapes : ContentPage
{
	public MyShapes()
	{
		InitializeComponent();
	}

    private void Ellipse_Focused(object sender, FocusEventArgs e)
    {
		e.VisualElement.RotateXTo(45, 2000, Easing.CubicIn);
		e.VisualElement.ScaleTo(2, 2000, Easing.BounceIn);
    }
}