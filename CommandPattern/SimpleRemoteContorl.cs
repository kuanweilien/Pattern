namespace CommandPattern
{
    public class SimpleRemoteContorl
    {
        ICommand solt;
        public SimpleRemoteContorl(){}
        public void SetCommand(ICommand cmd)
        {
            solt = cmd;
        }
        public void btnPressed()
        {
            solt.execute();
        }
    }
}