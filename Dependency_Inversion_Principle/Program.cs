#region Not Ideal Code
//using Dependency_Inversion_Principle_NotIdealCode;
//MailService mailService = new();
//mailService.SendMail(new Gmail());
#endregion
#region Ideal Code
using Dependency_Inversion_Principle_IdealCode;
MailService mailService = new();
mailService.SendMail(new Gmail(), "...", "...");
mailService.SendMail(new Hotmail(), "...", "...");
#endregion