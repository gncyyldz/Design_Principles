#region Not Ideal Code
//using Interface_Segregation_Principle_NotIdealCode;
//SamsungPrinter printer = new();
//printer.PrintDuplex();
#endregion
#region Ideal Code
using Interface_Segregation_Principle_IdealCode;
SamsungPrinter printer = new();
printer.Fax();
#endregion