// by Lee Dumond - http://leedumond.com
namespace LD.Sample.WAP
{
   using System.Web.UI;
   using BLL;

   public abstract class BasePage : Page
   {
      private CustomProfile profile;

      protected CustomProfile Profile
      {
         get
         {
            if (profile == null)
            {
               profile = CustomProfile.GetProfile();
            }

            return profile;
         }

         set { profile = value; }
      }
   }
}