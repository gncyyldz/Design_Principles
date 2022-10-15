#region Not Ideal Code
//using Liskov_Substitution_Principle_NotIdealCode;
//Cloud cloud = new AWS();
//cloud.MachineLearning();
//cloud.Translate();

//cloud = new Google();
//cloud.MachineLearning();
//cloud.Translate();

//cloud = new Azure();
//cloud.MachineLearning();
//if (cloud is not Azure)
//{
//    cloud.Translate();
//}
#endregion

#region Ideal Code
//using Liskov_Substitution_Principle_IdealCode;
//Cloud cloud = new AWS();
//cloud.MachineLearning();
//(cloud as ITranslatable)?.Translate();

//cloud = new Google();
//cloud.MachineLearning();
//(cloud as ITranslatable)?.Translate();

//cloud = new Azure();
//cloud.MachineLearning();
//(cloud as ITranslatable)?.Translate();
#endregion