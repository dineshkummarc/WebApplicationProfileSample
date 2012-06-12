// by Lee Dumond - http://leedumond.com
namespace LD.Sample.WAP
{
   using System;
   using System.Globalization;
   using System.Linq;
   using BLL;

   public partial class Demo : BasePage
   {
      
      protected void Page_Load(object sender, EventArgs e)
      {
         if (!IsPostBack)
         {
            this.BindGenderDropDownList();
            this.BindTimeZonesDropDownList();
            this.BindCulturesDropDownList();            
         }

         if (!string.IsNullOrEmpty(txtUserName.Text))
         {
            Profile = CustomProfile.GetProfile(txtUserName.Text);
         }
      }

      protected void btnGo_Click(object sender, EventArgs e)
      {
         this.DisplayProfile();
      }

      protected void btnEdit_Click(object sender, EventArgs e)
      {
         this.EditProfile();
      }

      protected void btnCancelDisplay_Click(object sender, EventArgs e)
      {
         this.ResetElements();
      }

      protected void btnSave_Click(object sender, EventArgs e)
      {
         this.SaveProfile();         
      }

      protected void btnCancelEdit_Click(object sender, EventArgs e)
      {
         this.ResetElements();
      }

      private void DisplayProfile()
      {
         this.SetElementsForDisplaying();        

         litFirstName.Text = this.Profile.Personal.FirstName;
         litLastName.Text = this.Profile.Personal.LastName;
         litDateOfBirth.Text = this.Profile.Personal.DateOfBirth.ToString("d", CultureInfo.InstalledUICulture);
         litGender.Text = this.Profile.Personal.Gender.ToString();
         litTimeZone.Text = this.Profile.Preferences.TimeZone;
         if (this.Profile.Preferences.Culture != null)
         {
            litCulture.Text = CultureInfo.GetCultureInfo(this.Profile.Preferences.Culture).DisplayName;
         }
      }

      private void EditProfile()
      {
         this.SetElementsForEditing();

         txtFirstName.Text = this.Profile.Personal.FirstName;
         txtLastName.Text = this.Profile.Personal.LastName;
         txtDateOfBirth.Text = this.Profile.Personal.DateOfBirth.ToString("d", CultureInfo.InstalledUICulture);
         ddlGender.SelectedValue = this.Profile.Personal.Gender.ToString();
         ddlTimeZones.SelectedValue = this.Profile.Preferences.TimeZone;
         ddlCultures.SelectedValue = this.Profile.Preferences.Culture;
      }

      private void SaveProfile()
      {
         this.Profile.Personal.FirstName = txtFirstName.Text;
         this.Profile.Personal.LastName = txtLastName.Text;
         this.Profile.Personal.DateOfBirth = DateTime.Parse(txtDateOfBirth.Text);
         this.Profile.Personal.Gender = (Gender) Enum.Parse(typeof(Gender), ddlGender.SelectedValue, true);
         this.Profile.Preferences.TimeZone = ddlTimeZones.SelectedValue;
         this.Profile.Preferences.Culture = ddlCultures.SelectedValue;

         this.Profile.Save();

         this.ResetElements();
      }

      private void SetElementsForDisplaying()
      {
         pnlStart.Visible = false;
         pnlDisplayValues.Visible = true;
         pnlSetValues.Visible = false;
         litUserTitle.Visible = true;
         litUserTitle.Text = string.Format("Display profile for {0}", this.Profile.UserName);
      }

      private void SetElementsForEditing()
      {
         pnlStart.Visible = false;
         pnlDisplayValues.Visible = false;
         pnlSetValues.Visible = true;
         litUserTitle.Visible = true;
         litUserTitle.Text = string.Format("Edit profile for {0}", this.Profile.UserName);
      }

      private void ResetElements()
      {
         pnlStart.Visible = true;
         pnlSetValues.Visible = false;
         pnlDisplayValues.Visible = false;
         litUserTitle.Visible = false;
         txtUserName.Text = string.Empty;
      }

      private void BindGenderDropDownList()
      {
         ddlGender.DataSource = Enum.GetValues(typeof(Gender));
         ddlGender.DataBind();
      }

      private void BindCulturesDropDownList()
      {
         CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
         ddlCultures.DataSource = cultures.OrderBy(c => c.DisplayName);
         ddlCultures.DataTextField = "DisplayName";
         ddlCultures.DataValueField = "Name";
         ddlCultures.DataBind();
      }

      private void BindTimeZonesDropDownList()
      {
         ddlTimeZones.DataSource = TimeZoneInfo.GetSystemTimeZones();
         ddlTimeZones.DataTextField = "DisplayName";
         ddlTimeZones.DataValueField = "Id";
         ddlTimeZones.DataBind();
      }
   }
}