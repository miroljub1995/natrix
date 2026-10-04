namespace Natrix.WebIDLGenerator.Tests.Tests;

public class TestPromisePropertiesTest() : BaseTest<TestPromiseProperties>("testPromiseProperties")
{
    [Test]
    public async Task TestPromisePropertyLong()
    {
        var sut = GetSut();

        var result = await sut.PromisePropertyLong;
        await Assert.That(result).IsEqualTo(42);

        sut.PromisePropertyLong = Task.FromResult(100);
        var newResult = await sut.PromisePropertyLong;
        await Assert.That(newResult).IsEqualTo(100);
    }

    [Test]
    public async Task TestPromisePropertyLongReadOnly()
    {
        var sut = GetSut();

        var result = await sut.PromisePropertyLongReadOnly;
        await Assert.That(result).IsEqualTo(84);
        await Assert.That(PropertyIsReadOnly(nameof(TestPromiseProperties.PromisePropertyLongReadOnly))).IsTrue();
    }

    [Test]
    public async Task TestPromisePropertyLongNullable()
    {
        var sut = GetSut();

        await Assert.That(sut.PromisePropertyLongNullable).IsNull();

        sut.PromisePropertyLongNullable = Task.FromResult(50);
        var result = await sut.PromisePropertyLongNullable!;
        await Assert.That(result).IsEqualTo(50);
    }

    [Test]
    public async Task TestPromisePropertyLongReadOnlyNullable()
    {
        var sut = GetSut();

        await Assert.That(sut.PromisePropertyLongReadOnlyNullableAsNull).IsNull();

        var result = await sut.PromisePropertyLongReadOnlyNullableAsNotNull!;
        await Assert.That(result).IsEqualTo(126);
    }

    [Test]
    public async Task TestPromisePropertyString()
    {
        var sut = GetSut();

        var result = await sut.PromisePropertyString;
        await Assert.That(result).IsEqualTo("hello");

        sut.PromisePropertyString = Task.FromResult("test");
        var newResult = await sut.PromisePropertyString;
        await Assert.That(newResult).IsEqualTo("test");
    }

    [Test]
    public async Task TestPromisePropertyStringReadOnly()
    {
        var sut = GetSut();

        var result = await sut.PromisePropertyStringReadOnly;
        await Assert.That(result).IsEqualTo("world");
        await Assert.That(PropertyIsReadOnly(nameof(TestPromiseProperties.PromisePropertyStringReadOnly))).IsTrue();
    }

    [Test]
    public async Task TestPromisePropertyLongDelayed()
    {
        var sut = GetSut();

        var promiseTask = (Task<int>)sut.PromisePropertyLongDelayed;
        await Assert.That(promiseTask.IsCompleted).IsFalse();

        // The timeout only bounds a broken run. A tight one races the browser's single
        // thread, which other tests in the run share, rather than the promise.
        var result = await promiseTask.WaitAsync(TimeSpan.FromSeconds(30));
        await Assert.That(result).IsEqualTo(99);
    }

    [Test]
    public async Task TestTaskToPromiseSetterWithContinueWith()
    {
        var sut = GetSut();

        await Assert.That(sut.TestTaskToPromiseValue).IsNull();

        // The test completes the task itself instead of racing a timer, so the result
        // does not depend on how busy the browser is.
        var source = new TaskCompletionSource();
        sut.TestTaskToPromise = source.Task.ContinueWith(_ => 17);

        // Give the browser a turn; the promise must stay pending until the task completes.
        await Task.Delay(50);
        await Assert.That(sut.TestTaskToPromiseValue).IsNull();

        source.SetResult();

        // The JavaScript side stores the value from a then() callback, which runs on a later
        // turn of the event loop. The deadline only bounds a broken run.
        var deadline = DateTime.UtcNow.AddSeconds(10);
        while (sut.TestTaskToPromiseValue is null && DateTime.UtcNow < deadline)
        {
            await Task.Delay(10);
        }

        await Assert.That(sut.TestTaskToPromiseValue).IsEqualTo(17);
    }
}