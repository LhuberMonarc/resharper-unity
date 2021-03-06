using JetBrains.ReSharper.FeaturesTestFramework.Completion;
using NUnit.Framework;

namespace JetBrains.ReSharper.Plugins.Unity.Tests.Feature.Services.CodeCompletion
{
    [TestUnity]
    public class UnityMessageCompletionActionTest : CodeCompletionTestBase
    {
        protected override CodeCompletionTestType TestType => CodeCompletionTestType.Action;
        protected override string RelativeTestDataPath => @"codeCompletion\Action";

        [Test] public void MonoBehaviour01() { DoNamedTest(); }
        [Test] public void MonoBehaviour02() { DoNamedTest(); }
        [Test] public void MonoBehaviour03() { DoNamedTest(); }
        [Test] public void MonoBehaviour04() { DoNamedTest(); }
        [Test] public void MonoBehaviour05() { DoNamedTest(); }
        [Test] public void MonoBehaviour06() { DoNamedTest(); }
    }
}