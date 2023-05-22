// See https://aka.ms/new-console-template for more information
using Learnings.Delegate;
using Learnings.Demo;
using Learnings.DSA;
using Learnings.DSA.LinkedList;
using Learnings.SampleProblems;
using Learnings.OOP.Abstract;
using Learnings.SampleTask.XML;
using Learnings.SampleTask.FileHandling;
using Learnings.SampleTask.FileHandling.Serialization;
using System.Reflection;
using Learnings.Inheritance;
using Learnings.Threading;
using Learnings.Sample;
using System.Net.Sockets;


// create a simple class 
// func - read a file and return the content back 
//File data streaming from various forms  ?? 
// interfaces in unit testing ?? 

// employee 
//     Address and Name 

string filePath = Console.ReadLine();
StreamFile objStreamFile = new StreamFile(filePath);
string fileData = objStreamFile.ReadFileData();
Console.WriteLine(fileData);

//swap 2 numbers 
int num1 = 1;
int num2 = 2;
int swapNum1 = 0;
int swapNum2 = 0;
objStreamFile.SwapNumbers(num1, num2, ref swapNum1, ref swapNum2);


if (false)
{
    Multithreading objMultithreading = new Multithreading();
    //objMultithreading.ThreadingCall();
    objMultithreading.CallBackSample();
}

var sample = Console.ReadLine();

Console.WriteLine("Sample" + $"{sample}");

//int count = typeof(GrlUsbPdControllerLib.DataStreamService).GetMethods().Count();
int count = typeof(Learnings.Delegate.DelegateClass).GetMethods().Count();
var data = typeof(Learnings.Delegate.DelegateClass).GetMethods().ToList();
var actualData = data.Where(x => x.Module.Name == "Learnings.dll").ToList();

if (false)
{
    Inheritance inheritance = new Inheritance();
    inheritance.Method1();
    inheritance.Method2();
}


if (false)
{
    Serialization objSerialization = new Serialization();
    objSerialization.DataSerialize();
    object deSerializedData = objSerialization.DataDeSerialize();
}

if (false)
{
    TextDoc obj = new TextDoc();
    obj.ReadWriteDoc();
}

if (false)
{
    XMLReader reader = new XMLReader();
    reader.ReadXML();
}

//Abstract Class
if (false)
{
    DerivedClass obj = new DerivedClass();
    obj.SampleAbstractMethod();
    obj.SampleVirtualMethod();
    obj.SampleDemoMethod();
}

//Bits 
if (true)
{
    Bit objBit = new Bit();
    objBit.sampleMethod();
}


//Single Linked List 
if (false)
{
    Console.WriteLine("Linked List");
    SLinkedList ObjSLinkedList = new SLinkedList(null);
    ObjSLinkedList.CreatingLinkedList();
}


// Sorting
if (false)
{
    Console.WriteLine("Sorting");
    Sorting sort = new Sorting();
    sort.MergeSorting();
}


//Searching Bar Problem 
if (false)
{
    Console.WriteLine("Search Bar Problem");
    SearchBar searchBar = new SearchBar();
    searchBar.SearchBarImplementation();
}

//Delegate
if (false)
{
    Console.WriteLine("Delegate");
    DelegateClass objDeleagte = new DelegateClass();
    objDeleagte.DelegateMethod();
}


