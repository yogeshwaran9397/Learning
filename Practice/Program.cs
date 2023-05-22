using CSharp.DelegateAndEvents;
using CSharp.Topics;
using Practice;
using Practice.Collections;
using Practice.Var_and_Data_Types;
using CSharp.DelegateAndEvents;
using CSharp.Topics;
using System;


if (true)
{
    SampleProblem sampleProblem = new SampleProblem();
    //sampleProblem.IdentifyMinMaxNumber();
    sampleProblem.IdentifyNumerMinMax();
}

if (false)
{
    StringOperations objStringOperation = new StringOperations();
    objStringOperation.MethodStringOperations();
}

if (false)
{
    ArrayCollection obj = new ArrayCollection();
}

if (true)
{
    Reverse objRev = new Reverse();
    objRev.ReverseValue();
}

if (false)
{
    #region Timer 

    TimerExample objtimer = new TimerExample();
    Thread.Sleep(10000);
    #endregion
}

if (false)
{
    #region Generics 

    Generics<string> objGenericsString = new Generics<string>("Yogesh");
    objGenericsString.GetType();

    Generics<int> objGenericsInt = new Generics<int>(1);
    objGenericsInt.GetType();

    #endregion
}


if (false)
{
    #region StringBuilder  
    ExampleStringBuilderClass.ExampleStringBuilder();
    #endregion
}

if (false)
{
    #region Event Delegates Example

    EventDelegateHelper.Example_Event();
    EventDelegateHelper.ExampleDelegates();

    #endregion
}