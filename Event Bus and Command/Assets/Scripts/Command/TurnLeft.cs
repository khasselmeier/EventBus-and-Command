namespace Chapter.Command
{
    public class TurnLeft : Command
    {
        private C_BikeController _controller;

        public TurnLeft(C_BikeController controller)
        {
            _controller = controller;
        }

        public override void Execute()
        {
            _controller.Turn(C_BikeController.Direction.Left);
        }
    }
}