// by Lee Dumond - http://leedumond.com
namespace LD.Sample.BLL
{
   using System;

   [Serializable]
   public class Personal
   {
      public string FirstName { get; set; }

      public string LastName { get; set; }

      public DateTime DateOfBirth { get; set; }

      public Gender Gender { get; set; }
   }
}