using System;

namespace ClassEnum
{
    public static class Program
    {
        public static void Main()
        {
            Console.ReadLine();
        }

        public static string GetCourseSubjectName(CourseType subject)
        {
            //return the enum subject as a string. 
            //IOW, if you pass in CourseSubject.Math, the method should return "Math".

            switch (subject)
            {
                case CourseType.Biology:
                    return "Biology";
                case CourseType.Composition:
                    return "Composition";
                case CourseType.English:
                    return "English";
                case CourseType.French:
                    return "French";
                case CourseType.Geography:
                    return "Geography";
                case CourseType.History:
                    return "History";
                case CourseType.Math:
                    return "Math";
                case CourseType.Science:
                    return "Science";
                case CourseType.Spanish:
                    return "Spanish";
                case CourseType.WorldHistory:
                    return "WorldHistory";
                default:
                    return null;
            }
        }
    }

    //Create an enum named CourseSubject. 
    //It should contain at least 8 subjects, two of which must be Geography and WorldHistory
    public enum CourseType
    {
        History,
        Geography,
        WorldHistory,
        Biology,
        Science,
        Math,
        English,
        Spanish,
        French,
        Composition
    }
}
