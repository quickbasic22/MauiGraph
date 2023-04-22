namespace MauiGraph;

public partial class PointerMover : ContentPage
{
	public PointerMover()
	{
		InitializeComponent();
        var gestureRecognizer = new PointerGestureRecognizer();
        gestureRecognizer.PointerMoved += OnPointerMoved;
        this.Content.GestureRecognizers.Add(gestureRecognizer);

        var gestureRecognizer2 = new PanGestureRecognizer();
        gestureRecognizer2.PanUpdated += OnPanUpdated;
        this.Content.GestureRecognizers.Add(gestureRecognizer);
    }

    private void OnPanUpdated(object sender, PanUpdatedEventArgs e)
    {
        Label theLabel = Grid1.FindByName<Label>("Cooridates");
        
        var message = $"X: {e.TotalX}, Y: {e.TotalY}";
        MainThread.BeginInvokeOnMainThread(() => theLabel.Text = message);
    }

    private void OnPointerMoved(object sender, PointerEventArgs e)
    {
        var coordinates = e.GetPosition(MyVertical).Value.ToString();
        var message = $"X: {e.GetPosition(MyVertical).Value.X}, Y: {e.GetPosition(MyVertical).Value.Y}";
        Label myLabel = Grid1.FindByName<Label>("Coordinates");
        MainThread.BeginInvokeOnMainThread(() => myLabel.Text = message);
    }
}