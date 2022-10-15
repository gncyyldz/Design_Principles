using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle_NotIdealCode;
abstract class Cloud
{
    public abstract void Translate();
    public abstract void MachineLearning();
}
class AWS : Cloud
{
    override public void Translate()
        => Console.WriteLine("AWS Translate");
    override public void MachineLearning()
        => Console.WriteLine("AWS Machine Learning");
}

class Azure : Cloud
{
    override public void Translate()
        => throw new NotImplementedException();

    override public void MachineLearning()
        => Console.WriteLine("Azure Machine Learning");
}

class Google : Cloud
{
    override public void Translate()
        => Console.WriteLine("Google Translate");

    override public void MachineLearning()
        => Console.WriteLine("Google Machine Learning");
}