namespace Chapter.Command
{
    public class TurnRight : Command
    {
        private C_BikeController _controller;

        public TurnRight(C_BikeController controller)
        {
            _controller = controller;
        }

        public override void Execute()
        {
            _controller.Turn(C_BikeController.Direction.Right);
        }
    }
}