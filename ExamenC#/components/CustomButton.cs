using ExamenC_.models;

namespace ExamenC_.components
{
    public class CustomButton : Button
    {
        public CustomObject ObjectReference { get; set; }
        public CustomButton(CustomObject obj)
        {
            ObjectReference = obj;
            Click += OnClick;
            Name = $"Button_{obj.Id}";
            Text = obj.Name;
        }
        private void OnClick(object sender, EventArgs e)
        {

        }
    }
}
