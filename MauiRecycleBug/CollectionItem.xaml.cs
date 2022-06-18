using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MauiRecycleBug;

public partial class CollectionItem : ContentView
{
	public static int CreatedCount { get; private set; }
    public static int CollectedCount { get; private set; }

	public int InstanceId { get; }
	public CollectionItem()
	{
        InstanceId = ++CreatedCount;
		InitializeComponent();

		Debug.WriteLine($"Created CollectionItem. InstanceId: {InstanceId}. There are {CreatedCount-CollectedCount} instances allocated");
    }

	~CollectionItem()
	{
		Debug.WriteLine($"Collected CollectionItem. InstanceId: {InstanceId}. There are {CreatedCount - CollectedCount} instances allocated");
        CollectedCount++;
    }
}