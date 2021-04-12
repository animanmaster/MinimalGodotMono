using Godot;
using Newtonsoft.Json;
public class Main : CanvasLayer
{
    class Data
    {
        public string test;
    }

    private Label ResultLabel { get => GetNode<Label>("CenterContainer/Data"); }

    public override void _Ready()
    {
        GD.Print("Starting to deserialize...");
        var result = JsonConvert.DeserializeObject<Data>("{\"test\": \"Hello world!\"}");
        GD.Print("Deserialized.");
        ResultLabel.Text = result.test;
    }
}
