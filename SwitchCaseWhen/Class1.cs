using System;

namespace SwitchCaseWhen
{
   public class Class1
   {
      public bool SwitchCaseThatFails(object someObject)
      {
         switch (someObject)
         {
            case string x:
               return true;
            case int x:
               return true;
            case IObject x when x.SubObject != null:
               return true;
            case IOtherObject x:
               return true;
            case double x:
               return true;
            default:
               return false;
         }
      }

      public bool SwitchCaseThatWorks(object someObject)
      {
         switch (someObject)
         {
            case string x:
               return true;
            case int x:
               return true;
            case IObject x when x.SubObject != null:
               return true;
            case IObject x:
               return true;
            case IOtherObject x:
               return true;
            case double x:
               return true;
            default:
               return false;
         }
      }
      public interface IObject
      {
         IObject SubObject { get; }
      }

      public interface IOtherObject
      {
         
      }
   }
}
