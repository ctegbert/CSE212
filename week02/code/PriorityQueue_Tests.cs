using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{

public class PriorityQueueItem<T>
{
    public T Value { get; }
    public int Priority { get; }

    public PriorityQueueItem(T value, int priority)
    {
        Value = value;
        Priority = priority;
    }
}
public class PriorityQueue<T>
{
    private readonly List<PriorityQueueItem<T>> _items;

    public PriorityQueue()
    {
        _items = new List<PriorityQueueItem<T>>();
    }

    public void Enqueue(T value, int priority)
    {
        var newItem = new PriorityQueueItem<T>(value, priority);
        _items.Add(newItem);
    }

    public T Dequeue()
    {
        if (_items.Count == 0)
        {
            throw new InvalidOperationException("The queue is empty.");
        }
        int maxIndex = 0;
        for (int i = 1; i < _items.Count; i++)
        {
            if (_items[i].Priority > _items[maxIndex].Priority)
            {
                maxIndex = i;
            }
        }
        var item = _items[maxIndex];
        _items.RemoveAt(maxIndex);
        return item.Value;
    }
}

[TestMethod]
public void TestPriorityQueue_1()
{
    var priorityQueue = new PriorityQueue<string>();
    priorityQueue.Enqueue("Item1", 1);
    priorityQueue.Enqueue("Item2", 2);
    priorityQueue.Enqueue("Item3", 3);

    // Expected Result: "Item3" should be dequeued first because it has the highest priority.
    string result = priorityQueue.Dequeue();
    Assert.AreEqual("Item3", result);
}

[TestMethod]
public void TestPriorityQueue_2()
{
    var priorityQueue = new PriorityQueue<string>();
    priorityQueue.Enqueue("Item1", 1);
    priorityQueue.Enqueue("Item2", 1); // Same priority as Item1
    priorityQueue.Enqueue("Item3", 2);

    // Expected Result: "Item3" should be dequeued first, then Item1.
    Assert.AreEqual("Item3", priorityQueue.Dequeue());
    Assert.AreEqual("Item1", priorityQueue.Dequeue());
}

    // Add more test cases as needed below.
}