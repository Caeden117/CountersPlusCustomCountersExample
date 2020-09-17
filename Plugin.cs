using IPA;

namespace CountersPlusNewCustomCountersTest
{
    [Plugin(RuntimeOptions.SingleStartInit)]
    public class Plugin
    {
        [Init]
        public Plugin() { }

        [OnStart]
        public void OnApplicationStart() { }

        [OnExit]
        public void OnApplicationQuit() { }
    }
}
