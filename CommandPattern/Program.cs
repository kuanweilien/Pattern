using System;
namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleRemoteContorl remote = new SimpleRemoteContorl();
            Light light = new Light();
            LightOnCommand lightOn = new LightOnCommand(light);

            remote.SetCommand(lightOn);
            remote.btnPressed();
        }
    }
}
