namespace Chapter.Command
{
    public class ToggleTurbo : Command
    {
        private C_BikeController _controller;

        public ToggleTurbo(C_BikeController controller)
        {
            _controller = controller;
        }

        public override void Execute()
        {
            _controller.ToggleTurbo();
        }
    }
}