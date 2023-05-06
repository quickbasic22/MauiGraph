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

    private void MyButton_Clicked(object sender, EventArgs e)
    {
        // Create a new TransformGroup
        TransformGroup transformGroup = new TransformGroup();

        // Add your transforms to the group
        transformGroup.Children.Add(new TranslateTransform() { X = 700, Y = 25 });
        transformGroup.Children.Add(new ScaleTransform() { ScaleX = 6, ScaleY = 6 });

        // Set the RenderTransform property of MyPath
        MyPath.RenderTransform = transformGroup;

        // Iterate over the PathSegments and apply the TransformGroup
        foreach (PathSegment segment in MyPathFigure.Segments)
        {
            if (segment is BezierSegment)
            {
                BezierSegment bezierSegment = segment as BezierSegment;
                Point transformedPoint1 = transformGroup.Value.Transform(bezierSegment.Point1);
                Point transformedPoint2 = transformGroup.Value.Transform(bezierSegment.Point2);
                Point transformedPoint3 = transformGroup.Value.Transform(bezierSegment.Point3);
                Label1.Text += $"\n\r\n\rBezier Segment: ({transformedPoint1.X}, {transformedPoint1.Y}), ({transformedPoint2.X}, {transformedPoint2.Y}), ({transformedPoint3.X}, {transformedPoint3.Y})";
            }
            else if (segment is LineSegment)
            {
                LineSegment lineSegment = segment as LineSegment;
                Point transformedPoint = transformGroup.Value.Transform(lineSegment.Point);
                Label1.Text += $"\n\r\n\rLine Segment: ({transformedPoint.X}, {transformedPoint.Y})";
            }
        }



    }



}