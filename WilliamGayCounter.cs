using CountersPlus.Counters.Custom;
using TMPro;
using UnityEngine;
using Zenject;

namespace CountersPlusNewCustomCountersTest
{
    class WilliamGayCounter : BasicCustomCounter, ITickable
    {
        private TMP_Text williamGayness;
        private ulong williamGay;

        public override void CounterInit()
        {
            var header = CanvasUtility.CreateTextFromSettings(Settings);
            header.text = "William Gay";
            header.fontSize = 3;

            williamGayness = CanvasUtility.CreateTextFromSettings(Settings, new Vector3(0, -0.4f, 0));
        }

        public override void CounterDestroy() { }

        public void Tick()
        {
            williamGay++;
            williamGayness.text = $"{williamGay}";
        }
    }
}
