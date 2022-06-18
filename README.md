# MauiRecycleBug

This sample demonstrates the CollectionView not recycling properly in WinUI.

### Repro:

Create a CollectionView  
Fill it with items  
Scroll up and down in the CollectionView  
Watch the Debug output.

### Android

A small number of CollectionItem instances are created and these are recycled.  
Example Debug output:  
*Created CollectionItem. InstanceId: 12. There are 12 instances allocated*  

### WinUI

A new CollectionItem is created every time an instance scrolls into view.  
Example Debug output:  
Created CollectionItem. InstanceId: 133. There are 133 instances allocated  

Scrolling quickly to the end and back (e.g. by dragging the scroll-bar) causes a crash  
  

Scrolling slowly can eventually instigate an item being garbage-collected  
Example Debug output:  
*Collected CollectionItem. InstanceId: 9. There are 129 instances allocated* 

**Related:** The DataTemplate has a CheckBox.  
1. The CheckBox is rendered incorrectly until the Window is resized horizontally.
    1. Should I open a new bug for this?
1. Having the CheckBox present in the DataTemplate causes a LOT of memory to be consumed.
    1. Is this also a bug?


