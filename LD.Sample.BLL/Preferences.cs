// by Lee Dumond - http://leedumond.com
namespace LD.Sample.BLL
{
   using System;

   [Serializable]
   public class Preferences
   {
      public string TimeZone { get; set; }
      
      public string Culture { get; set; }
   }
}