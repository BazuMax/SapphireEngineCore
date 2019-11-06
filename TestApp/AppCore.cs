using SapphireEngine;

namespace TestApp
{
    public class AppCore : SapphireType
    {
        public float Time = 0;
        public override void OnUpdate()
        {
            Time += DeltaTime;
            if (Time > 1)
            {
                Time -= 1;
                
                ConsoleSystem.Log("Kek");
            }
        }
    }
}