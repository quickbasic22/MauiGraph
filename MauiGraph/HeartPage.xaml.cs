namespace MauiGraph;

public partial class HeartPage : ContentPage
{
	public HeartPage()
	{
		InitializeComponent();
		Label1.Text = this.Width.ToString() + " " + this.Height.ToString();
	}

    private void PointerGestureRecognizer_PointerMoved(object sender, PointerEventArgs e)
    {
		Label1.Text = e.GetPosition(MyGrid).Value.ToString();

    }
}