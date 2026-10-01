namespace Natrix.WebIDLGenerator.Tests.Tests;

public class TestUnionPropertiesTest() : BaseTest<TestUnionProperties>("testUnionProperties")
{
    [Test]
    public async Task TestBoolPropertyGet()
    {
        var sut = GetSut();

        await Assert.That(sut.Value).IsNotNull();
        await Assert.That(sut.Value.TryCast(out bool _)).IsFalse();
        await Assert.That(sut.Value.TryCast(out int val)).IsTrue();
        await Assert.That(val).IsEqualTo(3);
    }

    [Test]
    public async Task TestBoolPropertySet()
    {
        var sut = GetSut();

        sut.Value = true;

        await Assert.That(sut.Value.TryCast(out int _)).IsFalse();
        await Assert.That(sut.Value.TryCast(out bool val)).IsTrue();
        await Assert.That(val).IsEqualTo(true);
    }

    [Test]
    public async Task TestEnumMemberGet()
    {
        var sut = GetSut();

        await Assert.That(sut.EnumValue.TryCast(out int _)).IsFalse();
        await Assert.That(sut.EnumValue.TryCast(out TestEnumPropertiesEnum? val)).IsTrue();
        await Assert.That(val).IsEqualTo(TestEnumPropertiesEnum.Enum_value_2);
    }

    [Test]
    public async Task TestEnumMemberSet()
    {
        var sut = GetSut();

        sut.EnumValue = TestEnumPropertiesEnum.Enum_value_3;

        await Assert.That(sut.EnumValue.TryCast(out TestEnumPropertiesEnum? val)).IsTrue();
        await Assert.That(val).IsEqualTo(TestEnumPropertiesEnum.Enum_value_3);
    }

    [Test]
    public async Task TestCallbackMemberGet()
    {
        var sut = GetSut();

        await Assert.That(sut.CallbackValue.TryCast(out int _)).IsFalse();
        await Assert.That(sut.CallbackValue.TryCast(out TestCallbackPropertiesCallback? val)).IsTrue();
        await Assert.That(val).IsNotNull();
    }

    [Test]
    public async Task TestCallbackMemberSet()
    {
        var sut = GetSut();

        var receivedValue = 0;

        void Callback(int value)
        {
            receivedValue = value;
        }

        sut.CallbackValue = (TestCallbackPropertiesCallback)Callback;
        sut.CallCallbackValueOnSet = 42;

        await Assert.That(receivedValue).IsEqualTo(42);
    }
}
